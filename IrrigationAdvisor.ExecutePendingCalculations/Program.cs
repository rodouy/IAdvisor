using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrrigationAdvisor;
using IrrigationAdvisor.DBContext.Management;
using IrrigationAdvisor.DBContext.Irrigation;
using IrrigationAdvisor.DBContext;
using NLog;
using IrrigationAdvisor.Models.Utilities;

namespace IrrigationAdvisor.ExecutePendingCalculations
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            string config = System.Configuration.ConfigurationManager.AppSettings["Status"];

            try
            {
                using (Entities entities = new Entities())
                {
                    bool isExecuting = entities.CalculationByCropIrrigationWeathers
                                       .Any(n => n.IsExecuting);
                  
                    DateTime referenceDate = entities.Status.First(n => n.Name == config).DateOfReference;

                    if (!isExecuting)
                    {
                        logger.Log(LogLevel.Info, "Buscando CIW pendientes de procesar.");

                        var pendings = entities.CalculationByCropIrrigationWeathers
                                  .Where(n => !n.IsCompleted)
                                  .Select(n => n.CropIrrigationWeatherId)
                                  .Distinct()
                                  .ToList();

                        logger.Log(LogLevel.Info, "Fin de búsqueda CIW pendientes de procesar.");

                        var lIrrigationUnitConfiguration = new IrrigationUnitConfiguration();

                        logger.Log(LogLevel.Info, "Buscando los CIW para procesar.");

                        var cropIrrigationWeathers = lIrrigationUnitConfiguration.GetCropIrrigationWeatherListBy(pendings);

                        logger.Log(LogLevel.Info, "Fin de obtención de ciw.");

                        var lIrrigationAdvisorContext = IrrigationAdvisorContext.Instance();

                        if (cropIrrigationWeathers.Any())
                        {
                            Utils.SetStatusAsMaintenaince(config);
                        }

                        foreach (var item in cropIrrigationWeathers)
                        {                          
                            var executionProcess = entities.CalculationByCropIrrigationWeathers
                                                   .Where(n => n.CropIrrigationWeatherId == item.CropIrrigationWeatherId)
                                                   .ToList();

                            foreach (var e in executionProcess)
                            {
                                e.IsExecuting = true;
                            }

                            entities.SaveChanges();

                            logger.Log(LogLevel.Info, "Procesando CIW " + item.CropIrrigationWeatherId);

                            item.AddInformationToIrrigationUnits(referenceDate.AddDays(-5), referenceDate, lIrrigationAdvisorContext);
                            lIrrigationAdvisorContext.SaveChanges();

                            foreach (var e in executionProcess)
                            {
                                e.IsExecuting = false;
                                e.IsCompleted = true;
                            }

                            entities.SaveChanges();

                            logger.Log(LogLevel.Info, "Fin de procesamiento de CIW " + item.CropIrrigationWeatherId);
                        }

                        logger.Log(LogLevel.Info, "Fin de procesamiento general.");
                    }
                    else
                    {
                        logger.Log(LogLevel.Info, "No se puede comenzar un nuevo procesamiento ya que hay un procesamiento en ejecución.");
                    }                  
                }
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, ex);
            }     
            finally
            {
                Utils.SetStatusAsOnline(config);
            }      
        }
    }
}
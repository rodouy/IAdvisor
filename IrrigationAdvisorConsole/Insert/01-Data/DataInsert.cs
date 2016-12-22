using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Utilities;

using IrrigationAdvisor.DBContext;

namespace IrrigationAdvisorConsole.Insert._01_Data
{
    public static class DataInsert
    {

        #region Data

        public static void InsertStatus()
        {

            var lDefaultStatus = new Status()
            {
                StatusId = 0,
                Name = "Default",
                DateOfReference = Utils.MIN_DATETIME,
                WebStatus = Utils.IrrigationAdvisorWebStatus.WithNoData,
                Description = "Default Web Status",
            };

            var lProductionStatus = new Status()
            {
                StatusId = 1,
                Name = "Production",
                DateOfReference = Program.DateOfReference, // new DateTime(2016, 10, 13),
                WebStatus = Utils.IrrigationAdvisorWebStatus.Online,
                Description = "Web Status of Production",
            };

            var lDemoStatus = new Status()
            {
                StatusId = 2,
                Name = "Demo",
                DateOfReference = Program.DateOfReference, // new DateTime(2016, 10, 13),
                WebStatus = Utils.IrrigationAdvisorWebStatus.Online,
                Description = "Web Status of Demo",
            };

            using (var context = new IrrigationAdvisorContext())
            {
                context.Status.Add(lDefaultStatus);
                context.Status.Add(lProductionStatus);
                context.Status.Add(lDemoStatus);
                context.SaveChanges();
            }
        }

        #endregion

    }
}

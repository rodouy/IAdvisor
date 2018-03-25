using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrrigationAdvisor;
using System.Reflection;

namespace IrrigationAdvisor.ConstantSyncronization
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var fields = GetConstants(typeof(Models.Data.InitialTables));

                using (var context = new ConfigurationManagerEntities())
                {
                    bool any = false;

                    foreach (var item in fields)
                    {
                        // Console.WriteLine(item.Name + " - " + item.FieldType + " - " + item.GetRawConstantValue());
                        if (item.FieldType == typeof(string) || item.FieldType == typeof(String))
                        {
                            any = context.StringValues.Any(n => n.Name == item.Name);

                            if (!any)
                            {
                                StringValues stringValue = new StringValues()
                                {
                                    CreationDate = DateTime.Now,
                                    LastModificationBy = "Carga Inicial",
                                    Name = item.Name,
                                    Value = item.GetRawConstantValue().ToString()
                                };

                                context.StringValues.Add(stringValue);
                            }
                        }
                        else if (item.FieldType == typeof(int) ||
                                    item.FieldType == typeof(Int32) ||
                                    item.FieldType == typeof(long) ||
                                    item.FieldType == typeof(Int64))
                        {
                            if (!any)
                            {
                                IntegerValues integerValue = new IntegerValues()
                                {
                                    CreationDate = DateTime.Now,
                                    LastModificationBy = "Carga Inicial",
                                    Name = item.Name,
                                    Value = Convert.ToInt64(item.GetRawConstantValue())
                                };

                                context.IntegerValues.Add(integerValue);
                            }
                        }
                        else if (item.FieldType == typeof(double) ||
                                    item.FieldType == typeof(Double) ||
                                    item.FieldType == typeof(decimal) ||
                                    item.FieldType == typeof(Decimal))
                        {
                            if (!any)
                            {
                                DecimalValues decimalValue = new DecimalValues()
                                {
                                    CreationDate = DateTime.Now,
                                    LastModificationBy = "Carga Inicial",
                                    Name = item.Name,
                                    Value = Convert.ToDecimal(item.GetRawConstantValue())
                                };

                                context.DecimalValues.Add(decimalValue);
                            }
                        }
                    }

                    context.SaveChanges();
                }

                Console.Write("End !!!");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private static List<FieldInfo> GetConstants(Type type)
        {
            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Public |
                 BindingFlags.Static | BindingFlags.FlattenHierarchy);

            return fieldInfos.Where(fi => fi.IsLiteral && !fi.IsInitOnly).ToList();
        }
    }
}

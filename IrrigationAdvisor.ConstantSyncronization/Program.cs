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
            ProcessConstants();
            ProcessEnumerations();
            Console.ReadLine();
        }

        private static void ProcessConstants()
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

                Console.Write("End Constants!!!");
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

        private static void ProcessEnumerations()
        {
            try
            {
                using (var context = new ConfigurationManagerEntities())
                {
                    foreach (Type enumType in Assembly.GetAssembly(typeof(IrrigationAdvisor.Controllers.HomeController)).GetTypes()
                           .Where(x => x.IsSubclassOf(typeof(Enum))))
                    {
                        // Console.WriteLine(enumType.Name);
                        var values = enumType.GetEnumValues();

                        var enums = context.EnumValues.ToList();

                        foreach (var item in values)
                        {
                            // Console.WriteLine("---- " + item.ToString() + " -- " + item.GetHashCode());

                            var any = enums.Any(n => n.Type == enumType.Name && n.Name == item.ToString() && n.Value == item.GetHashCode());

                            if (!any)
                            {
                                EnumValues enumValues = new EnumValues()
                                {
                                    CreationDate = DateTime.Now,
                                    LastModificationBy = "Carga inicial",
                                    Type = enumType.Name,
                                    Name = item.ToString(),
                                    Value = item.GetHashCode()
                                };

                                context.EnumValues.Add(enumValues);
                            }
                        }
                    }

                    context.SaveChanges();
                }

                Console.Write("End Enumerations!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }      
        }
    }
}

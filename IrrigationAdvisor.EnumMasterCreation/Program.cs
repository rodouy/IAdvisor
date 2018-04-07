using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrrigationAdvisor;
using System.Reflection;

namespace IrrigationAdvisor.EnumMasterCreation
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void Test()
        {
            foreach (Type enumType in Assembly.GetAssembly(typeof(IrrigationAdvisor.Controllers.HomeController)).GetTypes()
                        .Where(x => x.IsSubclassOf(typeof(Enum))))
            {
                Console.WriteLine(enumType.Name);
                var values = enumType.GetEnumValues();

                foreach (var item in values)
                {
                    Console.WriteLine("---- " + item.ToString() + " -- " + item.GetHashCode());
                }
            }
        }
    }
}

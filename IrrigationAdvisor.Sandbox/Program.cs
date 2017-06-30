using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace IrrigationAdvisor.Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

            byte[] data = new byte[64];
            rngCsp.GetBytes(data);

            string dataAsString = Convert.ToBase64String(data);

            Console.WriteLine(dataAsString.Substring(0,10));
            Console.ReadLine();

        }
    }
}

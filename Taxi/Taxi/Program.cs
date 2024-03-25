using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            layanan saya = new layanan();

            saya.Supir = "Century";
            saya.Status = true;
            saya.Penumpang = 10;

            saya.info();
            saya.pickuppassenger();
            saya.dropofpassenger();

            Console.ReadKey();
        }
    }
}

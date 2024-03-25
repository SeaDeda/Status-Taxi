using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class layanan
    {
        public string Supir {  get; set; }
        public bool Status { get; set; }
        public int Penumpang { get; set; }

        public void info()
        {
            Console.WriteLine("Driver Name: {0}", Supir);
            if (Status == true)
            {
                Console.WriteLine("On Duty: Yes");
            }
            Console.WriteLine("Number of Passenger: {0}\n", Penumpang);
        }

        public void pickuppassenger()
        {
            Console.WriteLine("{0} sedang dalam perjalanan", Supir);
        }

        public void dropofpassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", Supir);
        }
    }
}

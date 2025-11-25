using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Workshop5
{
    internal class Motorcycle: Vehicle
    {
        public bool HasCarrier { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Carrier: {HasCarrier}");
        }
    }
}

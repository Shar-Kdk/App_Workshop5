using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Workshop5
{
    internal class AbsBike : AbsVehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started.");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped.");
        }
    }
}

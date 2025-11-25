using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App_Workshop5
{
    internal class NepaliTeacher : Teacher
    {
        public override void Teaching()
        {
            Console.WriteLine($"{Name} teaches in Nepali.");
        }
    }
}

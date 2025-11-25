using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Workshop5
{
    internal class Teacher
    {
        public string Name { get; set; }

        public virtual void Teaching()
        {
            Console.WriteLine($"{Name} teaches in English.");
        }

        public void SalaryInfo()
        {
            Console.WriteLine($"{Name}'s salary details are confidential.");
        }
    }
}

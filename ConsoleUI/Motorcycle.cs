using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("Drive Motorcycle");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
            Console.WriteLine("Adding on to the virual class");
        }
    }
}

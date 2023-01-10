using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; }
        public int TrunkSpace { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Drive Car");
        }
    }
}

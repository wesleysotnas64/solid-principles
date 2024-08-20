using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Dependecy_Inversion_Principle
{
    public class Light : SwitchableDevice
    {
        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("The Light is on!");
        }

        public override void TurnOff()
        {
            Console.WriteLine("The Light is off!");
            IsOn = false;
        }
    }
}

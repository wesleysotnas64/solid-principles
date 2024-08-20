using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Interface_Segregation_Principle
{
    public class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot working!");
        }
    }
}

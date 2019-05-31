using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParkingApp
{
    public class Car : Vehicle
    {
        public Car(Dimension dimension = Dimension.middle)
            : base(dimension)
        { }
    }
}

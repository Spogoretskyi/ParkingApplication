using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParkingApp
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(Dimension dimension = Dimension.small)
            : base(dimension)
        { }
    }
}

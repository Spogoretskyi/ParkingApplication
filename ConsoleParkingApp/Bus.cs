using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParkingApp
{
    public class Bus : Vehicle
    {
        public Bus(Dimension dimension = Dimension.large)
            : base(dimension)
        { }
    }
}

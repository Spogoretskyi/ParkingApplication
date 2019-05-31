using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParkingApp
{
    public abstract class Vehicle
    {
        Dimension _dimension;
        public Dimension GetDimension => _dimension;
        public Vehicle(Dimension dimension)
        {
            _dimension = dimension;
        }
    }
}

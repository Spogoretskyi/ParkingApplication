using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParkingApp
{
    public class LargeSlot : SlotBase
    {
        public LargeSlot(int id, Dimension dimension) 
            : base(id, dimension)
        { }
    }
}

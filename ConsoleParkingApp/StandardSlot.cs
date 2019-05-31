using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParkingApp
{
    public class StandardSlot : SlotBase
    {
        public StandardSlot(int id, Dimension dimension)
            : base(id, dimension)
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParkingApp
{
    public abstract class SlotBase
    {
        int _id;
        bool _isEmpty;
        Dimension _dimension;
        public Dimension GetDimension => _dimension;
        public int Id => _id;
        public bool IsEmpty
        {
            get { return _isEmpty; }
            set { _isEmpty = value; }
        }
        public SlotBase(int id, Dimension dimension)
        {
            _id = id;
            _dimension = dimension;
            _isEmpty = true;
        }
    }
}

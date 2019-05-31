using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParkingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Dimension, List<Dimension>> _parkingDimensionDictionary = new Dictionary<Dimension, List<Dimension>>();
            _parkingDimensionDictionary.Add(Dimension.small, new List<Dimension> { Dimension.small });
            _parkingDimensionDictionary.Add(Dimension.middle, new List<Dimension> { Dimension.small,  Dimension.middle });
            _parkingDimensionDictionary.Add(Dimension.large, new List<Dimension> { Dimension.small, Dimension.middle, Dimension.large });

            Parking parking = new Parking(SetSlots(), _parkingDimensionDictionary);
            parking.Park(new Car());
            parking.Park(new Car());
            parking.Park(new Car());
            parking.Park(new Motorcycle());
            parking.Park(new Motorcycle());
            parking.Park(new Motorcycle());
            parking.Park(new Motorcycle());
            parking.Park(new Motorcycle());
            // parking.Show();
            parking.ShowDimensions();


        }
        static SlotBase[][] SetSlots()
        {
            SlotBase[][] slots = new SlotBase[3][];
            slots[0] = new SlotBase[] { new SmallSlot(1, Dimension.small),
                                        new SmallSlot(2, Dimension.small),
                                        new SmallSlot(3, Dimension.small),
                                        new SmallSlot(4, Dimension.small),
                                        new SmallSlot(5, Dimension.small),
                                        new StandardSlot(6, Dimension.middle),
                                        new StandardSlot(7, Dimension.middle),
                                        new StandardSlot(8, Dimension.middle),
                                        new StandardSlot(9, Dimension.middle),
                                        new StandardSlot(10, Dimension.middle),
                                        new StandardSlot(11, Dimension.middle),
                                        new StandardSlot(12, Dimension.middle),
                                        new StandardSlot(13, Dimension.middle),
                                        new StandardSlot(14, Dimension.middle),
                                        new StandardSlot(15, Dimension.middle),
                                        new StandardSlot(16, Dimension.middle),
                                        new StandardSlot(17, Dimension.middle)};
            slots[1] = new SlotBase[] { new StandardSlot(18, Dimension.middle),
                                        new StandardSlot(19, Dimension.middle),
                                        new StandardSlot(20, Dimension.middle),
                                        new StandardSlot(21, Dimension.middle),
                                        new StandardSlot(22, Dimension.middle),
                                        new LargeSlot(23, Dimension.large),
                                        new LargeSlot(24, Dimension.large),
                                        new LargeSlot(25, Dimension.large),
                                        new LargeSlot(26, Dimension.large),
                                        new LargeSlot(27, Dimension.large),
                                        new LargeSlot(28, Dimension.large) };
            slots[2] = new SlotBase[] { new SmallSlot(29, Dimension.small),
                                        new SmallSlot(30, Dimension.small),
                                        new SmallSlot(31, Dimension.small),
                                        new SmallSlot(32, Dimension.small),
                                        new SmallSlot(33, Dimension.small),
                                        new StandardSlot(34, Dimension.middle),
                                        new StandardSlot(35, Dimension.middle),
                                        new StandardSlot(36, Dimension.middle),
                                        new StandardSlot(37, Dimension.middle),
                                        new StandardSlot(38, Dimension.middle),
                                        new StandardSlot(39, Dimension.middle),
                                        new StandardSlot(40, Dimension.middle),
                                        new StandardSlot(41, Dimension.middle),
                                        new StandardSlot(42, Dimension.middle),
                                        new StandardSlot(43, Dimension.middle)};
            return slots;
        }
    }
}

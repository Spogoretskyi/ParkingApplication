using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParkingApp
{
    public class Parking : IPark
    {
        SlotBase[][] _slotBase;
        Dictionary<Dimension, List<Dimension>> _parkingDimensionDictionary;
        public Parking(SlotBase[][] slotBase, Dictionary<Dimension, List<Dimension>> parkingDimensionDictionary)
        {
            _slotBase = slotBase;
            _parkingDimensionDictionary = parkingDimensionDictionary;
        }

        public bool Park(Vehicle vehicle)
        {
            if(vehicle.GetDimension == Dimension.large)
            {
                var largeSlots = _slotBase.FirstOrDefault().Where(x => x.GetDimension == Dimension.large);

            }

            var freeSlots = _slotBase.FirstOrDefault(c => c.FirstOrDefault().GetDimension == vehicle.GetDimension);
            var freeSlot = freeSlots.FirstOrDefault(x => x.IsEmpty == true);



            if (freeSlot != null)
            {
                freeSlot.IsEmpty = false;
                return true;
            }
            return false;
        }

        public void Show()
        {
            int i = 1;
            foreach (var row in _slotBase)
            {
                Console.WriteLine($"Row #{i}");
                foreach (var item in row)
                {
                    Console.WriteLine($"Slot #{ item.Id }\nIs empty = {item.IsEmpty}\nType = {item.GetType().Name}");
                }
                i++;
                Console.WriteLine();
            }
        }
        public void ShowDimensions()
        {
            foreach (var item in _parkingDimensionDictionary)
            {
                Console.WriteLine($"Key --> {item.Key}\n");
                foreach (var element in item.Value)
                {
                    Console.WriteLine($"Val --> {element.ToString()}\n");
                }
                Console.WriteLine();
            }
        }
        public void ShowOccupiedSlots()
        {
            int i = 1;
            foreach (var row in _slotBase)
            {
                Console.WriteLine($"Row #{i}");
                foreach (var item in row)
                {
                    if(!item.IsEmpty)
                        Console.WriteLine($"Slot #{ item.Id }\nIs empty = {item.IsEmpty}\nType = {item.GetType().Name}");
                }
                i++;
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    class SkiRental
    {
        public List<Ski> collection = new List<Ski>();
        public string Name { get; set; }
        public int Capacity { get; set; }
        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
        public void Add(Ski ski)
        {
            if (collection.Count <= Capacity)
            {
                collection.Add(ski);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].Manufacturer == manufacturer && collection[i].Model == model)
                {
                    collection.RemoveAt(i);
                    return true;    
                }
            }           
            return false;
        }
        public Ski GetNewestSki()
        {
            if (collection.Count != 0)
            {
                return collection[collection.Count - 1];
            }
            return null;
        }
        public Ski GetSki(string manufacturer, string model)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].Manufacturer == manufacturer && collection[i].Model == model)
                {                    
                    return collection[i];
                }
            }
            return null;
        }
        public int Count => collection.Count;
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine( $"The skis stored in {Name}:");
            foreach (var item in collection)
            {
                sb.AppendLine(item.ToString().Trim());
            }
            return sb.ToString().TrimEnd();
        }
    }
}

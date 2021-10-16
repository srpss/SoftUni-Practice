using System;
using System.Collections.Generic;
using System.Text;

namespace StreetRacing
{
    class Race
    {
        public List<Car> Participants = new List<Car>();
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Participants = new List<Car>();
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
        }
        public int Count => Participants.Count;
        public void Add(Car car)
        {
            if (car.HorsePower <= MaxHorsePower && car.HorsePower > 0)
            {
                if (Participants.Count < this.Capacity)
                {
                    bool checkLicense = true;
                    foreach (var item in Participants)
                    {
                        if (item.LicensePlate == car.LicensePlate)
                        {
                            checkLicense = false;
                            break;
                        }
                    }
                    if (checkLicense)
                    {
                        Participants.Add(car);
                    }
                }
            }
        }
        public bool Remove(string licensePlate)
        {
            for (int i = 0; i < Participants.Count; i++)
            {
                if (Participants[i].LicensePlate == licensePlate)
                {
                    Participants.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public Car FindParticipant(string licensePlate)
        {
            for (int i = 0; i < Participants.Count; i++)
            {
                if (Participants[i].LicensePlate == licensePlate)
                {
                    return Participants[i];
                }
            }
            return null;
        }
        public Car GetMostPowerfulCar()
        {
            if (Participants.Count != 0)
            {
                Car fastest = new Car("", "", "", 0, 10);
                foreach (var item in Participants)
                {
                    if (item.HorsePower > fastest.HorsePower)
                    {
                        fastest = item;
                    }
                }
                return fastest;
            }
            return null;
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} - (Laps: {Laps})");
            foreach (var item in Participants)
            {
                sb.AppendLine( $"{item.ToString().TrimEnd()}");
            }
            return sb.ToString();
        }
    }
}

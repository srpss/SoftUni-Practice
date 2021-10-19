using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    class Guild
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        List<Player> roaster = new List<Player>();
        public Guild(string name, int capacity)
        {
            roaster = new List<Player>();
            Name = name;
            Capacity = capacity;

        }
        public void AddPlayer(Player player)
        {
            if (Capacity >= roaster.Count)
            {
                roaster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            for (int i = 0; i < roaster.Count; i++)
            {
                if (roaster[i].Name == name)
                {
                    roaster.RemoveAt(i);
                    return true;
                }                
            }
            return false;
        }
        public void PromotePlayer(string name)
        {
            foreach (var item in roaster)
            {
                if (item.Name == name)
                {
                    item.Rank = "Member";
                    break;
                }
            }
        }
        public void DemotePlayer(string name)
        {
            foreach (var item in roaster)
            {
                if (item.Name == name)
                {
                    item.Rank = "Trial";
                    break;
                }
            }
        }
        public Player [] KickPlayersByClass(string class1) 
        {
            List<Player> players = new List<Player>();
            for (int i = 0; i < roaster.Count; i++)
            {
                if (roaster[i].Class == class1)
                {
                    players.Add(roaster[i]);
                    roaster.RemoveAt(i);
                    i--;
                }
            }
            return players.ToArray();
        }
        public int Count => roaster.Count;
        public string Report()
        {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Players in the guild: {Name}".TrimEnd());
            foreach (var item in roaster)
            {
                data.AppendLine(item.ToString());
            }
            return data.ToString().Trim() ;
        }
    }
}

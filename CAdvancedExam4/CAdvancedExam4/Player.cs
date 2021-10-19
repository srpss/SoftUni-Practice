using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    class Player
    {
        public string Name { get; set; }
        public string Class { get; set; }

        public string Rank { get; set; }
     
        public string Description { get; set; }
     
        public override string ToString()
        {
            return $"Player {Name}: {Class}\nRank: {Rank}\nDescription: {Description}".Trim();
        }
        public Player(string name, string class1)
        {
            Name = name;
            Class = class1;
            Rank = "Trial";
            Description = "n/a";
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team 
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            Name = name;
            List<Person> firstTeam = new List<Person>();
            List<Person> reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam { get => firstTeam.AsReadOnly(); private set { } }
        public IReadOnlyCollection<Person> ReserveTeam { get => reserveTeam.AsReadOnly(); private set { }  }
        public string Name { get => name; private set { } }       
        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }
    }
}

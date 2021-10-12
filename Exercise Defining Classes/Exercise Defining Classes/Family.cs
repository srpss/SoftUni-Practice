using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DefiningClasses
{
    public class Family
    {
        public List<Person> People { get; set; }
        public Family()
        {
            People = new List<Person>();
        }
        public void AddMember(Person member)
        {
            People.Add(member);
        }
        public Person GetOldestMember()
        {
            Person oldestMember = People.OrderByDescending(n => n.Age).FirstOrDefault();
            return oldestMember;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember()
        {
            int oldest = int.MinValue;
            Person person = null;

            foreach (var item in People)
            {
                if (item.Age > oldest)
                {
                    oldest = item.Age;
                    person = item;
                }
            }
            return person;
        }
    }
}

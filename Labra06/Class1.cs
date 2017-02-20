using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Person
    {
        //properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SocialSecurityNumber { get; set; }
        //constructor
        public Person(string firstname, string lastname, string socialsec)
        {
            Firstname = firstname;
            Lastname = lastname;
            SocialSecurityNumber = socialsec;
        }
        //methods
        public override string ToString()
        {
            return String.Format("{0} {1} SocialSecNum: {2}", Firstname, Lastname, SocialSecurityNumber);
        }
    }
    class People
    {
        //members=jäsenmuuttujat
        private List<Person> people;
        //constructor
        public People()
        {
            people = new List<Person>();
        }
        //methods
        public void AddPerson(Person person)
        {
            people.Add(person);
        }
        public Person Get(int index)
        {
            if (index < people.Count)
            {
                return people.ElementAt(index);
            }
            else
                return null;
        }
        public Person Find(string socialsec)
        {
            foreach (Person p in people)
            {
                if (p.SocialSecurityNumber.Equals(socialsec))
                {
                    return p;
                }
            }
            return null;
        }
        public void ShowPeople()
        {
            foreach (Person p in people)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
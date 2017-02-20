using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void TestPersonClass()
        {
            //luodaan ns. henkilörekisteri
            People myFriends = new People();
            //lisätään muutama kaveri
            myFriends.AddPerson(new Person("Make", "Jonnezki", "060606-206E"));
            myFriends.AddPerson(new Person("Jone", "Megaman", "696969-103H"));
            myFriends.AddPerson(new Person("Valtteri", "Puonti", "123123-609U"));
            myFriends.AddPerson(new Person("Teppo", "Testaaja", "010101-1111"));
            //näytetään rekisteri
            Console.WriteLine("***********Kaverit**********");
            myFriends.ShowPeople();
            //testataan kaverin hakua
            Console.WriteLine("Anna kaverinumero");
            string retval = Console.ReadLine();
            //huom. Get metodi palauttaa null jos indeksin osoittamaa kaveira ei löydy
            Person searchedFriend = myFriends.Get(int.Parse(retval));
            if (searchedFriend != null)
            {
                Console.WriteLine(String.Format("Löytyi ystävä nimeltä {0}.", searchedFriend.ToString()));
            }
            else
            {
                Console.WriteLine("Kaveria ei löytynyt annetulla nrolla!");
            }
            //testataan kaverin hakua HETUlla
            Console.WriteLine("Anna kaverin hetu: ");
            retval = Console.ReadLine();
            Person socialFoundFriend = myFriends.Find(retval);
            if (socialFoundFriend != null)
            {
                Console.WriteLine("Found a friend!");
                Console.WriteLine(socialFoundFriend.ToString());
            }
            else
            {
                Console.WriteLine("Nobody found..");
            }
        }
        static void Main(string[] args)
        {
            TestPersonClass();
        }
    }
}
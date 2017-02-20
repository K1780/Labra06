using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Team
    {
        //properties
        public string Name { get; set; }
        public string FromCity { get; set; }
        private string savepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\PlayerList.txt";
        private List<Player> players;
        private List<string> playerlist;
        //constructor
        public Team()
        {
            players = new List<Player>();
        }
        //methods
        public void AddPlayerToRoster(Player player)
        {
            players.Add(player);
        }
        public void CreateRosterFromTxt()
        {
            playerlist = System.IO.File.ReadAllLines(savepath).ToList();
        }

        public void CreatePlayerTxtFile()
        {
            Console.WriteLine("Creates PlayerList.txt to Desktop");
            System.IO.File.Create(savepath).Dispose();
        }
        public void SaveToPlayerTxt()
        {
            foreach (Player p in players)
            {
                string playerinfo = String.Format("Firstname= \"{0}\", Lastname= \"{1}\", Age= \"{2}\", PlayerNumber= \"{3}\"", p.Firstname, p.Lastname, p.Age, p.PlayerNumber) + Environment.NewLine;
                System.IO.File.AppendAllText(savepath, playerinfo);
            }
        }
        public void ReadPlayerTxt()
        {
            Console.WriteLine(System.IO.File.ReadAllText(savepath));
        }
    }
    class Player
    {
        //properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int PlayerNumber { get; set; }
        //constructor
        public Player()
        {

        }
        public Player(string fname, string lname, int age, int plrnum)
        {
            Firstname = fname;
            Lastname = lname;
            Age = age;
            PlayerNumber = plrnum;
        }
        //methods
        public override string ToString()
        {
            return Firstname + Lastname + Age + PlayerNumber;
        }
    }
}
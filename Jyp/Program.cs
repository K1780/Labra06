using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            //create team
            Team Jyp = new Team();
            //create a player
            Jyp.AddPlayerToRoster(new Player("Juho", "Olkinuora", 26, 45));
            Jyp.AddPlayerToRoster(new Player("Markus", "Ruusu", 19, 97));
            //create empty player txt file
            Jyp.CreatePlayerTxtFile();
            //add playerinfo to txt file
            Jyp.SaveToPlayerTxt();
            Console.WriteLine("Saved playerinfo to PlayerList.txt");
            //read player txt
            Console.WriteLine("The players in PlayerList.txt are: ");
            Jyp.ReadPlayerTxt();
            //create list from txt
            Jyp.CreateRosterFromTxt();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void TryAlbum()
        {
            //make an album
            CD album1 = new CD("Endless Forms Most Beautiful", "Nightwish");
            //add tracks to album
            album1.AddTrack(new Track("Shudder Before the Beautiful", "6:29"));
            album1.AddTrack(new Track("Original Track 2", "6:90"));
            album1.AddTrack(new Track("Bell Rigns IV", "3:23"));
            album1.AddTrack(new Track("Most epic song III", "28:30"));
            //show album data
            Console.WriteLine(album1.ToString());
        }
        static void Main(string[] args)
        {
            TryAlbum();
        }
    }
}
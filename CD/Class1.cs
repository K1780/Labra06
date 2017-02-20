using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class CD
    {
        //properties
        public string Name { get; set; }
        public string Artist { get; set; }
        private List<Track> tracklist;
        //constructor
        public CD(string name, string artist)
        {
            Name = name;
            Artist = artist;
            tracklist = new List<Track>();
        }
        //methods
        public void AddTrack(Track x)
        {
            tracklist.Add(x);
        }
        public override string ToString()
        {
            string retval = String.Format("CD data: \n -Name: {0} \n -Artist: {1} \nTracklist:", Name, Artist);
            foreach (Track track in tracklist)
            {
                retval += String.Format("\n -{0}, Time: {1}", track.TrackName, track.TrackTime);
            }
            return retval;
        }
    }
    class Track
    {
        //properties
        public string TrackName { get; set; }
        public string TrackTime { get; set; }
        //constructor
        public Track(string trackname, string tracktime)
        {
            TrackName = trackname;
            TrackTime = tracktime;
        }
    }
}
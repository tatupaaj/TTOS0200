using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace JAMK.IT
{
    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Song { get; set; }
        public override string ToString()
        {
            return Name + " " + Artist + " " + Song;
        }

    }

    class Songs
    {
        private List<CD> songs;
        public List<CD> SongList
        {
            get { return songs; }
        }

        public Songs()
        {
            songs = new List<CD>();
        }

        public void NewSong(CD track)
        {
            songs.Add(track);
        }

        public CD FindSong( int index)
        {
            if (index < songs.Count)
            {
                return songs.ElementAt(index);
            }
            else
            {
                return null;
            }
        }
    }
}

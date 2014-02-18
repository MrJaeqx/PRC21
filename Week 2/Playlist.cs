using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week_2
{
    public class Playlist
    {
        public string Name { get; private set; }

        public List<Song> Songs { get; private set; }

        public Playlist(string name)
        {
            this.Name = name;
            this.Songs = new List<Song>();
        }

        public void Add(Song song)
        {
            Songs.Add(song);
        }

        public void Add(List<Song> songs)
        {
            foreach (Song song in songs)
            {
                Songs.Add(song);
            }
        }

        public void Remove(Song song)
        {
            Songs.Remove(song);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}

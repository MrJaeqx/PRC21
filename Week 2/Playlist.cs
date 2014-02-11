using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week_2
{
    class Playlist
    {
        public string Name { get; private set; }

        private List<Song> playlistSongs = new List<Song>();

        public Playlist(string name)
        {
            this.Name = name;
        }

        public void Add(Song song)
        {
            playlistSongs.Add(song);
        }

        public void Add(List<Song> songs)
        {
            foreach (Song song in songs)
            {
                playlistSongs.Add(song);
            }
        }

        public void Remove(Song song)
        {
            playlistSongs.Remove(song);
        }

        public override string ToString()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week_2
{
    class Song
    {

        public string  Name        { get; private set; }
        public int     Year        { get; private set; }
        public string  PathToFile  { get; private set; }
        public string  Lyrics      { get; private set; }
        private Artist artist;

        public Song(string name, int year, Artist artist, string pathToFile)
        {
            this.Name = name;
            this.Year = year;
            this.artist = artist;
            this.PathToFile = pathToFile;
        }

        public override string ToString()
        {
            return this.artist.Name + " - " + this.Name;
        }
    }
}

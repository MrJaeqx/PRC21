using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TagLib;

namespace Week_2
{
    public class Song
    {

        public string  Name        { get; private set; }
        public int     Year        { get; private set; }
        public string  PathToFile  { get; private set; }
        public string  Lyrics      { get; private set; }
        private Artist artist;

        public Song(string pathToFile)
        {
            this.PathToFile = pathToFile;
            TagLib.File file = TagLib.File.Create(PathToFile);
            this.Name = file.Tag.Title;
            this.Year = (int) file.Tag.Year;
            this.artist = new Artist(file.Tag.FirstPerformer, new DateTime(1995, 2, 15));
            
        }

        public Song(string name, int year, Artist artist, string pathToFile)
        {
            this.Name = name;
            this.Year = year;
            this.artist = artist;
            this.PathToFile = pathToFile;
        }

        public string GetArtist()
        {
            return artist.Name;
        }

        public override string ToString()
        {
            return (this.artist.Name + " - " + this.Name);
        }
        public string[] ToStringArray()
        {
            return new[] { this.Name, this.artist.Name, this.Year.ToString(), this.PathToFile };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week_2
{
    class Artist
    {

        public string      Name       { get; private set; }
        public DateTime    Birthday   { get; private set; }

        public Artist(string name, DateTime birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public void Add(Song song)
        {

        }

        public override string ToString()
        {
            return this.Name;
        }

    }
}

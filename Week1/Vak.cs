﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week1
{
    class Vak
    {

        private string vakCode;
        private string vakNaam;
        private int SBU;

        Vak(string code, string naam, int sbu)
        {
            this.vakCode = code;
            this.vakNaam = naam;
            this.SBU = sbu;
        }

        public string getVakCode()
        {
            return this.vakCode;
        }

        public string getVakNaam()
        {
            return this.vakNaam;
        }

        public int getSBU()
        {
            return this.SBU;
        }
    }
}

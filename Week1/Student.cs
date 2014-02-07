/*      COPYRIGHT MR. FISH 2014
 * 
 *      |\   \\\\__     o
 *      | \_/    o \    o 
 *      > _   (( <_  oo  
 *      | / \__+___/      
 *      |/     |/
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week1
{
    class Student
    {

        private int studentNr;
        private static int prevnr = -1;
        private string naam;
        private string adres;
        private DateTime geboorteDatum;
        private List<Resultaat> resultaten;

        public Student(string naam, string adres, DateTime geboorteDatum)
        {
            this.studentNr = prevnr + 1;
            prevnr++;
            this.naam = naam;
            this.adres = adres;
            this.geboorteDatum = geboorteDatum;
            this.resultaten = new List<Resultaat>();
        }

        public int getResultaat(string vakCode)
        {
            Resultaat r = resultaten.Find(x => x.getVak().Equals(vakCode));
            return r.getCijfer();
        }

        public void addResultaat(Vak vak, int cijfer)
        {
            if (getResultaat(vak.getVakCode()) > cijfer)
            {
                Resultaat r = resultaten.Find(x => x.getVak().Equals(vak.getVakCode()));
                resultaten.Remove(r);
            }
            
            resultaten.Add(new Resultaat(0,vak, cijfer));
        }

        public int getMaxResulaat()
        {
            int hoogsteCijfer = 0;

            foreach (Resultaat r in resultaten)
            {
                if (r.getCijfer() > hoogsteCijfer)
                {
                    hoogsteCijfer = r.getCijfer();
                }
            }
            
            return hoogsteCijfer;
        }

        public int getStudieLast()
        {
            int SBU = 0;

            foreach (Resultaat r in resultaten)
            {
                if (r.getCijfer() > 6)
                {
                    SBU += r.getVak().getSBU();
                }
            }

            return SBU;
        }

        public string getNaam()
        {
            return this.naam;
        }

        public string getAdres()
        {
            return this.adres;
        }

        public string getDateAsString()
        {
            return this.geboorteDatum.ToShortDateString();
        }

        public string getNrAsString()
        {
            return Convert.ToString(this.studentNr);
        }

        public void setNaam(string n)
        {
            this.naam = n;
        }

        public void setAdres(string a)
        {
            this.adres = a;
        }
    }
}

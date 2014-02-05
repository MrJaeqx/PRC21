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
        private string naam;
        private string adres;
        private DateTime geboorteDatum;
        private List<Resultaat> resultaten;

        public Student(int studentnr, string naam, string adres, DateTime geboorteDatum)
        {
            this.studentNr = studentnr;
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
            
            resultaten.Add(new Resultaat(vak, cijfer));
        }

        public int getMaxResulaat()
        {
            // Stuff
            return 1337;
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
    }
}

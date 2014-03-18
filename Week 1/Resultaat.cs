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
    class Resultaat
    {

        private int studentnr;
        private Vak vak;
        private int cijfer;

        public Resultaat(int studentnr, Vak vak, int cijfer) {
            this.studentnr = studentnr;
            this.vak = vak;
            this.cijfer = cijfer;
        }

        public Vak getVak()
        {
            return this.vak;
        }

        public int getCijfer()
        {
            return this.cijfer;
        }

        public int getStudNr()
        {
            return this.studentnr;
        }
    }
}

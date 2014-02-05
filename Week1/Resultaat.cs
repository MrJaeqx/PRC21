using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week1
{
    class Resultaat
    {

        private Vak vak;
        private int cijfer;

        Resultaat(Vak vak, int cijfer) {
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
    }
}

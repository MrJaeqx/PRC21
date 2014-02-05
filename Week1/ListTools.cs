using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week1
{
    class ListTools
    {

        public int GetMax(List<int> list)
        {
            int max = 0;
            foreach (int nummer in list)
            {
                if (nummer > max) max = nummer;
            }
            return max;
        }

        public int GetMin(List<int> list)
        {
            int min = 10;
            foreach (int nummer in list)
            {
                if (nummer < min) min = nummer;
            }
            return min;
        }
    }
}

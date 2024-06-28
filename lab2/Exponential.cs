using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Exponential:ISeries
    {
        private int firstElement;
        private int ratio;

        public Exponential(int firstElement, int ratio)
        {
            this.firstElement = firstElement;
            this.ratio = ratio;
        }

        public int GetElement(int n)
        {
            return (int)(firstElement * Math.Pow(ratio, n - 1));
        }
    }
}

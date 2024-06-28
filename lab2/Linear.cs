using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Linear:ISeries
    {
        private int first;
        private int differenc;


        public Linear(int first, int differenc)
        {
            this.first = first;
            this.differenc = differenc;
        }
        public int GetElement(int n)
        {
            return (first + (n - 1) * differenc);
        }
    }
}

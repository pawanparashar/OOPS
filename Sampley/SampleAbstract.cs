using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampley
{
    abstract class SampleAbstract
    {
        int temp { get; set; }
        public int sum(int a,int b)
        {
            return a + b;

        }

        public abstract int mul(int a, int b);

    }
}

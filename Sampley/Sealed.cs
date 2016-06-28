using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampley
{
    sealed class Sealed:SampleAbstract
    {
        public int sumer(int a, int b)
        {
            return a + b;
        }

        public int sumer(int a, int b, int c)
        {
            return a + b + c;
        }

        public override int mul(int a,int b)
        {
            return a * b;
        }
    }
}

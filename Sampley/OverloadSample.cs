using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampley
{
    class OverloadSample
    {
        public int sum(int a,int b)
        {
            return a + b;
        }

        public int sum(int a,int b,int c)
        {
            return a + b + c;
        }
        
    }
}

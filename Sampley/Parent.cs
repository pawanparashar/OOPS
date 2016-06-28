using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampley
{

    interface IParent1
    {
        int sum(int a, int b);
        int mul(int a, int b);
    }

    interface IParent2
    {
        int div(int a, int b);
        int sub(int a, int b);
    }
    class Parent:IParent1,IParent2
    {
       public int sum(int a, int b)
        {
            return a + b;

        }

        public int mul(int a, int b)
        {
            return a * b;
        }

        public int div(int a, int b)
        {
            return a/b;

        }

        public int sub(int a, int b)
        {
            return a - b;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class A
    {
        private int a;
        private int b;
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public A()
        {
            a = 3;
            b = 8;
        }
        public int c
        {
            get
            {
                for (int i = 0; i < 5; i++)
                {
                    a += b;
                }
                return a;
            }
            set { }
        }
    }
}

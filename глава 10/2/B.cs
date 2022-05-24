using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class B : A
    {
        private int d;
        public int c2
        {
            get
            {
                for (int i = 0; i < 5; i++)
                {
                    d += c;
                }
                return d;
            }
            set
            {
                d = value;
            }
        }
        public B() : base()
        {

        }
        public B(int d)
        {
            d = 12;
        }
    }
}

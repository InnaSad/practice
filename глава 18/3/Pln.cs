using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _3
{
    class Pln : IEnumerable
    {
        private ArrayList list;
        public Pln()
        {
            list = new ArrayList();
        }
        public Pln(ArrayList a)
        {
            list = a;
        }
        public void Add(Status m)
        {
            list.Add(m);
        }
        public Pln Clone()
        {
            return new Pln(list);
        }
        public void RemoveAt(int i)
        {
            list.RemoveAt(i);
        }
        public void Clear()
        {
            list.Clear();
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}

using System;

namespace _1
{
    interface Ix
    {
        void IxF0(int xKey);
        void IxF1();
    }
    interface Iy
    {
        void F0(int xKey);
        void F1();
    }
    interface Iz
    {
        void F0(int xKey);
        void F1();
    }
    interface Iw
    {
        void F0(int xKey);
        void F1();
    }
    class TestClass : Ix, Iy, Iz, Iw
    {
        public int w;
        public TestClass()
        {
            w = 20;
        }
        public TestClass(int key)
        {
            w = key;
        }
        public void IxF0(int key)
        {
            key *= 10; 
            Console.WriteLine("w * 10 = {0}", key);
        }
        public void IxF1()
        {
            w *= 10;
            Console.WriteLine("w * 10 = {0}", w);
        }
        public void F0(int xKey)
        {
            w = (int)xKey - 10;
            Console.WriteLine("w - 10 = {0}", w);
        }
        public void F1()
        {
            w = w - 10;
            Console.WriteLine("w - 10 = {0}", w);
        }
        public void IwF0(int xKey)
        {
            w = xKey / 10;
            Console.WriteLine("w / 10 = {0}", w);
        }
        public void IwF1()
        {
            w = w / 10;
            Console.WriteLine("w / 10 = {0}", w);
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            TestClass x0 = new TestClass();
            TestClass x1 = new TestClass();
            int w = 20;
            Console.WriteLine("w = " + w);
            x0.IxF0(w);
            x1.IxF1();
            (x0 as Iy).F0(w);
            (x1 as Iz).F1();
            x0.IwF0(w);
            x1.IwF1();
            Console.WriteLine("==========Prism test==========");
            Console.WriteLine("==========Ix==========");
            Ix ix = x1;
            ix.IxF0(w);
            ix.IxF1();
            Console.WriteLine("==========Iy==========");
            Iy iy = x1;
            iy.F0(w);
            iy.F1();
            Console.WriteLine("==========Iz==========");
            Iz iz = x1;
            iz.F0(w);
            iz.F1();
            Console.WriteLine("==========Iw==========");
            Iw iw = x1;
            iw.F0(w);
            iw.F1();
            Console.ReadLine();
        }
    }
}

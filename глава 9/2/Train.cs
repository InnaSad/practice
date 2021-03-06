using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Train : IComparable
    {
        String endPunct;
        public String EndPunct
        {
            get { return endPunct; }
            set { endPunct = value; }
        }
        int namber;
        public int Namber
        {
            get { return namber; }
            set
            {
                if (value > 0)
                    namber = value;
            }
        }
        DateTime time;
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        void SetTime()
        {
            while (true)
            {
                int hour = 0;
                int minute = 0;
                Console.Write("Введите время отправления поезда [час.минуты]: ");
                string t = Console.ReadLine();
                string h = "";
                string m = "";
                int q;
                bool flag = false;
                for (int i = 0; i < t.Length; i++)
                {
                    if (!flag)
                    {
                        if (Int32.TryParse(Convert.ToString(t[i]), out q))
                        {
                            h = h + t[i];
                        }
                        else
                        {
                            flag = true;
                            continue;
                        }
                    }
                    if (flag)
                    {
                        if (Int32.TryParse(Convert.ToString(t[i]), out q))
                        {
                            m = m + t[i];
                        }
                    }
                }
                try
                {
                    hour = Int32.Parse(h);
                    minute = Int32.Parse(m);
                    Time = new DateTime(2012, 12, 12, hour, minute, 0);
                    return;
                }
                catch
                {
                    Console.WriteLine("Введен неверный формат времени");
                }

            }
        }
        public Train(string EndPunct, int Namber)
        {
            this.EndPunct = EndPunct;
            this.Namber = Namber;
            SetTime();
        }
        public Train(string EndPunct, int Namber, DateTime Time)
        {
            this.EndPunct = EndPunct;
            this.Namber = Namber;
            this.Time = Time;
        }
        public int CompareTo(object input)
        {
            if (input is Train)
            {
                Train p1 = (Train)input;
                if (this.Time > p1.Time)
                    return 1;
                else if (this.Time < p1.Time)
                    return -1;
                else
                    return 0;
            }
            return 0;
        }
        public override string ToString()
        {
            string info = String.Format("Поезд №{0} следует в пункт назначения {1}. Время отправления: {2}.{3}!",
                Namber, EndPunct, time.Hour, time.Minute);
            return info;
        }
        public void ShowInfo()
        {
            Console.WriteLine(ToString());
        }
        public static bool operator >(Train p1, Train p2)
        {
            if (p1.Time > p2.Time)
                return true;
            return false;
        }
        public static bool operator <(Train p1, Train p2)
        {
            if (p1.Time < p2.Time)
                return true;
            return false;
        }
        public static bool operator ==(Train p1, Train p2)
        {
            if (p1.Time == p2.Time)
                return true;
            return false;
        }
        public static bool operator !=(Train p1, Train p2)
        {
            if (p1.Time != p2.Time)
                return true;
            return false;
        }
    }
}
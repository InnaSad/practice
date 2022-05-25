using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int mascount = 5;
            Medic[] medicmas = new Medic[mascount];
            Console.WriteLine("Выберите создаваемого медработника:");
            Console.WriteLine("1. Медсестра \n2. Врач");
            int change = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int incomen = 0;
            int incomed = 0;
            int Sumincome = 0;
            while (i < mascount)
            {
                switch(change)
                {
                    case 1:
                        Nurse nurse = new Nurse();
                        nurse.IncomeNurse();
                        incomen = incomen + nurse.income;
                        medicmas[i] = nurse as Medic; ++i; break;
                    case 2:
                        Doctor doctor = new Doctor();
                        doctor.IncomeDoctor();
                        incomed = incomed + doctor.income;
                        medicmas[i] = doctor as Medic; ++i; break;
                    default: Console.WriteLine("Нет такого пункта!"); break;
                }
            }
            for (int m = 0; m < medicmas.Length; m++)
            {
                if(medicmas[m] != null)
                {
                    medicmas[m].GetInfo();
                }
            }
            Sumincome = incomen + incomed;
            Console.Write("Суммарный доход: " + Sumincome);
            Console.ReadLine();
        }
    }
}

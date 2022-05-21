using System;
using System.Linq;

namespace _1
{
    class Program
    {
        const int STUDENTS_QUANTITY = 5;
        const int SUBJECT_QUANTITY = 5;
        static void Main(string[] args)
        {
            Student[] Results = new Student[STUDENTS_QUANTITY];
            GetStudents(Results);
            CheckGoodMark(Results);
            Console.ReadLine();
        }
        public struct Student
        {
            public string Surname;
            public string Initials;
            public int GroupNumber;
            public int[] Marks;
        }
        static void GetStudents(Student[] Students)
        {
            int number;
            bool converted;
            Student student = new Student();
            student.Marks = new int[SUBJECT_QUANTITY];
            for (int i = 0; i < STUDENTS_QUANTITY; i++)
            {
                Console.Write("Введите фамилию студента: ");
                student.Surname = Console.ReadLine();
                Console.Write("Введите инициалы студента: ");
                student.Initials = Console.ReadLine();
                do
                {
                    Console.Write("Введите группу студента: ");
                    converted = int.TryParse(Console.ReadLine(), out number);
                }
                while (converted == false);
                student.GroupNumber = number;
                Console.WriteLine("Введите оценки студента: ", SUBJECT_QUANTITY);
                for (int h = 0; h < SUBJECT_QUANTITY; h++)
                {
                    do
                    {
                        Console.Write("{0}) ", h + 1);
                        converted = int.TryParse(Console.ReadLine(), out number);
                    }
                    while (converted == false);
                    student.Marks[h] = number;
                }
                Students[i] = student;
                Console.WriteLine();
            }
            Array.Sort(Students, (x, y) => x.GroupNumber == y.GroupNumber ? 0 : x.GroupNumber > y.GroupNumber ? 1 : -1);
        }
        static void CheckGoodMark(Student[] Students)
        {
            bool found = false;
            foreach (Student student in Students)
            {
                if (student.Marks.Average() >= 4.0)
                {
                    found = true;
                    Console.WriteLine("Студент {0} {1} из группы {2} имеет средний бал больше 4,0",
                        student.Surname, student.Initials, student.GroupNumber);
                }
            }
            if (!found)
            {
                Console.WriteLine("Записей не найдено");
            }
        }
    }
}

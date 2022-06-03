using System;

namespace _3_4
{
    /// <summary>
    /// Класс "Книга"
    /// </summary>
    class Book
    {
        public string author;
        public string year_issue;
        public string category;
        public Book(string author, string year_issue, string category)
        {
            this.author = author;
            this.year_issue = year_issue;
            this.category = category;
        }
    }
    /// <summary>
    /// Класс "Домашняя библиотека"
    /// </summary>
    class HomeLibrary
    {
        Book[] books;
        public HomeLibrary()
        {
            int length = 0;
            books = new Book[length];
        }
        /// <summary>
        /// Вывод в консоль информации о книге
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine("Автор - " + books[i].author);
                Console.WriteLine("Год издания - " + books[i].year_issue);
                Console.WriteLine("Категория - " + books[i].category);
            }
        }
        /// <summary>
        /// Поиск книги по автору, по году издания, по категории
        /// </summary>
        public void find()
        {
            Console.WriteLine("Выберите способ поиска");
            Console.WriteLine("1.Поиск по автору");
            Console.WriteLine("2.Поиск по году издания");
            Console.WriteLine("3.Поиск по категории");
            int a1 = Convert.ToInt32(Console.ReadLine());
            switch (a1)
            {
                case 1:
                    Console.WriteLine("Введите автора");
                    string fi = Console.ReadLine();
                    for (int i = 0; i < books.Length; i++)
                    {
                        if (books[i].author == fi)
                        {

                            Console.WriteLine("Автор - " + books[i].author + " Год издания - " + books[i].year_issue +
                                " Категория - " + books[i].category);
                        }
                        else
                        {
                            Console.WriteLine("Книга не найдена");
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите год издания");
                    string num = Console.ReadLine();
                    for (int i = 0; i < books.Length; i++)
                    {
                        if (books[i].year_issue == num)
                        {
                            Console.WriteLine("Год издания - " + books[i].year_issue + " Автор - " + books[i].author +
                                " Категория - " + books[i].category);
                        }
                        else
                        {
                            Console.WriteLine("Книга не найдена");
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите категорию");
                    string col = Console.ReadLine();
                    for (int i = 0; i < books.Length; i++)
                    {
                        if (books[i].category == col)
                        {
                            Console.WriteLine("Категория - " + books[i].category + "Автор - " + books[i].author +
                                "Год издания - " + books[i].year_issue);
                        }
                        else
                        {
                            Console.WriteLine("Книга не найдена");
                        }
                    }
                    break;
            }
        }
        /// <summary>
        /// Добавление книги в библиотеку 
        /// </summary>
        public void add()
        {
            Console.WriteLine("Введите автора");
            string n = Console.ReadLine();
            Console.WriteLine("Введите год издания");
            string a = Console.ReadLine();
            Console.WriteLine("Введите категорию");
            string y = Console.ReadLine();
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = new Book(n, a, y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HomeLibrary book = new HomeLibrary();
        M1:
            Console.WriteLine("Ввыбрать пункт:");
            Console.WriteLine();
            Console.WriteLine("1.Поиск книги");
            Console.WriteLine("2.Добавление книги");
            Console.WriteLine("3.Список книг в библиотеке");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a != 0 && a <= 3)
            {
                switch (a)
                {
                    case 1:
                        book.find();
                        goto M1;
                    case 2:
                        book.add();
                        goto M1;
                    case 3:
                        book.Print();
                        goto M1;
                }
            }
            else goto M1;
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
namespace Lab11
{
    class Program
    {

        static void Main()
        {
            #region 1 задание

            var months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            Console.WriteLine("Запрос 1: последовательность месяцев с длиной строки равной n");
            {
                Console.WriteLine("Введите длину строки:");
                var length = Convert.ToInt32(Console.ReadLine());

                var linq1 = from item in months
                            where item.Length == length
                            select item;
                foreach (var item in linq1)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-',50));
            }

            Console.WriteLine("Запрос 2: только летние и зимние месяцы");
            {
                var linq2 = months.Where(m => m == months[0] || m == months[1] || m == months[11] || m == months[6] || m == months[7] || m == months[11]);
                foreach (string month in linq2)
                {
                    Console.Write($"{month}  ");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-',50));
            }

            Console.WriteLine("Запрос 3: вывод месяцев в алфавитном порядке");
            {
                var linq3 = months.OrderBy(m => m);
                foreach (var item in linq3)
                {
                    Console.Write($"{item}  ");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-',50));
            }

            Console.WriteLine("Запрос 4: месяцы, содержащие букву «u» и длиной имени не менее 4-х");
            {
                var linq4 = from item in months
                            where item.Contains('u') && item.Length >= 4
                            select item;
                foreach (var item in linq4)
                {
                    Console.Write($"{item}  ");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-',50));
            }
            #endregion

            #region задание 2-3-4

            var books = new List<Book>
            {
                new Book("Do it","Andrey Jonson", 2010,157,30),
                new Book("It","Stephen King", 1997,320,60),
                new Book("Mr.Mercendes","Stephen King", 1995,218,45),
                new Book("Dad","Andrey Jonson", 2003,203,25),
                new Book("Dad 2","Andrey Jonson", 2008,203,55),
                new Book("Dad 3","Andrey Jonson", 2010,210,25),
                new Book("Dad 4","Andrey Jonson", 2015,215,57),
                new Book("Do it 2","Andrey Jonson", 2015,357,32),
                new Book("It 2 ","Stephen King", 2007,300,80),
                new Book("Mr.Mercendes 2 ","Stephen King", 2005,228,45),
            };

            Console.WriteLine("Вывод книг Стивена кинга вышедших в 1997\n");
            {
                var booksLinq = books.Where(item => item.AuthorName == "Stephen King" && item.Data == 1997);
                foreach (var item in booksLinq)
                {
                    Console.Write($"{item}\n");
                }
            }

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Вывод книг вышедших не позже чем 2000\n");
            {
                var booksLinq1 = books.Where(item => item.Data > 2000);
                foreach (var item in booksLinq1)
                {
                    Console.Write($"{item}\n");
                }
            }

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Вывод книги с наименьшим количеством страниц\n");
            {
                var booksLinq2 = books.Min(item => item.SheetNumb);
                Console.WriteLine(booksLinq2);
            }

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Вывод 5 книг с наибольшим количеством страниц и по низкой цене\n");
            {
                var booksLinq3 = books.OrderByDescending(item => item.SheetNumb).ThenBy(item=>item.Price).Take(5);
                foreach (var item in booksLinq3)
                {
                    Console.WriteLine($"{item}");
                }
            }

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Вывод книг отсортированых по цене\n");
            {
                var booksLinq4 = books.OrderBy((item => item.Price));
                foreach (var item in booksLinq4)
                {
                    Console.WriteLine($"{item}");
                }
            }

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Собственный запрос с 5 операторами");
            {
                var booksLinq5 = books.Where(item=>item.SheetNumb<300).Where(item=>item.AuthorName== "Andrey Jonson").OrderByDescending(item => item.Price).ThenBy(item => item.SheetNumb).Take(3);
                foreach (var item in booksLinq5)
                {
                    Console.WriteLine($"{item}");
                }
            }

            #endregion

            #region задаие 5

            Console.WriteLine(new string('-', 50));

            var magazin = new List<Magazin>
            {
                new Magazin("Vogue","Andrey Jonson", 2020,57,30),
                new Magazin("GQ","Ivan Trap", 2018,40,25),
                new Magazin("Maxim","Stephen King", 2021,30,10),
            };

            //var result = from pl in players
            //join t in teams on pl.Team equals t.Name
            //select new { Name = pl.Name, Team = pl.Team, Country = t.Country };
            var result = books.Join(magazin,
                item=>item.AuthorName,
                item2=>item2.AuthorName,
                (item,item2) => new {Name = item.AuthorName, Book= item.BookName,Magazin=item2.MagazinName}
                );

            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.Book} ({item.Magazin})");





            #endregion
        }
    }
}

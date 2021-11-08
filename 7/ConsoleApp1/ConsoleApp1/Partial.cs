using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Library
    {
        public void lib()
        {
            Magazin ma = new Magazin();
            Book bo = new Book();
            Manual man = new Manual();
            string[][] myArr = new string[3][];
            myArr[0] = ma.magazins;
            myArr[1] = bo.books;
            myArr[2] = man.manuals;
            int[][] myArrYO = new int[3][];
            myArrYO[0] = ma.magazinsYO;
            myArrYO[1] = bo.booksYO;
            myArrYO[2] = man.manualsYO;
            Console.WriteLine("Введите: \n1-кол-во учебников\n2-цена журналов \n3-книга не старше чем\n4-изменить список учебников\n5-изменить список журналов\n6-изменить список книг\n");
            string sw = Console.ReadLine();
            switch (sw)
            {
                case "1": ShowMan(); break;
                case "2": PriceMag(); break;
                case "3": ShowBooks(); break;
                case "4": ChangeMan(); break;
                case "5": ChangeMag(); break;
                case "6": ChangeBooks(); break;
            }
            void ShowMan()
            {
                int manTotal = 0;
                Console.WriteLine(new string('-', 50));
                for (int i = 0; i < man.manuals.Length; i++)
                {
                    Console.WriteLine("У нас есть учебник по {0} в количестве {1}", myArr[2][i], myArrYO[2][i]);
                    manTotal += myArrYO[2][i];
                }
                Console.WriteLine("Всего у нас {0} учебников", manTotal);
            }
            void PriceMag()
            {
                int magPrice = 0;
                Console.WriteLine(new string('-', 50));
                for (int i = 0; i < ma.magazins.Length; i++)
                {
                    Console.WriteLine("У нас есть журнал {0},цена: {1}", myArr[0][i], myArrYO[0][i]);
                    magPrice += myArrYO[0][i];
                }
                Console.WriteLine("Общая цена всех журналов: {0}", magPrice);

            }
            void ShowBooks()
            {
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Введите год издания");
                int year = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < bo.books.Length; i++)
                {
                    if (year <= myArrYO[1][i])
                        Console.WriteLine("У нас есть книга {0},изданная в: {1}", myArr[1][i], myArrYO[1][i]);
                }


            }
            void ChangeMan()
            {
                string ch;
                string newMan;
                Console.WriteLine(new string('-', 50));
                for (int i = 0; i < man.manuals.Length; i++)
                {
                    Console.WriteLine("Заменить учебник по {0} на другой? y/n", myArr[2][i]);
                    ch = Console.ReadLine();
                    if (ch == "y")
                    {
                        Console.WriteLine("Введите название нового учебник");
                        newMan = Console.ReadLine();
                        myArr[2][i] = newMan;
                    }
                }
                Console.WriteLine("Новый список учебников");
                for (int i = 0; i < man.manuals.Length; i++)
                {
                    Console.Write("{0} ", myArr[2][i]);
                }
                Console.WriteLine();
            }
            void ChangeMag()
            {
                string ch;
                string newMag;
                Console.WriteLine(new string('-', 50));
                for (int i = 0; i < ma.magazins.Length; i++)
                {
                    ch = "";
                    newMag = "";
                    Console.WriteLine("Заменить журнал  {0} на другой? y/n", myArr[0][i]);
                    ch = Console.ReadLine();
                    if (ch == "y")
                    {
                        Console.WriteLine("Введите название нового журнала");
                        newMag = Console.ReadLine();
                        myArr[0][i] = newMag;
                    }
                }
                Console.WriteLine("Новый список журналов");
                for (int i = 0; i < ma.magazins.Length; i++)
                {
                    Console.Write("{0} ", myArr[0][i]);
                }
                Console.WriteLine();
            }
            void ChangeBooks()
            {
                string ch;
                string newMag;
                Console.WriteLine(new string('-', 50));
                for (int i = 0; i < bo.books.Length; i++)
                {
                    Console.WriteLine("Заменить книгу  {0} на другую? y/n", myArr[1][i]);
                    ch = Console.ReadLine();
                    if (ch == "y")
                    {
                        Console.WriteLine("Введите название новой книги");
                        newMag = Console.ReadLine();
                        myArr[1][i] = newMag;
                    }
                }
                Console.WriteLine("Новый список книг");
                for (int i = 0; i < bo.books.Length; i++)
                {
                    Console.Write("{0} ", myArr[1][i]);
                }
                Console.WriteLine();
            }

        }

        public partial class Person
        {
            public string WhantTakeSmth()
            {
                Console.WriteLine("Wana take smth? Yes/No");
                string wts = Console.ReadLine();
                return wts;

            }
        }
    }
    public class MyException : Exception
    {
        public class Exception1 : MyException
        {
            public override string Message
            {
                get
                {
                    return " Введите значение до 4";
                }
            }
        }
        public class Exception2 : MyException
        {
            public override string Message
            {
                get
                {
                    return " Введите значение больше нуля";
                }
            }
        }
        public class Exception3 : MyException
        {
            public override string Message
            {
                get
                {
                    return " Введите значение от 0 до 4";
                }
            }
        }
    }
    // 156 partial 87,104,131 program

}


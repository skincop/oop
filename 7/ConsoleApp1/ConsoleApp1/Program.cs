using System;

namespace ConsoleApp1
{
    public partial class Library
    {
        private int _update=1;
        public int update
        {
            get { return _update; }

        }
        public partial class Person
        {
            public static void Assert(bool a)
            {
                if (a) throw new Exception("Yes/No!!");
            }
            static void Main()
            {

                Person pa = new Person();
                for (int i = 0; i < 999; i++)
                {
                    string yn = pa.WhantTakeSmth();
                    if (yn == "1") Assert(true);
                    if (yn != "No")
                    {
                        string chs = pa.Choose();
                        if (chs == "STOP") i = 10000;
                        pa.chSwitch(chs);
                    }
                    else break;
                }
                Magazin ui = new Magazin();
                IPublishingHouse obj = ui as Magazin;
                if (obj != null)
                    Console.WriteLine("Тип UI поддерживает интерфейс IPublishingHouse");
                else
                    Console.WriteLine(":(");
                if (ui is Magazin)
                    Console.WriteLine("Тип UI реализовал интерфейс IPublishingHouse");
                else
                    Console.WriteLine(":(");



            }

            public string Choose()
            {
                Console.WriteLine("Type B for Book\nM for Magazin\nMAN for manuals\nSmth else to lab 6");
                string ch = Console.ReadLine();
                return ch;

            }
            public string chSwitch(string ch)
            {
                try
                {
                    Magazin ma = new Magazin();
                    Book bo = new Book();
                    Manual man = new Manual();
                    string finall;
                    string inter;
                    int quanity;
                    switch (ch)
                    {
                        case "B":
                            Console.WriteLine("Book was chosen");
                            finall = bo.chBooks();
                            inter = bo.WroteAuthor();
                            Book.Quanity quan1 = new Book.Quanity();
                            quan1.quanity = 2;

                            Console.WriteLine("{0} was chosen", finall);
                            Console.WriteLine("The author {0}", inter);
                            Console.WriteLine("The author {0}", inter);
                            break;
                        case "M":
                            Console.WriteLine("Magazin was chosen");
                            finall = ma.chMagazins();
                            inter = ma.WrotePH();
                            Console.WriteLine("{0} was chosen", finall);
                            Console.WriteLine("The publishing house {0}", inter);
                            break;
                        case "MAN":
                            Console.WriteLine("Manual was chosen");
                            finall = man.chManuals();
                            inter = man.WroteTC();
                            Console.WriteLine("{0} was chosen", finall);
                            Console.WriteLine("The translate company {0}", inter);
                            break;
                        case "GG":
                            Console.WriteLine("На какое число вы хотите поделить 100");
                            int ggch = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                int gg = 100 / ggch;
                            }
                            catch (DivideByZeroException ex)
                            {
                                Console.WriteLine("Нельзя делить на нуль!!!!!!!");
                                Console.WriteLine($"собрка {ex.Source},\n{ex.StackTrace}\n{ex.TargetSite}");
                            }
                            finally
                            {
                                Console.WriteLine("Срабатывание блока finally");
                            }

                            break;
                        case "GGG":
                            Console.WriteLine("Переполнение");
                            byte max = 255, min = 1, result;
                            try
                            {
                                result = (byte)(max + min);
                            }
                            catch (OverflowException)
                            {
                                Console.Write("Переполнение\n\n");
                            }
                            finally
                            {
                                Console.WriteLine("Срабатывание блока finally");
                            }

                            break;

                        default:
                            Days user1;
                            for (user1 = Days.Monday; user1 <= Days.Sunday; user1++)
                                Console.WriteLine("Элемент: \"{0}\", значение {1}", user1, (int)user1);
                            Library libbb = new Library();
                            libbb.lib();

                            //Console.ReadLine();
                            break;
                    }

                    return ch;
                }
                catch
                {
                    Console.WriteLine("Ошибка");
                    return ch;

                }
            }
            enum Days
            {
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday,
                Sunday
            }

        }

        public class Magazin : IPublishingHouse
        {
            public string[] magazins = { "Vogue", "GQ", "Maxim", "XXL" };
            public int[] magazinsYO = { 25,45,30,30 };
            public string chMagazins()
            {
                Console.WriteLine("We have {0} Magazins", magazins.Length);
                for (int i = 0; i < magazins.Length; i++)
                {
                    Console.WriteLine("Type {0} for {1}", i, magazins[i]);
                }

                try
                {
                    int chMa = Convert.ToInt32(Console.ReadLine());

                    return magazins[chMa];
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"{ex.Source}\n{ex.StackTrace}\n{ex.TargetSite}\n{ex.HResult}");
                    Console.WriteLine("Сработал IndexOutOfRangeException");
                    return magazins[0];
                }
                finally
                {
                    Console.WriteLine("Блок Finally");
                }
            }
            public virtual string WrotePH()
            {
                string ph = "The New York Publishing House";
                return ph;
            }

        }
        public class Book : Author, IAuthor
        {
            public string[] books = { "Sapiens", "Carry", "Do it" };
            public int[] booksYO = { 1901,1920,1955 };
            public string chBooks()
            {
                Console.WriteLine("We have {0} Books", books.Length);
                for (int i = 0; i < books.Length; i++)
                {
                    Console.WriteLine("Type {0} for {1}", i, books[i]);
                }
                int chBo = Convert.ToInt32(Console.ReadLine());
                if (chBo < 1) throw new MyException.Exception2();
                else return books[chBo];
            }
            /// <summary>
            /// ///////////////////////
            /// </summary>
            public struct Quanity
            {
                public int quanity;
            }
            /// <summary>
            /// /////////////
            /// </summary>

            public override string WroteAuthor()
            {
                string author = "The Stephen king";
                return author;
            }
            //public override string WroteAuthor()
            //{
            //    string author1 = "The Stephen king";
            //    return author1;
            //}


        }
        public class Manual : String, ITranslateComp
        {


            public string[] manuals = { "Math", "English", "Chemestry"};
            public int[] manualsYO = { 10,4,7 };
            public string chManuals()
            {
                Console.WriteLine("We have {0} Manuals", manuals.Length);
                for (int i = 0; i < manuals.Length; i++)
                {
                    Console.WriteLine("Type {0} for {1}", i, manuals[i]);
                }
                int chMan = Convert.ToInt32(Console.ReadLine());
                if (0 < chMan && chMan<4) return manuals[chMan];
                else throw new MyException.Exception3();
            }
            public virtual string WroteTC()
            {
                string tc = "Minsk Translate Company";
                return tc;
                void ToString()
                {
                    Console.WriteLine(tc.ToString());
                }
            }

        }
        public class String
        {
            int id = 1;
            public void ToString()
            {
                Console.WriteLine(id.ToString());

            }

        }


        public interface IPublishingHouse
        {
            string WrotePH();

        }
        public interface ITranslateComp
        {
            string WroteTC();

        }
        public abstract class Author
        {
            public abstract string WroteAuthor();
        }
        public interface IAuthor
        {
            public virtual string WroteAuthor()
            {
                string author = "non override";
                return author;
            }
        }
      
        public sealed class Usles
        {

        }
        public class Printed
        {
            public virtual void IAmPrinting()
            {

                Type[] types =
                {         typeof(Person),
                          typeof(Book),
                          typeof(Magazin),
                          typeof(Manual),
                          typeof(IPublishingHouse),
                          typeof(ITranslateComp),
                          typeof(Author)
                };
                foreach (var type in types)
                {
                    Console.WriteLine("{0} is abstract: {1}",
                               type.Name, type.IsAbstract);
                }

            }
        }
        //public class A : Usles
        //{ }


    }
}



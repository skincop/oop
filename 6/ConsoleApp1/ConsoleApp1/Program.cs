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
            static void Main()
            {

                Person pa = new Person();
                for (int i = 0; i < 999; i++)
                {
                    string yn = pa.WhantTakeSmth();
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
                Console.WriteLine("We have {0} Mahazins", magazins.Length);
                for (int i = 0; i < magazins.Length; i++)
                {
                    Console.WriteLine("Type {0} for {1}", i, magazins[i]);
                }
                int chMa = Convert.ToInt32(Console.ReadLine());
                return magazins[chMa];
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
                return books[chBo];
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


            public string[] manuals = { "Math", "English", "Chemestry", "Oop" };
            public int[] manualsYO = { 10,4,7,2 };
            public string chManuals()
            {
                Console.WriteLine("We have {0} Manuals", manuals.Length);
                for (int i = 0; i < manuals.Length; i++)
                {
                    Console.WriteLine("Type {0} for {1}", i, manuals[i]);
                }
                int chMan = Convert.ToInt32(Console.ReadLine());
                return manuals[chMan];
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



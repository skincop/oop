using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Lab10
{
    class Program 
    {
        private static void Obs_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Элемент добавлен ");
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Элемент удален ");
            }
            else
            {
                Console.WriteLine("Нет добавленных/удаленных элементов");
            }
        }

        static void Main(string[] args)
        {
            #region HashSet<Computer>

            HashSet<Computer<int>> computers = new HashSet<Computer<int>>();

            Computer<int> comp1 = new Computer<int>(1, "core i9", "RTX 3060", 64);
            Computer<int> comp2 = new Computer<int>(2, "core i5", "GT 1050", 16);
            Computer<int> comp3 = new Computer<int>(3, "core i7", "GTX 1660", 32);


            computers.Add(comp1);
            computers.Add(comp2);
            computers.Add(comp3);
            computers.Add(comp1);


            foreach (var item in computers)
            {
                Console.WriteLine($"{item.ToString()}");
            }

            computers.Remove(comp2);

            Console.WriteLine(new string('-', 50));
            foreach (var item in computers)
            {
                Console.WriteLine($"{item.ToString()}");
            }

            HashSet<Computer<int>> computers1 = new HashSet<Computer<int>>();
            computers1.Add(comp2);

            computers.UnionWith(computers1);

            Console.WriteLine(new string('-', 50));
            foreach (var item in computers)
            {
                Console.WriteLine($"{item.ToString()}");
            }
            #endregion
            #region HashSet<int>

            HashSet<int> integer = new HashSet<int>();
            Console.WriteLine(new string('-',50));

            for(int i=0;i<10;i++)
            {
                int rand = new Random().Next(0, 5);
                integer.Add(rand);
                Console.Write($"{rand} ");
            }

            Console.WriteLine("");

            foreach(int item in integer)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");



            #endregion

            #region event
            ObservableCollection<Computer<int>> Col = new ObservableCollection<Computer<int>>(); //ObservableCollection как list 
            Col.CollectionChanged += Obs_CollectionChanged;
            Console.WriteLine(new string('-',50));
            Col.Add(comp1);
            Col.Add(comp2);
            Col.Remove(comp1);
            Col.Add(comp2);

            foreach (Computer<int> item in Col)
            {
                Console.WriteLine("");
            }
            #endregion


        }  
    }
}

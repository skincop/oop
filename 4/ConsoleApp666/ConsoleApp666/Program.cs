using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp666
{
    public static partial class Extensions
    {
        
        public static Boolean IsUpper(this String s, Int32 index)
        {
            return Char.IsUpper(s, index);
        }
    }
    public class Set<T>
    {

        private readonly List<T> _list;
        public Owner owner = new Owner(1, "Yan", "BSTU");
        public class Owner
        {
            public int id { get; set; }
            public string name { get; set; }
            public string company { get; set; }
            public static class Date
            {
                public static DateTime DateAndTime = Convert.ToDateTime("25/09/2021 12:57");
            }
            public Owner(int id, string name, string company)
            {
                this.id = id;
                this.name = name;
                this.company = company;
            }
        }


        /// <summary>
        #region конструктор
        Set()
        {
            _list = new List<T>();
        }
        public Set(params T[] args) : this()
        {
            _list.AddRange(args);
        }
        public Set(IEnumerable<T> mas) : this()
        {
            _list.AddRange(mas);
        }
        #endregion

        #region перегзрузка методов для операторов
        public void Add(T el)
        {
            _list.Add(el);
        }
        public void Add(params T[] parms)
        {
            foreach (T el in parms)
            {
                Add(el);
            }
        }
        public void Add(Set<T> arr)
        {
            for (int i = 0; i < arr._list.Count; i++)
            {
                Add(arr.GetEl(i));
            }
        }
        /// </summary>
        public void RemoveAt(int el)
        {
            _list.RemoveAt((int)el);
        }
        public void RemoveAt(params T[] parms)
        {

            RemoveAt(0);

        }
        public void RemoveAt(Set<T> arr)
        {
            for (int i = 0; i < arr._list.Count; i++)
            {
                RemoveAt(arr.GetEl(i));
            }
        }
        /// 
        public T GetEl(int index)
        {
            T based = default(T);

            if (index > _list.Count || index < 0)
            {
                throw new Exception("GetEl: Неверный index. (" + index.ToString() + ')');
            }
            else
            {
                int counter = 0;
                foreach (T element in _list)
                {
                    if (counter == index)
                        return element;
                    if (Convert.ToChar(element) != ',')
                        counter++;
                }
            }
            return based;
        }
        public Set<T> Union(Set<T> Source)//
        {
            return new Set<T>(_list.Union(Source._list));
        }

        public bool Equals(object obj)
        {
            if (!(obj is Set<T>)) return false;
            Set<T> arr = obj as Set<T>;
            if (this._list.Count != arr._list.Count) return false;
            for (int i = 0; i < this._list.Count; i++)
            {
                if (!(this.GetEl(i).Equals(arr.GetEl(i)))) return false;
            }
            return true;
        }
        #endregion

        public int Sum()
        {
            int rezult = 0;
            foreach (T element in _list)
            {
                rezult += Convert.ToInt32(element);
            }
            return rezult;
        }
        public int Max()
        {
            int rezult = Convert.ToInt32(_list.Max());
            return rezult;
        }
        public int Min()
        {
            int rezult = Convert.ToInt32(_list.Min());
            return rezult;
        }
        public int Size()
        {
            return _list.Count;
        }
        public override string ToString()
        {
            return string.Join(",", _list);
        }


        #region перегрузка операторов
        public static Set<T> operator +(Set<T> set, int tin)
        {
            object newNumber = tin;
            set.Add((T)newNumber);
            return set;
        }
        public static Set<T> operator --(Set<T> set)
        {
            set.RemoveAt((T)(object)1);
            return set;
        }
        public int Size(Set<T> set)
        {
            return _list.Count;
        }

        public static bool operator !=(Set<T> arr1, Set<T> arr2)
        {
            return false;
        }
        public static bool operator ==(Set<T> arr1, Set<T> arr2)
        {
            if (arr1._list.Count != arr2._list.Count)
                return false;
            for (int i = 0; i < arr1._list.Count; i++)
            {

            }
            return arr1.Equals(arr2);
        }
        public static Set<T> operator *(Set<T> set, Set<T> set2)
        {
            Set<T> result = new Set<T>();
            result.Add(set);
            result.Add(set2);
            return result;
        }
        #endregion

    }
    public class Program
        {

        class User
        {
            public string Name { get; set; }

            public int Age { get; set; }

        }
        public static void Main()
            {
              Set<int> q = new Set<int>(1,2,3);
              Set<int> q1 = new Set<int>(1,2,3);
            List<User> listOfUsers = new List<User>()
        {
        new User() { Name = "john", Age = 42 },
        new User() { Name = "Joe", Age = 34 },
        new User() { Name = "Joe", Age = 8 },
        };

            for (int i = 0; i < listOfUsers.Count; i++)
            {
                var input = listOfUsers[i].Name;
                var result = input.IsUpper(0);
                Console.WriteLine("{0} : {1} ", input, result);
            }
            int quan=0;
            for (int i=1;i<listOfUsers.Count;i++)
            {
                if (listOfUsers[i].Name==listOfUsers[i-1].Name)
                {
                    quan++;
                }
            }
            Console.WriteLine("Повтор элементов: {0}", quan);

            Console.WriteLine(q);

                q.Add(6);
                Console.WriteLine("Вывод списка после добавления 6 {0}" ,q);
                Console.WriteLine("Вывод списка после добавления 6 {0}",q + 6);
                Console.WriteLine("Вывод списка после удаления первого элемента {0}",q--);
                Console.WriteLine("Сравнение списков {0}",q!=q1);

                Console.WriteLine("Сумма элементов в списке {0}", q.Sum());
                Console.WriteLine("Макс эдемент в списке {0}", q.Max());
                Console.WriteLine("Мин эдемент в списке {0}", q.Min());
                Console.WriteLine("Размер списка {0}", q.Size());

                Console.WriteLine(q * q1);
            Console.WriteLine("Размер списка {0} ", (q1*q).Size());
            Console.ReadKey();

        }
        }
}

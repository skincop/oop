using System;
using System.Text;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region инициализация
            byte @byte = 250;                //1
            sbyte @sbyte = -120;              //1
            short @short = -3200;            //2
            ushort @ushort = 65500;          //2
            int @int = 2100000000;           //4
            uint @uint = 4200000;
            long @long = 90000000000;       //8
            ulong @ulong = 18000000000;
            float @float = 3.3f;            //4
            double @double = 1.7;           //8
            char @char = 'a';               //2
            string @string = "Hello";
            bool @bool = true;
            @int = Convert.ToInt32(@float);
            //1
            Console.WriteLine("byte: {0}, sbyte: {1} ,short: {2}", @byte, @sbyte, @short);
            #endregion
            #region преобразование
            @long = @int;
            @short = @byte;
            @int = @sbyte;
            @float = @ushort;
            @double = @float;
            /////////////////////// явное
            @sbyte = (sbyte)@byte;
            @short = (short)@int;
            @byte = (byte)@double;
            @uint = (uint)@int;
            @ushort = (ushort)@ulong;
            //упаковка и распаковка
            int packing = 123;
            object o = packing;
            int unpucking = (int)o;

            #endregion
            #region ввод вывод
            Console.WriteLine("byte: {0}, sbyte: {1} ,short: {2}", @byte, @sbyte, @short);
            Console.WriteLine("Type number [0,255]   ");
            byte a = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(a);
            var myVar = 10.0;
            float fl = 3.4f;
            myVar = fl;
            #endregion
            Console.ReadKey();
            
            Console.Clear();
            #region строки
            Console.WriteLine("Type 2 string");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            //сравнение
            Console.Write("Is equal? ");
            if (String.Equals(str1, str2)) Console.WriteLine("equal");
            else Console.WriteLine("diffirent");
            Console.WriteLine("String concat: {0}", String.Concat(str1, str2));
            //провкера на содержание 2 строки в 1
            Console.Write("Does the str1 has str2: ");
            if (str1.Contains(str2)) Console.WriteLine("Yeah");
            else Console.WriteLine("No");
            //Убрать 2 первых символа в строке
            string text = "Hello! How do you do?";
            Console.WriteLine("Delete 2 symbols at str {0}", text.Substring(2));
            //вывод по словам
            Console.Write("String split: ");
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++) Console.Write(", {0} ", words[i]);
            //Соеденение двух,убрать все после 6 символа
            Console.WriteLine("");
            Console.WriteLine("Replace str {0}",text.Insert(6, str2));
            Console.WriteLine("Delete after 6 {0}", text.Remove(6));
            //интерполяция строк
            string name = "Yan";
            Console.WriteLine($"{name} is 18 years old");
            string empty = "";
            string _null = null;
            Console.WriteLine("Is Null or Empty: {0}", String.IsNullOrEmpty(empty));
            Console.WriteLine("Is Null or Empty: {0}", String.IsNullOrEmpty(_null));
            StringBuilder sb = new StringBuilder("Привет мир меня зовут Ян");
            Console.WriteLine(sb.Remove(6, 4));
            Console.WriteLine(sb.Replace("Ян", "Yan"));
            Console.WriteLine(sb.AppendFormat("123123"));

            #endregion
            Console.ReadKey();
            Console.Clear();
            #region массив
            // двумерный массив 
            int[,] array = new int[3, 3];
            Random ran = new Random();

            // Инициализируем данный массив
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            //вывод массива строк с длинной
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            Console.WriteLine("Length of array {0}", weekDays.Length);
            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.Write("{0} ,", weekDays[i]);
            }
            Console.WriteLine(" ");
            //замена элемента  в строке
            Console.WriteLine("Type position (min 1)");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type new str");
            string newStr = Console.ReadLine();
            weekDays[pos - 1] = newStr;
            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.Write("{0} ,", weekDays[i]);
            }
            //ступенчатый массив
            int[][] myArr = new int[3][];
            myArr[0] = new int[2];
            myArr[1] = new int[3];
            myArr[2] = new int[4];
            int m = 2;
            Console.WriteLine("");
            Console.WriteLine("Type value: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    myArr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                m++;
            }
            m = 2;
            Console.Clear();
            //вывод ступенчатого массива
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}   ", myArr[i][j]);
                }
                Console.WriteLine("");
                m++;
            }
            var unkArray = new object[] { 5, 10, 23, 16, 8 };
            var unkStr = "11111";
            Console.WriteLine("{0}", unkStr);
            for (int i=0;i<unkArray.Length;i++)
            {
                Console.Write("{0}  ",unkArray[i]);
            }


            Console.WriteLine("");
            #endregion
            Console.ReadKey();
            Console.Clear();
            #region кортежи
            (int, string, char, string, ulong) person = (18, "Yan", 'A', "Vysotskiy", 30000000);
            (int, string, char, string, ulong) person1 = (18, "Yan", 'A', "Vysotskiy", 31000000);
            Console.WriteLine(person);
            Console.WriteLine("{0}  {1}  {2}", person.Item1, person.Item3, person.Item4);


            string newStr1 = "string";
            int[] newArray = new int[3] {1,2,3 };
            var cortage = func(newStr1,newArray);
            Console.WriteLine(cortage);
            bool tuple = (person == person1);
            Console.WriteLine(tuple);
            object tuplePerson = person.Item5;
            int intTuplePerson = person.Item1;
            func1();
            func2();
            #endregion
            #region функция возврат кортежа


            //функция возврат кортеж

            static (int,int,int,string) func (string str, int[] array)

            {
                
                int min = 1000000,max = 0,sum=0;
                for (int i=0;i<array.Length;i++)
                {
                    sum += array[i];
                    if (array[i] > max) max = array[i];
                    if (array[i] < min) min = array[i];

                }
                return (min, max, sum, str.Substring(0, 1));
            }
            #endregion
            #region функции checked
            void func1 ()
            {
                try
                {
                    byte a = 255,b = 1,result;
                    checked
                    {
                        result = (byte)(a + b);
                        Console.WriteLine("a + b = " + result);
                    }
                }
                catch (OverflowException)
                {
                    Console.Write("Переполнение\n\n");
                }
            }

            void func2()
            {
               try
            {
                byte a = 255, b = 1, result;
                unchecked
                {
                    result = (byte)(a + b);
                    Console.WriteLine("a + b = " + result);
                }
            }
                catch (OverflowException)
            {
                Console.Write("Переполнение\n\n");
               }
            }
            #endregion











                      Console.ReadKey();


        }
    }
}


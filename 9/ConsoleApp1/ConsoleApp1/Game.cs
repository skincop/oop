using System;

namespace ConsoleApp1
{
    class Game
    {
        public delegate void ShowHealthPoint();
        delegate string Operation(string str1,string str2);
        delegate int Operation2(string str1,char str2);
        delegate int Operation3(string str1,string str2);
        delegate string Operation4(string str1,char str2);

        public static void Main(string[] args)
        {
            Operation func = (str1, str2) => str1 + str2;
            Operation2 func1 = (str1, str2) => str1.IndexOf(str2);
            Operation4 func2 = (str1, str2) => str1.Trim(str2);
            Operation3 funcc = (str1, str2) => str1.Length-str2.Length;
            Console.WriteLine(func("qwe","123"));
            Console.WriteLine(func1("qwe",'w'));
            Console.WriteLine(func2("1word1",'1'));
            Console.WriteLine(funcc("qwertyui","333"));
            var player = new Player("skincop");
            player.TakeDamage += Item_TakeDamage;
            player.TakeHeal += Item_TakeHeal;
            

            var model = new Model("wood", 25);
            model.TakeDamage += Item_TakeDamage;
            model.TakeHeal += Item_TakeHeal;

            model.Game();
            player.Game();

        }


        private static void Item_TakeHeal(object sender, EventArgs e)
        {
            if (sender is Model)
            {
                Console.WriteLine("Текстура похилилась");

            }
            if (sender is Player)
            {
                Console.WriteLine("Игрок похилился");
            }
        }

        private static void Item_TakeDamage(object sender, EventArgs e)
        {
            if (sender is Model)
            {
                Console.WriteLine("Текстура получила дамаг");
                
            }
            if (sender is Player)
            {
                Console.WriteLine("Игрок получила дамаг");
            }
        }
    }
}

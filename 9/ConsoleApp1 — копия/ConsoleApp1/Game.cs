using System;

namespace ConsoleApp1
{
    public class Game
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
            StartGame();


        }
        public static void StartGame()
        {
            #region start
            Console.WriteLine("Введите имя первого игрока");
            var player1 = new Player(Console.ReadLine());

            Console.WriteLine("1 - Убийца\n2 - Воин\n3 - Ловкач");
            int clas = Convert.ToInt32(Console.ReadLine());
            player1.PlayerClas = clas;
            player1.Ability(player1);

            player1.TakeHealEvent += Item_TakeHeal;
            player1.TakeDamageEvent += Item_TakeDamage;
            player1.EndGameEvent += Player_EndGameEvent;
            player1.EvadeEvent += Player_EvadeEvent;

            Console.WriteLine("Введите имя второго игрока");
            var player2 = new Player(Console.ReadLine());

            Console.WriteLine("1 - Убийца\n2 - Воин\n3 - Ловкач");
            clas = Convert.ToInt32(Console.ReadLine());
            player2.PlayerClas = clas;
            player2.Ability(player2);

            player2.TakeHealEvent += Item_TakeHeal;
            player2.TakeDamageEvent += Item_TakeDamage;
            player2.EndGameEvent += Player_EndGameEvent;
            player2.EvadeEvent += Player_EvadeEvent;

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Игра началась");
            Console.WriteLine(new string('-', 50));
            #endregion

            bool a = true;
            while (a)
            {

                Console.WriteLine($"Ход {player1.PlayerName}");
                var input = Console.ReadKey();
                Console.WriteLine("");
                switch (input.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine($"{player1.PlayerName} атакует {player2.PlayerName}");
                        player1.Attack(player1,player2);

                        break;
                    case ConsoleKey.H:
                        player1.HealUS(player1);
                        break;
                }
                Console.WriteLine($"Ход {player2.PlayerName}");
                input = Console.ReadKey();
                Console.WriteLine("");
                switch (input.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine($"{player2.PlayerName} атакует {player1.PlayerName}");
                        player2.Attack(player2, player1);

                        break;
                    case ConsoleKey.H:
                        player2.HealUS(player2);
                        break;
                }
            }
        }

        private static void Player_EvadeEvent(Player player1)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{player1.PlayerName} промахнулся");
            Console.ResetColor();
        }

        private static void Player_EndGameEvent(Player player1)
        {
            Console.Clear();
            Console.WriteLine($"{player1.PlayerName} победил!");
           
            
        }

        private static void Item_TakeHeal(Player player1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{player1.PlayerName} излечил себя,его хп {player1.PlayerHp}");
            Console.ResetColor();
        }

        private static void Item_TakeDamage(Player player1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"У {player1.PlayerName} осталось {player1.PlayerHp} хп");
            Console.ResetColor();

        }
    }
}

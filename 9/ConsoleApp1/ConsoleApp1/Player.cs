using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        public string PlayerName { get; private set; }
        public int PlayerHp { get; private set; }

        public event EventHandler TakeDamage;
        public event EventHandler TakeHeal;

        public Player(string playername)
        {
            PlayerName = playername;
            PlayerHp = 100;
        }
        public Player()
        {
            PlayerName = "noname";
            PlayerHp = 100;
        }

        public void Game()
        {
            while (true)
            {
                Console.WriteLine("1 - получить урон\n2 - восстановить хп");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        Console.WriteLine($"Player hp {PlayerHp}");
                        if (TakeDamage != null)
                        {
                            TakeDamage(this, new EventArgs());
                            PlayerHp -= 15;
                            Console.WriteLine($"Player hp {PlayerHp}");
                        }
                        break;
                    case "2":
                        Console.WriteLine($"Player hp {PlayerHp}");
                        if (TakeHeal != null)
                        {
                            TakeHeal(this, new EventArgs());
                            PlayerHp += 30;
                            Console.WriteLine($"Player hp {PlayerHp}");
                        }
                        break;
                }
            }
        }
    }
}

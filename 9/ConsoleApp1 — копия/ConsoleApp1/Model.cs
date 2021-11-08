using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Model
    {
        public string ModelName { get; private set; }
        public int ModelHp { get; private set; }
        public event EventHandler TakeDamage;
        public event EventHandler TakeHeal;
        public Model(string modelname,int modelhp)
        {
            ModelName = modelname;
            ModelHp = modelhp;
        }
        public Model()
        {
            ModelName = "unknown";
            ModelHp = 20;
        }
        public void Game()
        {
            bool a = true;
            while (a)
            {
                Console.WriteLine("1 - получить урон\n2 - восстановить хп");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        Console.WriteLine($"Model hp {ModelHp}");
                        if (TakeDamage != null)
                        {
                            TakeDamage(this, new EventArgs());

                            ModelHp -= 15;
                            Console.WriteLine($"Model hp {ModelHp}");
                        }
                        break;
                    case "2":
                        Console.WriteLine($"Model hp {ModelHp}");
                        if (TakeHeal != null)
                        {
                            TakeHeal(this, new EventArgs());
                            ModelHp += 30;
                            Console.WriteLine($"Model hp {ModelHp}");
                        }
                        break;
                    default:
                        a = false;
                        Console.Clear();
                        break;
                }
            }
        }
       
    }
}

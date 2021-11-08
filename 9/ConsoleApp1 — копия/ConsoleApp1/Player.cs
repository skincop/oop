using System;

namespace ConsoleApp1
{
    class Player
    {
        public string PlayerName { get; private set; }
        public int PlayerHp { get; private set; }
        public int PlayerClas { get;  set; }
        public double PlayerDamageCoeff { get; private set; }
        public double PlayerDamageCo { get; private set; }
        public double PlayerEvadeChanse { get; private set; }

        public delegate void MyDelegate(Player player1);

        public event MyDelegate TakeDamageEvent;
        public event MyDelegate TakeHealEvent;
        public event MyDelegate EndGameEvent;
        public event MyDelegate EvadeEvent;

        public Player(string playername)
        {
            PlayerName = playername;
            PlayerHp = 100;
            PlayerDamageCoeff = 1.0;
            PlayerEvadeChanse = 0;
        }
        public Player()
        {
            PlayerName = "noname";
            PlayerHp = 100;
        }
        public void Attack(Player player1,Player player2) //атакующий атакуемый
        {
            int attack= new Random().Next(10, 55);//32,5
            if (player2.PlayerEvadeChanse>1 && new Random().Next(1, 10) <= 2)
                player1.EvadeEvent(player1);
            else
            {

                player2.PlayerHp -= (int)(attack * player1.PlayerDamageCoeff);
                if (attack > 40) Console.WriteLine("Выпал крит");
                if (player2.PlayerHp <= 0) player2.EndGameEvent(player1);
                player1.TakeDamageEvent(player2);
            }
            

        }
        public void HealUS(Player player1)
        {
            player1.PlayerHp += new Random().Next(20, 65);//42.5
            if (player1.PlayerHp >= 100 && player1.PlayerClas!=2)
                player1.PlayerHp = 100;
            else if(player1.PlayerHp >= 120 && player1.PlayerClas == 2)
                player1.PlayerHp = 150;
            player1.TakeHealEvent(player1);
        }
        public void Ability(Player player1)
        {
            switch (player1.PlayerClas)
            {
                case 1:
                    player1.PlayerDamageCoeff = 1.2;
                    break;
                case 2:
                    player1.PlayerHp = 120;
                    break;
                case 3:
                    player1.PlayerEvadeChanse = 25;
                    break;
            }

        }
        
        
    }
}

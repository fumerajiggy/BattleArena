using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            int round = 1;
            Warrior Jiggy = new Warrior("Jiggy", 300, 15, "Dinilaan");
            Warrior Orbading = new Warrior("Orbading", 150, 32, "Sinubo");
            Warrior Dedong = new Warrior("Dedong", 200, 20, "Pinwetan");

            Jiggy.DisplayStatus();
            Orbading.DisplayStatus();
            Dedong.DisplayStatus();

            while (Jiggy.IsAlive && Orbading.IsAlive)
            {
                Console.WriteLine($"---------------- Round {round}  ----------------");
                Orbading.Attack(Jiggy);
                Jiggy.Attack(Orbading);
                Console.WriteLine("------------------------------------------");
                round++;
            }

            Console.ReadKey();
        }
    }
}
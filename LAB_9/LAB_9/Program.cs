using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game("First Player", 5);
            Game game2 = new Game("Second Player", 5);

            game1.OnAttack += g_onattack;
            game1.OnHeal += g_onheal;
            game2.OnAttack += g_onattack;
            game2.OnHeal += g_onheal;

            game1.Attack();
            game1.Attack();
            game1.Heal();

            game2.Attack();
            game2.Attack();
            game2.Attack();
            game2.Attack();
            game2.Heal();
            Console.WriteLine();
            Console.WriteLine(game1.ToString());
            Console.WriteLine(game2.ToString());

            ///////////////////////////////////////////////////////

            StringUpdates str = new StringUpdates("A B C D E");

            Action<StringUpdates> Up;
            Up = str.Low;
            Up += str.Change;
            Up += str.Upp;

        }

        public static void g_onattack()
        {
            Console.WriteLine("Обработчик события Attack!");
        }
        public static void g_onheal()
        {
            Console.WriteLine("Обработчик события Heal!");
        }
    }
}

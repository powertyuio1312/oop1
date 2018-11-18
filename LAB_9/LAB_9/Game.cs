using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_9
{
    public class Game
    {
        public delegate void  Deleg();

        public event Deleg OnAttack;
        public event Deleg OnHeal;

        public int health;
        public string name;
        public void Attack()
        {
            health--;
            if (OnAttack!=null)
            {
                OnAttack();
                Console.WriteLine("Attack: {0}! Health--. Health = {1}", this.name, this.health);
            }
        }

        public void Heal()
        {
            health++;
            if (OnHeal != null)
            {
                OnHeal();
                Console.WriteLine("Heal: {0} !! Health++. Health = {1}", this.name, this.health);
            }
        }

        public Game(string name, int health)
        {
            this.name = name;
            this.health = health;
        }

        public override string ToString()
        {
            return "Player " + this.name + ": Health: " + this.health.ToString() ;
        }
    }

}

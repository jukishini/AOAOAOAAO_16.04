using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOAOAOAO.Models
{
    
    internal class Undead:IKrip
    {
        public int damage;
        public int health;
        public Undead()
        {

        }
        public Undead(int damage, int hp)
        {
            this.damage = damage;
            this.health = hp;
        }
        public override string ToString()
        {
            return "Нежить";
        }
        public int GetHp()
        {
            return this.health;
        }
        public void UpdateStat(int damage, int hp)
        {

            this.damage = damage;
            this.health = hp;
        }
        public int Storming()
        {
            Random rnd = new Random((int)(DateTime.Now.Ticks));
            int value = rnd.Next(1, this.damage);
            return value;
        }
        public void LossOfHealth(int damage)
        {
            health = health - damage;
        }
        public bool IsDead()
        {
            bool isDead;
            if (health > 0)
            {
                isDead = false;
            }
            else
            {
                isDead = true;
            }
            return isDead;
        }
    }
}

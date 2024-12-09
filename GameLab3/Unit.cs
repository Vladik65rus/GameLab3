using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab3
{
    public class Unit : IUnit
    {
        public string Name { get; private set; }
        public int Health { get; set; }
        public int Attack { get; set; }

        public Unit(string name, int health, int attack)
        {
            Name = name;
            Health = health;
            Attack = attack;
        }

        public void AttackEnemy(IUnit enemy)
        {
            if (IsAlive())
            {
                enemy.TakeDamage(Attack);
            }
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}

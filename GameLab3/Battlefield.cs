using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab3
{
    public class Battlefield : IBattlefield
    {
        private List<IUnit> units;

        public Battlefield()
        {
            units = new List<IUnit>();
        }

        public void AddUnit(IUnit unit)
        {
            units.Add(unit);
        }

        public void StartBattle()
        {
            while (units.Any(u => u.IsAlive()))
            {
                foreach (var unit in units.Where(u => u.IsAlive()))
                {
                    var enemy = units.FirstOrDefault(u => u != unit && u.IsAlive());
                    if (enemy != null)
                    {
                        unit.AttackEnemy(enemy);
                    }
                }
            }
        }
    }

}

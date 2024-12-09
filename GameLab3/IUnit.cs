using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab3
{
    public interface IUnit
    {
        string Name { get; }
        int Health { get; set; }
        int Attack { get; set; }

        void AttackEnemy(IUnit enemy);
        void TakeDamage(int damage);
        bool IsAlive();
    }

    // Интерфейс поля битвы
    public interface IBattlefield
    {
        void AddUnit(IUnit unit);
        void StartBattle();
    }

    // Интерфейс игры
    public interface IGame
    {
        void StartGame();
        void SaveGame(string filePath);
        void LoadGame(string filePath);
    }
}

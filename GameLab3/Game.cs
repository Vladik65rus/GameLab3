using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLab3
{
    public class Game : IGame
    {
        public static Game CurrentGame { get; set; }  // Статическое свойство для игры
        private Player player1;
        private Player player2;
        private IBattlefield battlefield;

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Game()
        {
            player1 = new Player("Player 1");
            player2 = new Player("Player 2");
            battlefield = new Battlefield();
        }

        public void StartGame()
        {
            battlefield.AddUnit(player1.Unit);
            battlefield.AddUnit(player2.Unit);
            battlefield.StartBattle();
        }

        public void SaveGame(string filePath)
        {
            var gameState = new { player1, player2 };
            Serializer.SaveGame(gameState, filePath);
        }

        public void LoadGame(string filePath)
        {
            var gameState = Serializer.LoadGame<object>(filePath);
            if (gameState != null)
            {
                // восстановление состояния игры
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLab3
{
    internal static class Program
    {
        public static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Убедитесь, что здесь указана правильная форма
            Application.Run(new Form2());

            var game = new Game();
            game.StartGame();

            // Сохранение состояния игры
            game.SaveGame("game_state.json");

            // Загрузка состояния игры
            game.LoadGame("game_state.json");
        }
    }
}

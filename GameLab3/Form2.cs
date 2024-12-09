using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLab3
{
    public partial class Form2 : Form
    {
        private Game game;
        private Button StartGameButton;
        private Button SaveGameButton;
        private Button LoadGameButton;
        private Label GameStatusLabel;
        private Label Player1Label;
        private Label Player2Label;

        public Form2()
        {
            InitializeComponent();  // Инициализация компонентов формы
            game = new Game();

            // Инициализация компонентов управления
            StartGameButton = new Button();
            SaveGameButton = new Button();
            LoadGameButton = new Button();
            GameStatusLabel = new Label();
            Player1Label = new Label();
            Player2Label = new Label();

            // Установка свойств кнопок
            StartGameButton.Text = "Start Game";
            StartGameButton.Click += button1_Click;

            SaveGameButton.Text = "Save Game";
            SaveGameButton.Click += button2_Click;

            LoadGameButton.Text = "Load Game";
            LoadGameButton.Click += button3_Click;

            // Установка текстов для меток
            GameStatusLabel.Text = "Game Status: Not Started";
            Player1Label.Text = "Player 1: Not Available";
            Player2Label.Text = "Player 2: Not Available";

            // Добавление элементов управления на форму
            /*this.Controls.Add(StartGameButton);
            this.Controls.Add(SaveGameButton);
            this.Controls.Add(LoadGameButton);
            this.Controls.Add(GameStatusLabel);
            this.Controls.Add(Player1Label);
            this.Controls.Add(Player2Label);*/
        }
        private void GameStatusLabel1_Click(object sender, EventArgs e)
        {
            // Логика обработки клика по GameStatusLabel1
            MessageBox.Show("GameStatusLabel clicked");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Нет необходимости вызывать InitializeComponent() здесь
            // так как он уже был вызван в конструкторе
        }

        private void button1_Click(object sender, EventArgs e) // Обработчик нажатия кнопки "Начать игру"
        {
            // Инициализация игры
            game.StartGame();

            // Обновление UI
            UpdateGameStatus();
            UpdatePlayerInfo();
        }

        private void button2_Click(object sender, EventArgs e)  // Обработчик нажатия кнопки "Сохранить игру"
        {
            // Сохранение состояния игры в файл
            game.SaveGame("game_state.json");
            MessageBox.Show("Game saved successfully!");
        }

        private void button3_Click(object sender, EventArgs e) // Обработчик нажатия кнопки "Загрузить игру"
        {
            // Загрузка состояния игры из файла
            game.LoadGame("game_state.json");

            // Обновление UI после загрузки
            UpdateGameStatus();
            UpdatePlayerInfo();
            MessageBox.Show("Game loaded successfully!");
        }

        // Обновление информации о состоянии игры
        private void UpdateGameStatus()
        {
            GameStatusLabel.Text = "Game in progress...";  // Исправлено на GameStatusLabel
        }

        // Обновление информации о игроках
        private void UpdatePlayerInfo()
        {
            Player1Label.Text = $"Player 1: {game.Player1.Name} | Health: {game.Player1.Unit.Health}";
            Player2Label.Text = $"Player 2: {game.Player2.Name} | Health: {game.Player2.Unit.Health}";
        }
    }
}

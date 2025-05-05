
using MineSweeperClasses;
using System.Media;
using WMPLib;
using static MineSweeperGUI.FrmSettings;

namespace MineSweeperGUI
{
    public partial class FrmBoardGame : Form
    {
        // Properties
        private Board board;
        private Button[,] buttons;
        private DateTime gameStartTime;
        public static object score;
        // Windows Media Player for click sound
        private WindowsMediaPlayer clickPlayer = new WindowsMediaPlayer();
        // Explosion sound
        private WindowsMediaPlayer explosionSound = new WindowsMediaPlayer();
        // Reward sound
        private WindowsMediaPlayer goldSound = new WindowsMediaPlayer();
        // Flag sound
        private WindowsMediaPlayer flagSound = new WindowsMediaPlayer();
        // Background music player
        private static WindowsMediaPlayer backgroundPlayer = new WindowsMediaPlayer();

        
        // Constructor
        public FrmBoardGame(int size, float difficulty)
        {
            board = new Board(size, difficulty);
            InitializeComponent();

            SetupButtons();

            //Record the start time of the game
            gameStartTime = DateTime.Now;
            lblTime.Text = $"{gameStartTime.ToString("hh:mm:ss tt")}";

            //Disable final score label 
            lblScoreValue.Visible = false;

            // Background music
            SoundManager.UpdateBackgroundMusic();

            ApplyTheme();
        }
        // This method applies the selected theme to the form and its controls
        private void ApplyTheme()
        {
            // Set the form's background color based on the selected theme
            switch (GameSettings.SelectedTheme)
            {
                // Background color changes for each theme
                case "Mining":
                    this.BackColor = Color.LightSteelBlue;
                    panelMineSweeperBoard.BackColor = Color.LightGray; 
                    break;

                case "Night Surprise":
                    this.BackColor = Color.Black;
                    panelMineSweeperBoard.BackColor = Color.LightGray;
                    break;

                case "Garden":
                    this.BackColor = Color.Honeydew;
                    panelMineSweeperBoard.BackColor = Color.DarkOliveGreen;
                    break;
            }

            // Update the buttons' colors based on the selected theme
            foreach (Button btn in panelMineSweeperBoard.Controls.OfType<Button>())
            {
                switch (GameSettings.SelectedTheme)
                {
                    // Button changes for mining theme
                    case "Mining":
                        btn.BackColor = Color.SlateGray;
                        btn.ForeColor = Color.White;
                        break;
                    // Button changes for night surprise theme
                    case "Night Surprise":
                        btn.BackColor = Color.DarkSlateBlue;
                        btn.ForeColor = Color.White;
                        break;
                    // Button changes for garden theme
                    case "Garden":
                        btn.BackColor = Color.ForestGreen;
                        btn.ForeColor = Color.White;
                        break;
                }
            }
        }

        // Populate the panel with buttons in a grid layout
        private void SetupButtons()
        {
            // Create a 2D array of buttons based on the board size
            buttons = new Button[board.Size, board.Size];
            // Calculate the size of each button based on the panel size 
            int buttonSize = Math.Min(panelMineSweeperBoard.Width, panelMineSweeperBoard.Height) / board.Size;
            // Force the panel to be square
            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    // Create a new button and place it in the panel
                    buttons[row, col] = new Button();
                    // Set the button as a square
                    buttons[row, col].Width = buttonSize;
                    buttons[row, col].Height = buttonSize;
                    // Set the button
                    buttons[row, col].Left = col * buttonSize;
                    buttons[row, col].Top = row * buttonSize;
                    // Attach an event handler to the button
                    buttons[row, col].Click += GridButtons_Click;
                    // Store the buttons row and column with tag
                    buttons[row, col].Tag = new Point(row, col);

                    // Add the button to the panel
                    panelMineSweeperBoard.Controls.Add(buttons[row, col]);

                }
            }
        }
        // This method implements player's chosen action
        private void GridButtons_Click(object sender, EventArgs e)
        {
            

            Button b = (Button)sender;
            Point p = (Point)b.Tag;
            int row = p.X;
            int col = p.Y;

            MessageBox.Show($"You clicked on cell ({row},{col})");

            // Check if the user has selected an action
            if (comboBoxActions.SelectedItem == null)
            {
                MessageBox.Show("Please choose an action before clicking a cell.");
                return;
            }

            //Grab player's action choice
            string action = comboBoxActions.SelectedItem.ToString();
            //Mark button as flagged
            if (action == "Flag")
            {
                board.Cells[row, col].IsFlagged = true;
                UpdateButtonDisplay(board);
                CheckForWin();

                if (GameSettings.SoundEffectsOn)
                {
                    //Flag sound effect
                    flagSound.URL = @"C:\Users\kimal\Downloads\Casual-mobile-game-menu-ui-select.mp3";
                    flagSound.controls.play();
                }

            }
            // Player chose to visit cell
            else if (action == "Visit")
            {
                if (GameSettings.SoundEffectsOn)
                {
                    // Play sound effect when button is clicked
                    clickPlayer.URL = @"C:\Users\kimal\Downloads\Chainmail-armor-crafting.mp3";
                    clickPlayer.controls.play();
                }
                

                // Check if the cell is a bomb
                if (board.Cells[row, col].IsBomb)
                {
                    board.Cells[row, col].IsBomb = true;
                    board.Cells[row, col].IsVisited = true;
                    UpdateButtonDisplay(board);

                    if (GameSettings.SoundEffectsOn)
                    {
                        // Play explosion sound
                        explosionSound.URL = @"C:\Users\kimal\Downloads\mi_explosion_03_hpx.wav";
                        explosionSound.controls.play();
                    }


                    // Time elapsed
                    TimeSpan timeElapsed = DateTime.Now - gameStartTime;
                    // Calculate final score
                    int finalScore = board.DetermineFinalScore(timeElapsed);

                    // Display final score
                    lblScoreValue.Text = $"{finalScore}";
                    // Display message box with bomb hit
                    MessageBox.Show($"You hit a bomb! Game over in {timeElapsed.TotalSeconds:F0} " +
                        $"seconds.\nScore: {finalScore}");

                    lblScoreValue.Visible = true;


                    // Disable the board (cant play anymore)
                    DisableBoard();
                    return;

                }
                //Display if the cell is a reward
                else if (board.Cells[row, col].HasSpecialReward)
                {
                    board.Cells[row, col].IsVisited = true;
                    UpdateButtonDisplay(board);
                    MessageBox.Show("You got a reward!");

                    if (GameSettings.SoundEffectsOn)
                    {
                        // Reward sound effect
                        goldSound.URL = @"C:\Users\kimal\Downloads\Chips-falling-small.mp3";
                        goldSound.controls.play();
                    }

                    CheckForWin();
                    return;
                }
                // Run flood fill
                else
                {
                    board.FloodFill(row, col, null);
                    // Print new button results
                    UpdateButtonDisplay(board);
                    CheckForWin();
                }


            }
            // Update board if player uses reward
            else if (action == "Use Reward")
            {
                bool hasFoundReward = board.Cells.Cast<Cell>()
                    .Any(c => c.HasSpecialReward && c.IsVisited && !c.RewardUsed);

                if (!hasFoundReward)
                {
                    MessageBox.Show("You haven't found any rewards to use yet!");
                }
                else
                {
                    bool rewardUsed = board.UseSpecialReward();
                    UpdateButtonDisplay(board);

                    if (rewardUsed)
                        MessageBox.Show("Reward used! A bomb has been revealed.");
                    else
                        MessageBox.Show("No unrevealed bombs left to reveal.");
                }
                CheckForWin();

            }
        }
        // This method checks for a winner
        private void CheckForWin()
        {
            //Is the game still going or has the player lost/won?
            var status = board.DetermineGameStatus();
            if (status == MineSweeperClasses.Board.GameStatus.Won)
            {
                // Time elapsed
                TimeSpan timeElapsed = DateTime.Now - gameStartTime;
                // Calculate final score
                int finalScore = board.DetermineFinalScore(timeElapsed);
                // Display final score
                lblScoreValue.Text = $"{finalScore}";
                // Display label with final score
                lblScoreValue.Visible = true;
                // Display message box with win
                MessageBox.Show($"Congratulations! You won the game in {timeElapsed.TotalSeconds:F0} seconds.\n" +
                                $"Score: {finalScore}");
                // Disable the board (cant play anymore)
                DisableBoard();

                // Prompt for player name
                FrmPlayerName frmName = new FrmPlayerName("You Won!", "Enter your name for the high scores:", finalScore);
                if (frmName.ShowDialog() == DialogResult.OK)
                {
                    string playerName = frmName.InputText;


                    // Now pass name and score to HighScores
                    HighScores highScoresForm = new HighScores(playerName, finalScore);
                    highScoresForm.ShowDialog();
                }

            }

        }
        // Turn off all buttons on the board
        private void DisableBoard()
        {
            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    buttons[row, col].Enabled = false;
                }
            }
        }
        // Update Board cells
        private void UpdateButtonDisplay(Board board)
        {
            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    // Get the button at the current position
                    Button button = buttons[row, col];
                    // Get the cell at the current position
                    Cell cell = board.Cells[row, col];
                    // Update the button text based on the cell's properties
                    if (cell.IsVisited && cell.IsBomb)
                    {
                        board.Cells[row, col].IsVisited = true;
                        button.BackgroundImage = Image.FromFile(@"C:\Users\kimal\Downloads\dungeon-minesweeper-tiles\Skull.png");
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else if (cell.IsFlagged)
                    {
                        board.Cells[row, col].IsFlagged = true;
                        button.BackgroundImage = Image.FromFile(@"C:\Users\kimal\Downloads\dungeon-minesweeper-tiles\Tile 1.png");
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                    }

                    else if (cell.IsVisited && cell.HasSpecialReward)
                    {
                        board.Cells[row, col].IsVisited = true;
                        button.BackgroundImage = Image.FromFile("C:\\Users\\kimal\\Downloads\\dungeon-minesweeper-tiles\\Gold.png");
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else if (cell.IsVisited && cell.NumberOfBombNeighbors > 0)
                    {
                        string imagePath = @$"C:\Users\kimal\Downloads\dungeon-minesweeper-tiles\Number {cell.NumberOfBombNeighbors}.png";
                        button.BackgroundImage = Image.FromFile(imagePath);
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else if (!cell.IsVisited)
                    {
                        button.BackgroundImage = Image.FromFile("C:\\Users\\kimal\\Downloads\\dungeon-minesweeper-tiles\\Tile 2.png");
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        button.BackgroundImage = Image.FromFile("C:\\Users\\kimal\\Downloads\\dungeon-minesweeper-tiles\\Tile Flat.png");
                        button.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            }
        }
        // Click event for the restart button
        private void btnRestart_Click_1(object sender, EventArgs e)
        {
            FrmGameStart gameStart = new FrmGameStart();
            gameStart.Show();
            this.Close();
        }
        // Click event for the settings button
        private void btnSetting_Click(object sender, EventArgs e)
        {
            // Open the settings form
            FrmSettings settingsForm = new FrmSettings();
            settingsForm.FormClosed += (s, args) =>
            {
                ApplyTheme();        
            };
            settingsForm.Show();
        }
    }
}

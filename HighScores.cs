using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MineSweeperClasses.Board;

namespace MineSweeperGUI
{
    public partial class HighScores : Form
    {
        // GameStat to store current score info
        GameStat gameStat;
        // Bind to datagridview
        BindingSource bindingSource = new BindingSource();
        // List of all high scores
        public static List<GameStat> statList = new List<GameStat>();
        // Constructor
        public HighScores(string name, int score)
        {
            InitializeComponent();
            //Create and populate new entries
            gameStat = new GameStat();
            gameStat.Name = name;
            gameStat.Score = score;
            gameStat.GameTime = DateTime.Now;
            gameStat.Id = (statList.Count + 1).ToString();
            //Add new entry into the list
            statList.Add(gameStat);
            // Bind list to datagridview and display it
            bindingSource.DataSource = statList;
            dataGridView1.DataSource = bindingSource;
        }
        // Save high score list handler
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // User can pick where to save file
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Set filters for saving as text file
                saveFileDialog.Filter = "Text File (*.txt)|*.txt";
                saveFileDialog.Title = "Save High Scores";
                saveFileDialog.FileName = "HighScores.txt";
                // If the user selects a file and clicks OK
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Error handling
                    try
                    {
                        // Use streamwriter to develop save list in text file
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            // Write a header if you want
                            writer.WriteLine("Id,Name,Score,Date");
                            // Loop through each high score and add it to the text file
                            foreach (var stat in HighScores.statList)
                            {
                                // You can format this however you like (CSV-style here)
                                writer.WriteLine($"{stat.Id},{stat.Name},{stat.Score},{stat.GameTime}");
                            }
                        }
                        // User pop-up if successfully saved
                        MessageBox.Show("High scores saved successfully!");
                    }
                    // Error catcher
                    catch (Exception ex)
                    {
                        // Pop-up message if something went wrong
                        MessageBox.Show($"Failed to save file: {ex.Message}");
                    }
                }
            }
        }
        // Load high score list handler
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // User can pick which file to load
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set filters for loading text file
                openFileDialog.Filter = "Text File (*.txt)|*.txt";
                openFileDialog.Title = "Load High Scores";
                // If the user selects a file and clicks OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Error handling
                    try
                    {
                        // Use streamreader to read the file
                        var loadedStats = new List<GameStat>();
                        using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                        {
                            // Read the header line (if any)
                            string headerLine = reader.ReadLine();
                            // Read each line and parse it
                            while (!reader.EndOfStream)
                            {
                                string line = reader.ReadLine();
                                string[] parts = line.Split(',');
                                // Check if the line has the expected number of parts
                                if (parts.Length >= 4)
                                {
                                    GameStat stat = new GameStat
                                    {
                                        Id = parts[0],
                                        Name = parts[1],
                                        Score = int.Parse(parts[2]),
                                        GameTime = DateTime.Parse(parts[3])
                                    };
                                    // Add the stat to the loaded list
                                    loadedStats.Add(stat);
                                }
                            }
                        }

                        // Replace current list and refresh the DataGridView
                        HighScores.statList = loadedStats;

                        // Rebind the new data to the DataGridView
                        bindingSource.DataSource = null;
                        bindingSource.DataSource = HighScores.statList;
                        dataGridView1.DataSource = bindingSource;
                        // User pop-up if successfully loaded
                        MessageBox.Show("High scores loaded successfully!");
                    }
                    // Error catcher
                    catch (Exception ex)
                    {
                        // Pop-up message if something went wrong
                        MessageBox.Show($"Failed to load file: {ex.Message}");
                    }
                }
            }
        }
        // Exit event handler
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Prompt user
            var result = MessageBox.Show("Return to the game?", "Exit High Scores", MessageBoxButtons.YesNo);
            // Close form if Yes
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        // Method to sort by name in ascending order
        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sort the list by ascending name
            statList = statList.OrderBy(stat => stat.Name).ToList();

            // Refresh the DataGridView
            bindingSource.DataSource = null;
            bindingSource.DataSource = statList;
            dataGridView1.DataSource = bindingSource;

        }
        // Method to sort by score in descending order
        private void byScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sort the list by descending score
            statList = statList.OrderByDescending(stat => stat.Score).ToList();
            // Refresh the DataGridView
            bindingSource.DataSource = null;
            bindingSource.DataSource = statList;
            dataGridView1.DataSource = bindingSource;
        }
        // Method to sort by date in descending order
        private void byDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sort the list by descending date
            statList = statList.OrderByDescending(stat => stat.GameTime).ToList();
            // Refresh the DataGridView
            bindingSource.DataSource = null;
            bindingSource.DataSource = statList;
            dataGridView1.DataSource = bindingSource;
        }
        // Method to handle the OK button click event
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MineSweeperGUI
{
    public partial class FrmSettings : Form
    {
        // WindowsMediaPlayer for previewing music tracks
        private WindowsMediaPlayer previewPlayer = new WindowsMediaPlayer();

        // Properties to manage game settings
        public static class GameSettings
        {
            public static bool SoundEffectsOn { get; set; } = true;
            public static string SelectedMusicPath { get; set; } = @"C:\Users\kimal\Downloads\Brain Dance.mp3"; // Default track
            public static int MusicVolume { get; set; } = 100;
            public static string SelectedTheme { get; set; } = "Mining"; // Default theme

        }

        // Constructor
        public FrmSettings()
        {
            InitializeComponent();
            // Initialize the form with current settings
            rbtnSoundOn.Checked = GameSettings.SoundEffectsOn;
            rbtnSoundOff.Checked = !GameSettings.SoundEffectsOn;

            trackMusicVolume.Value = GameSettings.MusicVolume;
            lblMusicVolumePercentage.Text = GameSettings.MusicVolume.ToString();

            rbtnTrack1.Checked = GameSettings.SelectedMusicPath == @"C:\Users\kimal\Downloads\Brain Dance.mp3";
            rbtnTrack2.Checked = GameSettings.SelectedMusicPath == @"C:\Users\kimal\Downloads\Vibing Over Venus.mp3";
            rbtnTrack3.Checked = GameSettings.SelectedMusicPath == @"C:\Users\kimal\Downloads\Adventures in Adventureland.mp3";

            cmbTheme.SelectedItem = GameSettings.SelectedTheme;
        }
        // Method for the form load event
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            
            rbtnSoundOn.Checked = GameSettings.SoundEffectsOn;
            rbtnSoundOff.Checked = !GameSettings.SoundEffectsOn;
            // Configure the music volume track bar
            trackMusicVolume.Minimum = 0;
            trackMusicVolume.Maximum = 100;
            trackMusicVolume.Value = GameSettings.MusicVolume;
            lblMusicVolumePercentage.Text = GameSettings.MusicVolume.ToString();

            cmbTheme.Items.Clear();
            cmbTheme.Items.AddRange(new string[] { "Mining", "Night Surprise", "Garden" });
            cmbTheme.SelectedItem = GameSettings.SelectedTheme;

        }
        // Method for OK button click event
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Save the sound settings
            GameSettings.SoundEffectsOn = rbtnSoundOn.Checked;
            // Save the music track settings
            GameSettings.MusicVolume = trackMusicVolume.Value;
            SoundManager.UpdateBackgroundMusic(); // Adjust volume or change track
            // Save the selected theme
            GameSettings.SelectedTheme = cmbTheme.SelectedItem.ToString();
            // Close the settings form
            this.Close();
        }
        // Method for selecting track 1
        private void rbtnTrack1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTrack1.Checked)
            {
                GameSettings.SelectedMusicPath = @"C:\Users\kimal\Downloads\Brain Dance.mp3";
                SoundManager.UpdateBackgroundMusic();
            }
        }
        // Method for selecting track 2
        private void rbtnTrack2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTrack2.Checked)
            {
                GameSettings.SelectedMusicPath = @"C:\Users\kimal\Downloads\Vibing Over Venus.mp3";
                SoundManager.UpdateBackgroundMusic();
            }
        }
        // Method for selecting track 3
        private void rbtnTrack3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTrack3.Checked)
            {
                GameSettings.SelectedMusicPath = @"C:\Users\kimal\Downloads\Adventures in Adventureland.mp3";
                SoundManager.UpdateBackgroundMusic();
            }
        }
        // Method to adjust the volume
        private void trackMusicVolume_Scroll(object sender, EventArgs e)
        {
            GameSettings.MusicVolume = trackMusicVolume.Value;
            // Update the label to show the current volume percentage
            lblMusicVolumePercentage.Text = GameSettings.MusicVolume.ToString();
            SoundManager.UpdateBackgroundMusic();
        }
    }
}

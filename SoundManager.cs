using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using static MineSweeperGUI.FrmSettings;

namespace MineSweeperGUI
{

    public static class SoundManager
    {
        // WindowsMediaPlayer for background music
        private static WindowsMediaPlayer backgroundPlayer = new WindowsMediaPlayer();
        // Stores the music track's path 
        private static string currentTrack = "";

        // Constructor
        static SoundManager()
        {
            backgroundPlayer.settings.setMode("loop", true);
            backgroundPlayer.settings.volume = GameSettings.MusicVolume;
        }
        // Method to set the background music
        public static void UpdateBackgroundMusic()
        {
            if (GameSettings.SelectedMusicPath != currentTrack)
            {
                backgroundPlayer.controls.stop();
                backgroundPlayer.URL = GameSettings.SelectedMusicPath;
                backgroundPlayer.settings.volume = GameSettings.MusicVolume;
                backgroundPlayer.controls.play();
                currentTrack = GameSettings.SelectedMusicPath;
            }
            else
            {
                // Only adjust volume if same track is playing
                backgroundPlayer.settings.volume = GameSettings.MusicVolume;

                if (backgroundPlayer.playState != WMPPlayState.wmppsPlaying)
                {
                    backgroundPlayer.controls.play(); // Resume if not already playing
                }
            }
        }
        // Method to stop the background music
        public static void StopMusic()
        {
            backgroundPlayer.controls.stop();
            currentTrack = "";
        }
    }
}


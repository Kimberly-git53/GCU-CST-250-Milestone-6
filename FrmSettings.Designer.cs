namespace MineSweeperGUI
{
    partial class FrmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblControls = new Label();
            label2 = new Label();
            label3 = new Label();
            rbtnTrack1 = new RadioButton();
            rbtnTrack2 = new RadioButton();
            rbtnTrack3 = new RadioButton();
            label1 = new Label();
            rbtnSoundOn = new RadioButton();
            rbtnSoundOff = new RadioButton();
            lblMusicVolumePercentage = new Label();
            trackMusicVolume = new TrackBar();
            label4 = new Label();
            cmbTheme = new ComboBox();
            btnOK = new Button();
            groupBoxSoundEffects = new GroupBox();
            groupBoxVolumeControl = new GroupBox();
            groupBoxSoundTracks = new GroupBox();
            groupBoxThemeControl = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)trackMusicVolume).BeginInit();
            groupBoxSoundEffects.SuspendLayout();
            groupBoxVolumeControl.SuspendLayout();
            groupBoxSoundTracks.SuspendLayout();
            groupBoxThemeControl.SuspendLayout();
            SuspendLayout();
            // 
            // lblControls
            // 
            lblControls.AutoSize = true;
            lblControls.Font = new Font("Showcard Gothic", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblControls.Location = new Point(256, 33);
            lblControls.Name = "lblControls";
            lblControls.Size = new Size(169, 37);
            lblControls.TabIndex = 0;
            lblControls.Text = "Controls";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 39);
            label2.Name = "label2";
            label2.Size = new Size(127, 26);
            label2.TabIndex = 1;
            label2.Text = "Sound Efx:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Underline);
            label3.Location = new Point(148, 21);
            label3.Name = "label3";
            label3.Size = new Size(159, 26);
            label3.TabIndex = 2;
            label3.Text = "Sound Tracks";
            // 
            // rbtnTrack1
            // 
            rbtnTrack1.AutoSize = true;
            rbtnTrack1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnTrack1.Location = new Point(12, 53);
            rbtnTrack1.Name = "rbtnTrack1";
            rbtnTrack1.Size = new Size(95, 25);
            rbtnTrack1.TabIndex = 3;
            rbtnTrack1.TabStop = true;
            rbtnTrack1.Text = "Track 1";
            rbtnTrack1.UseVisualStyleBackColor = true;
            rbtnTrack1.CheckedChanged += rbtnTrack1_CheckedChanged;
            // 
            // rbtnTrack2
            // 
            rbtnTrack2.AutoSize = true;
            rbtnTrack2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnTrack2.Location = new Point(148, 53);
            rbtnTrack2.Name = "rbtnTrack2";
            rbtnTrack2.Size = new Size(96, 25);
            rbtnTrack2.TabIndex = 4;
            rbtnTrack2.TabStop = true;
            rbtnTrack2.Text = "Track 2";
            rbtnTrack2.UseVisualStyleBackColor = true;
            rbtnTrack2.CheckedChanged += rbtnTrack2_CheckedChanged;
            // 
            // rbtnTrack3
            // 
            rbtnTrack3.AutoSize = true;
            rbtnTrack3.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnTrack3.Location = new Point(303, 53);
            rbtnTrack3.Name = "rbtnTrack3";
            rbtnTrack3.Size = new Size(96, 25);
            rbtnTrack3.TabIndex = 5;
            rbtnTrack3.TabStop = true;
            rbtnTrack3.Text = "Track 3";
            rbtnTrack3.UseVisualStyleBackColor = true;
            rbtnTrack3.CheckedChanged += rbtnTrack3_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(164, 26);
            label1.TabIndex = 6;
            label1.Text = "Music Volume:";
            // 
            // rbtnSoundOn
            // 
            rbtnSoundOn.AutoSize = true;
            rbtnSoundOn.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnSoundOn.Location = new Point(159, 41);
            rbtnSoundOn.Name = "rbtnSoundOn";
            rbtnSoundOn.Size = new Size(54, 25);
            rbtnSoundOn.TabIndex = 7;
            rbtnSoundOn.TabStop = true;
            rbtnSoundOn.Text = "On";
            rbtnSoundOn.UseVisualStyleBackColor = true;
            // 
            // rbtnSoundOff
            // 
            rbtnSoundOff.AutoSize = true;
            rbtnSoundOff.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnSoundOff.Location = new Point(267, 41);
            rbtnSoundOff.Name = "rbtnSoundOff";
            rbtnSoundOff.Size = new Size(61, 25);
            rbtnSoundOff.TabIndex = 8;
            rbtnSoundOff.TabStop = true;
            rbtnSoundOff.Text = "Off";
            rbtnSoundOff.UseVisualStyleBackColor = true;
            // 
            // lblMusicVolumePercentage
            // 
            lblMusicVolumePercentage.AutoSize = true;
            lblMusicVolumePercentage.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMusicVolumePercentage.Location = new Point(220, 27);
            lblMusicVolumePercentage.Name = "lblMusicVolumePercentage";
            lblMusicVolumePercentage.Size = new Size(24, 21);
            lblMusicVolumePercentage.TabIndex = 10;
            lblMusicVolumePercentage.Text = "%";
            // 
            // trackMusicVolume
            // 
            trackMusicVolume.LargeChange = 10;
            trackMusicVolume.Location = new Point(12, 53);
            trackMusicVolume.Maximum = 100;
            trackMusicVolume.Name = "trackMusicVolume";
            trackMusicVolume.Size = new Size(370, 56);
            trackMusicVolume.TabIndex = 11;
            trackMusicVolume.TickFrequency = 10;
            trackMusicVolume.Scroll += trackMusicVolume_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F);
            label4.Location = new Point(5, 23);
            label4.Name = "label4";
            label4.Size = new Size(169, 26);
            label4.TabIndex = 12;
            label4.Text = "Change theme:";
            // 
            // cmbTheme
            // 
            cmbTheme.FormattingEnabled = true;
            cmbTheme.Items.AddRange(new object[] { "Mining", "Night Surprise", "Garden" });
            cmbTheme.Location = new Point(176, 26);
            cmbTheme.Name = "cmbTheme";
            cmbTheme.Size = new Size(234, 28);
            cmbTheme.TabIndex = 13;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.Blue;
            btnOK.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(300, 506);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 14;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // groupBoxSoundEffects
            // 
            groupBoxSoundEffects.Controls.Add(label2);
            groupBoxSoundEffects.Controls.Add(rbtnSoundOn);
            groupBoxSoundEffects.Controls.Add(rbtnSoundOff);
            groupBoxSoundEffects.Location = new Point(97, 86);
            groupBoxSoundEffects.Name = "groupBoxSoundEffects";
            groupBoxSoundEffects.Size = new Size(416, 98);
            groupBoxSoundEffects.TabIndex = 15;
            groupBoxSoundEffects.TabStop = false;
            // 
            // groupBoxVolumeControl
            // 
            groupBoxVolumeControl.Controls.Add(label1);
            groupBoxVolumeControl.Controls.Add(lblMusicVolumePercentage);
            groupBoxVolumeControl.Controls.Add(trackMusicVolume);
            groupBoxVolumeControl.Location = new Point(97, 190);
            groupBoxVolumeControl.Name = "groupBoxVolumeControl";
            groupBoxVolumeControl.Size = new Size(416, 119);
            groupBoxVolumeControl.TabIndex = 16;
            groupBoxVolumeControl.TabStop = false;
            // 
            // groupBoxSoundTracks
            // 
            groupBoxSoundTracks.Controls.Add(label3);
            groupBoxSoundTracks.Controls.Add(rbtnTrack1);
            groupBoxSoundTracks.Controls.Add(rbtnTrack2);
            groupBoxSoundTracks.Controls.Add(rbtnTrack3);
            groupBoxSoundTracks.Location = new Point(97, 315);
            groupBoxSoundTracks.Name = "groupBoxSoundTracks";
            groupBoxSoundTracks.Size = new Size(416, 99);
            groupBoxSoundTracks.TabIndex = 17;
            groupBoxSoundTracks.TabStop = false;
            // 
            // groupBoxThemeControl
            // 
            groupBoxThemeControl.Controls.Add(label4);
            groupBoxThemeControl.Controls.Add(cmbTheme);
            groupBoxThemeControl.Location = new Point(97, 420);
            groupBoxThemeControl.Name = "groupBoxThemeControl";
            groupBoxThemeControl.Size = new Size(416, 80);
            groupBoxThemeControl.TabIndex = 18;
            groupBoxThemeControl.TabStop = false;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(658, 547);
            Controls.Add(groupBoxThemeControl);
            Controls.Add(groupBoxSoundTracks);
            Controls.Add(groupBoxVolumeControl);
            Controls.Add(groupBoxSoundEffects);
            Controls.Add(btnOK);
            Controls.Add(lblControls);
            ForeColor = Color.LightGreen;
            Name = "FrmSettings";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)trackMusicVolume).EndInit();
            groupBoxSoundEffects.ResumeLayout(false);
            groupBoxSoundEffects.PerformLayout();
            groupBoxVolumeControl.ResumeLayout(false);
            groupBoxVolumeControl.PerformLayout();
            groupBoxSoundTracks.ResumeLayout(false);
            groupBoxSoundTracks.PerformLayout();
            groupBoxThemeControl.ResumeLayout(false);
            groupBoxThemeControl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblControls;
        private Label label2;
        private Label label3;
        private RadioButton rbtnTrack1;
        private RadioButton rbtnTrack2;
        private RadioButton rbtnTrack3;
        private Label label1;
        private RadioButton rbtnSoundOn;
        private RadioButton rbtnSoundOff;
        private Label lblMusicVolumePercentage;
        private TrackBar trackMusicVolume;
        private Label label4;
        private ComboBox cmbTheme;
        private Button btnOK;
        private GroupBox groupBoxSoundEffects;
        private GroupBox groupBoxVolumeControl;
        private GroupBox groupBoxSoundTracks;
        private GroupBox groupBoxThemeControl;
    }
}
namespace MineSweeperGUI
{
    partial class FrmPlayerName
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
            lblPrompt = new Label();
            lblScore = new Label();
            txtboxName = new TextBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrompt.ForeColor = Color.Indigo;
            lblPrompt.Location = new Point(38, 31);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(435, 23);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Congratulations you win. Enter your name.";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.Indigo;
            lblScore.Location = new Point(38, 111);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(75, 23);
            lblScore.TabIndex = 1;
            lblScore.Text = "Score: ";
            // 
            // txtboxName
            // 
            txtboxName.Location = new Point(37, 64);
            txtboxName.Name = "txtboxName";
            txtboxName.Size = new Size(436, 27);
            txtboxName.TabIndex = 2;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.DarkSlateBlue;
            btnOK.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.ForeColor = Color.Cyan;
            btnOK.Location = new Point(208, 155);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(104, 33);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // FrmPlayerName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(491, 216);
            Controls.Add(btnOK);
            Controls.Add(txtboxName);
            Controls.Add(lblScore);
            Controls.Add(lblPrompt);
            Name = "FrmPlayerName";
            Text = "Player Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private Label lblScore;
        private TextBox txtboxName;
        private Button btnOK;
    }
}
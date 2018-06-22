namespace MatchingGame
{
    partial class MultiGameForm
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
            this.components = new System.ComponentModel.Container();
            this.gamePan = new MatchingGame.DoubleBufferPanel();
            this.playerScore1 = new System.Windows.Forms.Label();
            this.playerScore2 = new System.Windows.Forms.Label();
            this.ImageTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gamePan
            // 
            this.gamePan.AutoSize = true;
            this.gamePan.BackColor = System.Drawing.Color.Transparent;
            this.gamePan.Location = new System.Drawing.Point(66, 52);
            this.gamePan.Name = "gamePan";
            this.gamePan.Size = new System.Drawing.Size(288, 230);
            this.gamePan.TabIndex = 0;
            // 
            // playerScore1
            // 
            this.playerScore1.AutoSize = true;
            this.playerScore1.BackColor = System.Drawing.Color.Transparent;
            this.playerScore1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.playerScore1.Location = new System.Drawing.Point(535, 75);
            this.playerScore1.Name = "playerScore1";
            this.playerScore1.Size = new System.Drawing.Size(134, 40);
            this.playerScore1.TabIndex = 1;
            this.playerScore1.Text = "label1";
            // 
            // playerScore2
            // 
            this.playerScore2.AutoSize = true;
            this.playerScore2.BackColor = System.Drawing.Color.Transparent;
            this.playerScore2.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.playerScore2.Location = new System.Drawing.Point(535, 130);
            this.playerScore2.Name = "playerScore2";
            this.playerScore2.Size = new System.Drawing.Size(134, 40);
            this.playerScore2.TabIndex = 1;
            this.playerScore2.Text = "label1";
            // 
            // ImageTimer
            // 
            this.ImageTimer.Enabled = true;
            this.ImageTimer.Interval = 10;
            this.ImageTimer.Tick += new System.EventHandler(this.ImageTimer_Tick);
            // 
            // MultiGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playerScore2);
            this.Controls.Add(this.playerScore1);
            this.Controls.Add(this.gamePan);
            this.DoubleBuffered = true;
            this.Name = "MultiGameForm";
            this.Text = "MultiGameForm";
            this.Load += new System.EventHandler(this.MultiGameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MultiGameForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MultiGameForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleBufferPanel gamePan;
        private System.Windows.Forms.Label playerScore1;
        private System.Windows.Forms.Label playerScore2;
        private System.Windows.Forms.Timer ImageTimer;
    }
}
namespace Game
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerScore1 = new System.Windows.Forms.Label();
            this.playerScore2 = new System.Windows.Forms.Label();
            this.imageTimer = new System.Windows.Forms.Timer(this.components);
            this.gamePan = new Game.DoubleBufferPanel();
            this.SuspendLayout();
            // 
            // playerScore1
            // 
            this.playerScore1.AutoSize = true;
            this.playerScore1.BackColor = System.Drawing.Color.Transparent;
            this.playerScore1.Font = new System.Drawing.Font("Komikazoom", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore1.Location = new System.Drawing.Point(939, 27);
            this.playerScore1.Name = "playerScore1";
            this.playerScore1.Size = new System.Drawing.Size(127, 53);
            this.playerScore1.TabIndex = 1;
            this.playerScore1.Text = "label1";
            // 
            // playerScore2
            // 
            this.playerScore2.AutoSize = true;
            this.playerScore2.BackColor = System.Drawing.Color.Transparent;
            this.playerScore2.Font = new System.Drawing.Font("Komikazoom", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore2.Location = new System.Drawing.Point(939, 113);
            this.playerScore2.Name = "playerScore2";
            this.playerScore2.Size = new System.Drawing.Size(127, 53);
            this.playerScore2.TabIndex = 1;
            this.playerScore2.Text = "label1";
            // 
            // imageTimer
            // 
            this.imageTimer.Enabled = true;
            this.imageTimer.Interval = 10;
            this.imageTimer.Tick += new System.EventHandler(this.imageTimer_Tick);
            // 
            // gamePan
            // 
            this.gamePan.AutoSize = true;
            this.gamePan.BackColor = System.Drawing.Color.Transparent;
            this.gamePan.Location = new System.Drawing.Point(46, 50);
            this.gamePan.Name = "gamePan";
            this.gamePan.Size = new System.Drawing.Size(200, 100);
            this.gamePan.TabIndex = 2;
            // 
            // MultiGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1382, 494);
            this.Controls.Add(this.gamePan);
            this.Controls.Add(this.playerScore2);
            this.Controls.Add(this.playerScore1);
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
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerScore1;
        private System.Windows.Forms.Label playerScore2;
        private DoubleBufferPanel gamePan;
        private System.Windows.Forms.Timer imageTimer;
    }
}
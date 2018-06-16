namespace Game
{
    partial class SingleGameForm
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.imageTimer = new System.Windows.Forms.Timer(this.components);
            this.gamePan = new Game.DoubleBufferPanel();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Komikazoom", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(956, 42);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(40, 53);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "l";
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
            this.gamePan.Location = new System.Drawing.Point(45, 28);
            this.gamePan.Name = "gamePan";
            this.gamePan.Size = new System.Drawing.Size(692, 453);
            this.gamePan.TabIndex = 2;
            // 
            // SingleGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1282, 505);
            this.Controls.Add(this.gamePan);
            this.Controls.Add(this.scoreLabel);
            this.DoubleBuffered = true;
            this.Name = "SingleGameForm";
            this.Text = "SingleEasyGameForm";
            this.Load += new System.EventHandler(this.SingleEasyGameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SingleGameForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreLabel;
        private DoubleBufferPanel gamePan;
        private System.Windows.Forms.Timer imageTimer;
    }
}
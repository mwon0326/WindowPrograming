namespace MatchingGame
{
    partial class MainForm
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.highscoreButton = new MatchingGame.DoubleBufferPanel();
            this.quitButton = new MatchingGame.DoubleBufferPanel();
            this.playButton = new MatchingGame.DoubleBufferPanel();
            this.title = new MatchingGame.DoubleBufferPanel();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // highscoreButton
            // 
            this.highscoreButton.BackColor = System.Drawing.Color.Transparent;
            this.highscoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.highscoreButton.Location = new System.Drawing.Point(327, 345);
            this.highscoreButton.Name = "highscoreButton";
            this.highscoreButton.Size = new System.Drawing.Size(300, 50);
            this.highscoreButton.TabIndex = 1;
            this.highscoreButton.Click += new System.EventHandler(this.highscoreButton_Click);
            this.highscoreButton.MouseEnter += new System.EventHandler(this.highscoreButton_MouseEnter);
            this.highscoreButton.MouseLeave += new System.EventHandler(this.highscoreButton_MouseLeave);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.quitButton.Location = new System.Drawing.Point(12, 345);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(300, 50);
            this.quitButton.TabIndex = 1;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            this.quitButton.MouseEnter += new System.EventHandler(this.quitButton_MouseEnter);
            this.quitButton.MouseLeave += new System.EventHandler(this.quitButton_MouseLeave);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playButton.Location = new System.Drawing.Point(12, 289);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(300, 50);
            this.playButton.TabIndex = 1;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.MouseEnter += new System.EventHandler(this.playButton_MouseEnter);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.title.Location = new System.Drawing.Point(12, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(556, 259);
            this.title.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.highscoreButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferPanel title;
        private DoubleBufferPanel playButton;
        private DoubleBufferPanel quitButton;
        private DoubleBufferPanel highscoreButton;
        private System.Windows.Forms.Timer timer;
    }
}
namespace Game
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.title = new Game.DoubleBufferPanel();
            this.quitButton = new Game.DoubleBufferPanel();
            this.highscoreButton = new Game.DoubleBufferPanel();
            this.playButton = new Game.DoubleBufferPanel();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.title.Location = new System.Drawing.Point(192, 65);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(556, 259);
            this.title.TabIndex = 2;
            // 
            // quitButton
            // 
            this.quitButton.AutoSize = true;
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.quitButton.Location = new System.Drawing.Point(231, 494);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(300, 50);
            this.quitButton.TabIndex = 1;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            this.quitButton.MouseEnter += new System.EventHandler(this.quitButton_MouseEnter);
            this.quitButton.MouseLeave += new System.EventHandler(this.quitButton_MouseLeave);
            // 
            // highscoreButton
            // 
            this.highscoreButton.AutoSize = true;
            this.highscoreButton.BackColor = System.Drawing.Color.Transparent;
            this.highscoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.highscoreButton.Location = new System.Drawing.Point(231, 406);
            this.highscoreButton.Name = "highscoreButton";
            this.highscoreButton.Size = new System.Drawing.Size(300, 50);
            this.highscoreButton.TabIndex = 1;
            this.highscoreButton.Click += new System.EventHandler(this.highscoreButton_Click);
            this.highscoreButton.MouseEnter += new System.EventHandler(this.highscoreButton_MouseEnter);
            this.highscoreButton.MouseLeave += new System.EventHandler(this.highscoreButton_MouseLeave);
            // 
            // playButton
            // 
            this.playButton.AutoSize = true;
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playButton.Location = new System.Drawing.Point(231, 319);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(300, 50);
            this.playButton.TabIndex = 1;
            this.playButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playButton_MouseClick);
            this.playButton.MouseEnter += new System.EventHandler(this.playButton_MouseEnter);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 604);
            this.Controls.Add(this.title);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.highscoreButton);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Matching Game";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private DoubleBufferPanel title;
        private DoubleBufferPanel playButton;
        private DoubleBufferPanel highscoreButton;
        private DoubleBufferPanel quitButton;
    }
}


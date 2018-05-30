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
            this.playButton = new System.Windows.Forms.Panel();
            this.highscoreButton = new System.Windows.Forms.Panel();
            this.quitButton = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.AutoSize = true;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playButton.Location = new System.Drawing.Point(185, 368);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(314, 65);
            this.playButton.TabIndex = 1;
            this.playButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playButton_MouseClick);
            this.playButton.MouseEnter += new System.EventHandler(this.playButton_MouseEnter);
            this.playButton.MouseLeave += new System.EventHandler(this.playButton_MouseLeave);
            // 
            // highscoreButton
            // 
            this.highscoreButton.AutoSize = true;
            this.highscoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.highscoreButton.Location = new System.Drawing.Point(185, 479);
            this.highscoreButton.Name = "highscoreButton";
            this.highscoreButton.Size = new System.Drawing.Size(314, 65);
            this.highscoreButton.TabIndex = 1;
            this.highscoreButton.MouseEnter += new System.EventHandler(this.highscoreButton_MouseEnter);
            this.highscoreButton.MouseLeave += new System.EventHandler(this.highscoreButton_MouseLeave);
            // 
            // quitButton
            // 
            this.quitButton.AutoSize = true;
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.quitButton.Location = new System.Drawing.Point(185, 590);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(314, 65);
            this.quitButton.TabIndex = 1;
            this.quitButton.MouseEnter += new System.EventHandler(this.quitButton_MouseEnter);
            this.quitButton.MouseLeave += new System.EventHandler(this.quitButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 753);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.highscoreButton);
            this.Controls.Add(this.playButton);
            this.Name = "MainForm";
            this.Text = "짝 맞추기 게임";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel playButton;
        private System.Windows.Forms.Panel highscoreButton;
        private System.Windows.Forms.Panel quitButton;
    }
}


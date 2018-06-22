namespace MatchingGame
{
    partial class RankingForm
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
            this.normalLabel = new System.Windows.Forms.Label();
            this.easyLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.easyScoreLabel = new System.Windows.Forms.Label();
            this.normalScoreLabel = new System.Windows.Forms.Label();
            this.backButton = new MatchingGame.DoubleBufferPanel();
            this.SuspendLayout();
            // 
            // normalLabel
            // 
            this.normalLabel.AutoSize = true;
            this.normalLabel.BackColor = System.Drawing.Color.Transparent;
            this.normalLabel.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.normalLabel.Location = new System.Drawing.Point(429, 104);
            this.normalLabel.Name = "normalLabel";
            this.normalLabel.Size = new System.Drawing.Size(190, 40);
            this.normalLabel.TabIndex = 1;
            this.normalLabel.Text = "NORMAL";
            // 
            // easyLabel
            // 
            this.easyLabel.AutoSize = true;
            this.easyLabel.BackColor = System.Drawing.Color.Transparent;
            this.easyLabel.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.easyLabel.Location = new System.Drawing.Point(278, 104);
            this.easyLabel.Name = "easyLabel";
            this.easyLabel.Size = new System.Drawing.Size(122, 40);
            this.easyLabel.TabIndex = 1;
            this.easyLabel.Text = "EASY";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // easyScoreLabel
            // 
            this.easyScoreLabel.AutoSize = true;
            this.easyScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.easyScoreLabel.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.easyScoreLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.easyScoreLabel.Location = new System.Drawing.Point(278, 159);
            this.easyScoreLabel.Name = "easyScoreLabel";
            this.easyScoreLabel.Size = new System.Drawing.Size(0, 40);
            this.easyScoreLabel.TabIndex = 1;
            // 
            // normalScoreLabel
            // 
            this.normalScoreLabel.AutoSize = true;
            this.normalScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.normalScoreLabel.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.normalScoreLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.normalScoreLabel.Location = new System.Drawing.Point(429, 165);
            this.normalScoreLabel.Name = "normalScoreLabel";
            this.normalScoreLabel.Size = new System.Drawing.Size(0, 40);
            this.normalScoreLabel.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Location = new System.Drawing.Point(359, 305);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(300, 50);
            this.backButton.TabIndex = 0;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            // 
            // RankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.easyScoreLabel);
            this.Controls.Add(this.normalScoreLabel);
            this.Controls.Add(this.easyLabel);
            this.Controls.Add(this.normalLabel);
            this.Controls.Add(this.backButton);
            this.DoubleBuffered = true;
            this.Name = "RankingForm";
            this.Text = "RankingForm";
            this.Load += new System.EventHandler(this.RankingForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RankingForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleBufferPanel backButton;
        private System.Windows.Forms.Label normalLabel;
        private System.Windows.Forms.Label easyLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label easyScoreLabel;
        private System.Windows.Forms.Label normalScoreLabel;
    }
}
namespace Game
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
            this.easyScoreLabel = new System.Windows.Forms.Label();
            this.backButton = new Game.DoubleBufferPanel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.normalScoreLabel = new System.Windows.Forms.Label();
            this.easyLabel = new System.Windows.Forms.Label();
            this.normalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // easyScoreLabel
            // 
            this.easyScoreLabel.AutoSize = true;
            this.easyScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.easyScoreLabel.Font = new System.Drawing.Font("Komikazoom", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyScoreLabel.Location = new System.Drawing.Point(194, 71);
            this.easyScoreLabel.Name = "easyScoreLabel";
            this.easyScoreLabel.Size = new System.Drawing.Size(0, 53);
            this.easyScoreLabel.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Location = new System.Drawing.Point(90, 165);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(300, 50);
            this.backButton.TabIndex = 0;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // normalScoreLabel
            // 
            this.normalScoreLabel.AutoSize = true;
            this.normalScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.normalScoreLabel.Font = new System.Drawing.Font("Komikazoom", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalScoreLabel.Location = new System.Drawing.Point(243, 71);
            this.normalScoreLabel.Name = "normalScoreLabel";
            this.normalScoreLabel.Size = new System.Drawing.Size(0, 53);
            this.normalScoreLabel.TabIndex = 1;
            // 
            // easyLabel
            // 
            this.easyLabel.AutoSize = true;
            this.easyLabel.BackColor = System.Drawing.Color.Transparent;
            this.easyLabel.Font = new System.Drawing.Font("Komikazoom", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyLabel.Location = new System.Drawing.Point(215, 109);
            this.easyLabel.Name = "easyLabel";
            this.easyLabel.Size = new System.Drawing.Size(101, 53);
            this.easyLabel.TabIndex = 1;
            this.easyLabel.Text = "EASY";
            this.easyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // normalLabel
            // 
            this.normalLabel.AutoSize = true;
            this.normalLabel.BackColor = System.Drawing.Color.Transparent;
            this.normalLabel.Font = new System.Drawing.Font("Komikazoom", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalLabel.Location = new System.Drawing.Point(390, 71);
            this.normalLabel.Name = "normalLabel";
            this.normalLabel.Size = new System.Drawing.Size(151, 53);
            this.normalLabel.TabIndex = 1;
            this.normalLabel.Text = "NORMAL";
            this.normalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 344);
            this.Controls.Add(this.normalLabel);
            this.Controls.Add(this.easyLabel);
            this.Controls.Add(this.normalScoreLabel);
            this.Controls.Add(this.easyScoreLabel);
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
        private System.Windows.Forms.Label easyScoreLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label normalScoreLabel;
        private System.Windows.Forms.Label easyLabel;
        private System.Windows.Forms.Label normalLabel;
    }
}
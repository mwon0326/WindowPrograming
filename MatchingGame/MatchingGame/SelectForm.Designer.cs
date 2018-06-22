namespace MatchingGame
{
    partial class SelectForm
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
            this.singlePanel = new MatchingGame.DoubleBufferPanel();
            this.multiPanel = new MatchingGame.DoubleBufferPanel();
            this.singleNormalButton = new MatchingGame.DoubleBufferPanel();
            this.singleEasyButton = new MatchingGame.DoubleBufferPanel();
            this.multiEasyButton = new MatchingGame.DoubleBufferPanel();
            this.multiNormalButton = new MatchingGame.DoubleBufferPanel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backButton = new MatchingGame.DoubleBufferPanel();
            this.SuspendLayout();
            // 
            // singlePanel
            // 
            this.singlePanel.BackColor = System.Drawing.Color.Transparent;
            this.singlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.singlePanel.Location = new System.Drawing.Point(0, 0);
            this.singlePanel.Name = "singlePanel";
            this.singlePanel.Size = new System.Drawing.Size(200, 100);
            this.singlePanel.TabIndex = 0;
            // 
            // multiPanel
            // 
            this.multiPanel.BackColor = System.Drawing.Color.Transparent;
            this.multiPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.multiPanel.Location = new System.Drawing.Point(228, 0);
            this.multiPanel.Name = "multiPanel";
            this.multiPanel.Size = new System.Drawing.Size(200, 100);
            this.multiPanel.TabIndex = 0;
            // 
            // singleNormalButton
            // 
            this.singleNormalButton.BackColor = System.Drawing.Color.Transparent;
            this.singleNormalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.singleNormalButton.Location = new System.Drawing.Point(196, 203);
            this.singleNormalButton.Name = "singleNormalButton";
            this.singleNormalButton.Size = new System.Drawing.Size(300, 50);
            this.singleNormalButton.TabIndex = 1;
            this.singleNormalButton.Click += new System.EventHandler(this.singleNormalButton_Click);
            this.singleNormalButton.MouseEnter += new System.EventHandler(this.singleNormalButton_MouseEnter);
            this.singleNormalButton.MouseLeave += new System.EventHandler(this.singleNormalButton_MouseLeave);
            // 
            // singleEasyButton
            // 
            this.singleEasyButton.BackColor = System.Drawing.Color.Transparent;
            this.singleEasyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.singleEasyButton.Location = new System.Drawing.Point(196, 147);
            this.singleEasyButton.Name = "singleEasyButton";
            this.singleEasyButton.Size = new System.Drawing.Size(300, 50);
            this.singleEasyButton.TabIndex = 1;
            this.singleEasyButton.Click += new System.EventHandler(this.singleEasyButton_Click);
            this.singleEasyButton.MouseEnter += new System.EventHandler(this.singleEasyButton_MouseEnter);
            this.singleEasyButton.MouseLeave += new System.EventHandler(this.singleEasyButton_MouseLeave);
            // 
            // multiEasyButton
            // 
            this.multiEasyButton.BackColor = System.Drawing.Color.Transparent;
            this.multiEasyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.multiEasyButton.Location = new System.Drawing.Point(196, 259);
            this.multiEasyButton.Name = "multiEasyButton";
            this.multiEasyButton.Size = new System.Drawing.Size(300, 50);
            this.multiEasyButton.TabIndex = 1;
            this.multiEasyButton.Click += new System.EventHandler(this.multiEasyButton_Click);
            this.multiEasyButton.MouseEnter += new System.EventHandler(this.multiEasyButton_MouseEnter);
            this.multiEasyButton.MouseLeave += new System.EventHandler(this.multiEasyButton_MouseLeave);
            // 
            // multiNormalButton
            // 
            this.multiNormalButton.BackColor = System.Drawing.Color.Transparent;
            this.multiNormalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.multiNormalButton.Location = new System.Drawing.Point(196, 315);
            this.multiNormalButton.Name = "multiNormalButton";
            this.multiNormalButton.Size = new System.Drawing.Size(300, 50);
            this.multiNormalButton.TabIndex = 1;
            this.multiNormalButton.Click += new System.EventHandler(this.multiNormalButton_Click);
            this.multiNormalButton.MouseEnter += new System.EventHandler(this.multiNormalButton_MouseEnter);
            this.multiNormalButton.MouseLeave += new System.EventHandler(this.multiNormalButton_MouseLeave);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Location = new System.Drawing.Point(196, 371);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(300, 50);
            this.backButton.TabIndex = 1;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.multiNormalButton);
            this.Controls.Add(this.multiEasyButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.singleEasyButton);
            this.Controls.Add(this.singleNormalButton);
            this.Controls.Add(this.multiPanel);
            this.Controls.Add(this.singlePanel);
            this.DoubleBuffered = true;
            this.Name = "SelectForm";
            this.Text = "SelectForm";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private DoubleBufferPanel singlePanel;
        private DoubleBufferPanel multiPanel;
        private DoubleBufferPanel singleNormalButton;
        private DoubleBufferPanel singleEasyButton;
        private DoubleBufferPanel multiEasyButton;
        private DoubleBufferPanel multiNormalButton;
        private System.Windows.Forms.Timer timer;
        private DoubleBufferPanel backButton;
    }
}
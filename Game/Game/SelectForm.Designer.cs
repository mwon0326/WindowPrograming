namespace Game
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backButton = new Game.DoubleBufferPanel();
            this.multiPanel = new Game.DoubleBufferPanel();
            this.singlePanel = new Game.DoubleBufferPanel();
            this.multiNormalButton = new Game.DoubleBufferPanel();
            this.multiEasyButton = new Game.DoubleBufferPanel();
            this.singleNormalButton = new Game.DoubleBufferPanel();
            this.singleEasyButton = new Game.DoubleBufferPanel();
            this.SuspendLayout();
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
            this.backButton.Location = new System.Drawing.Point(249, 385);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(300, 50);
            this.backButton.TabIndex = 2;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            // 
            // multiPanel
            // 
            this.multiPanel.BackColor = System.Drawing.Color.Transparent;
            this.multiPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.multiPanel.Location = new System.Drawing.Point(308, 53);
            this.multiPanel.Name = "multiPanel";
            this.multiPanel.Size = new System.Drawing.Size(200, 100);
            this.multiPanel.TabIndex = 1;
            // 
            // singlePanel
            // 
            this.singlePanel.BackColor = System.Drawing.Color.Transparent;
            this.singlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.singlePanel.Location = new System.Drawing.Point(84, 53);
            this.singlePanel.Name = "singlePanel";
            this.singlePanel.Size = new System.Drawing.Size(200, 100);
            this.singlePanel.TabIndex = 1;
            // 
            // multiNormalButton
            // 
            this.multiNormalButton.BackColor = System.Drawing.Color.Transparent;
            this.multiNormalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.multiNormalButton.Location = new System.Drawing.Point(159, 322);
            this.multiNormalButton.Name = "multiNormalButton";
            this.multiNormalButton.Size = new System.Drawing.Size(300, 50);
            this.multiNormalButton.TabIndex = 0;
            this.multiNormalButton.Click += new System.EventHandler(this.multiNormalButton_Click);
            this.multiNormalButton.MouseEnter += new System.EventHandler(this.multiNormalButton_MouseEnter);
            this.multiNormalButton.MouseLeave += new System.EventHandler(this.multiNormalButton_MouseLeave);
            // 
            // multiEasyButton
            // 
            this.multiEasyButton.BackColor = System.Drawing.Color.Transparent;
            this.multiEasyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.multiEasyButton.Location = new System.Drawing.Point(159, 266);
            this.multiEasyButton.Name = "multiEasyButton";
            this.multiEasyButton.Size = new System.Drawing.Size(300, 50);
            this.multiEasyButton.TabIndex = 0;
            this.multiEasyButton.Click += new System.EventHandler(this.multiEasyButton_Click);
            this.multiEasyButton.MouseEnter += new System.EventHandler(this.multiEasyButton_MouseEnter);
            this.multiEasyButton.MouseLeave += new System.EventHandler(this.multiEasyButton_MouseLeave);
            // 
            // singleNormalButton
            // 
            this.singleNormalButton.BackColor = System.Drawing.Color.Transparent;
            this.singleNormalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.singleNormalButton.Location = new System.Drawing.Point(159, 210);
            this.singleNormalButton.Name = "singleNormalButton";
            this.singleNormalButton.Size = new System.Drawing.Size(300, 50);
            this.singleNormalButton.TabIndex = 0;
            this.singleNormalButton.Click += new System.EventHandler(this.singleNormalButton_Click);
            this.singleNormalButton.MouseEnter += new System.EventHandler(this.singleNormalButton_MouseEnter);
            this.singleNormalButton.MouseLeave += new System.EventHandler(this.singleNormalButton_MouseLeave);
            // 
            // singleEasyButton
            // 
            this.singleEasyButton.BackColor = System.Drawing.Color.Transparent;
            this.singleEasyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.singleEasyButton.Location = new System.Drawing.Point(159, 154);
            this.singleEasyButton.Name = "singleEasyButton";
            this.singleEasyButton.Size = new System.Drawing.Size(300, 50);
            this.singleEasyButton.TabIndex = 0;
            this.singleEasyButton.Click += new System.EventHandler(this.singleEasyButton_Click);
            this.singleEasyButton.MouseEnter += new System.EventHandler(this.singleEasyButton_MouseEnter);
            this.singleEasyButton.MouseLeave += new System.EventHandler(this.singleEasyButton_MouseLeave);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 501);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.multiPanel);
            this.Controls.Add(this.singlePanel);
            this.Controls.Add(this.multiNormalButton);
            this.Controls.Add(this.multiEasyButton);
            this.Controls.Add(this.singleNormalButton);
            this.Controls.Add(this.singleEasyButton);
            this.DoubleBuffered = true;
            this.Name = "SelectForm";
            this.Text = "모드 선택";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private DoubleBufferPanel singleEasyButton;
        private DoubleBufferPanel singleNormalButton;
        private DoubleBufferPanel multiEasyButton;
        private DoubleBufferPanel multiNormalButton;
        private DoubleBufferPanel singlePanel;
        private DoubleBufferPanel multiPanel;
        private DoubleBufferPanel backButton;
    }
}
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
            this.singleEasyButton = new Game.DoubleBufferPanel();
            this.singleNormalButton = new Game.DoubleBufferPanel();
            this.multiEasyButton = new Game.DoubleBufferPanel();
            this.multiNormalButton = new Game.DoubleBufferPanel();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // singleEasyButton
            // 
            this.singleEasyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.singleEasyButton.Location = new System.Drawing.Point(159, 154);
            this.singleEasyButton.Name = "singleEasyButton";
            this.singleEasyButton.Size = new System.Drawing.Size(200, 50);
            this.singleEasyButton.TabIndex = 0;
            // 
            // singleNormalButton
            // 
            this.singleNormalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.singleNormalButton.Location = new System.Drawing.Point(159, 210);
            this.singleNormalButton.Name = "singleNormalButton";
            this.singleNormalButton.Size = new System.Drawing.Size(200, 50);
            this.singleNormalButton.TabIndex = 0;
            // 
            // multiEasyButton
            // 
            this.multiEasyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.multiEasyButton.Location = new System.Drawing.Point(159, 266);
            this.multiEasyButton.Name = "multiEasyButton";
            this.multiEasyButton.Size = new System.Drawing.Size(200, 50);
            this.multiEasyButton.TabIndex = 0;
            // 
            // multiNormalButton
            // 
            this.multiNormalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.multiNormalButton.Location = new System.Drawing.Point(159, 322);
            this.multiNormalButton.Name = "multiNormalButton";
            this.multiNormalButton.Size = new System.Drawing.Size(200, 50);
            this.multiNormalButton.TabIndex = 0;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 501);
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
    }
}
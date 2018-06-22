namespace MatchingGame
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
            this.gamePan = new MatchingGame.DoubleBufferPanel();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.imageTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gamePan
            // 
            this.gamePan.AutoSize = true;
            this.gamePan.BackColor = System.Drawing.Color.Transparent;
            this.gamePan.Location = new System.Drawing.Point(57, 32);
            this.gamePan.Name = "gamePan";
            this.gamePan.Size = new System.Drawing.Size(457, 337);
            this.gamePan.TabIndex = 0;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scoreLabel.Location = new System.Drawing.Point(599, 53);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(134, 40);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "label1";
            // 
            // imageTime
            // 
            this.imageTime.Enabled = true;
            this.imageTime.Interval = 10;
            this.imageTime.Tick += new System.EventHandler(this.imageTime_Tick);
            // 
            // SingleGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gamePan);
            this.DoubleBuffered = true;
            this.Name = "SingleGameForm";
            this.Text = "SingleGameForm";
            this.Load += new System.EventHandler(this.SingleGameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SingleGameForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleBufferPanel gamePan;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer imageTime;
    }
}
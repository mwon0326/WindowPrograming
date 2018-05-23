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
            this.gamePan = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gamePan
            // 
            this.gamePan.AutoSize = true;
            this.gamePan.Location = new System.Drawing.Point(26, 66);
            this.gamePan.Name = "gamePan";
            this.gamePan.Size = new System.Drawing.Size(1071, 737);
            this.gamePan.TabIndex = 0;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // SingleGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 841);
            this.Controls.Add(this.gamePan);
            this.Name = "SingleGameForm";
            this.Text = "SingleEasyGameForm";
            this.Load += new System.EventHandler(this.SingleEasyGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gamePan;
        private System.Windows.Forms.Timer gameTimer;
    }
}
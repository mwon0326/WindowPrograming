namespace Game
{
    partial class MultiGameForm
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
            this.playerScore1 = new System.Windows.Forms.Label();
            this.playerScore2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gamePan
            // 
            this.gamePan.AutoSize = true;
            this.gamePan.Location = new System.Drawing.Point(26, 27);
            this.gamePan.Name = "gamePan";
            this.gamePan.Size = new System.Drawing.Size(592, 452);
            this.gamePan.TabIndex = 0;
            this.gamePan.TabStop = true;
            // 
            // playerScore1
            // 
            this.playerScore1.AutoSize = true;
            this.playerScore1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore1.Location = new System.Drawing.Point(939, 27);
            this.playerScore1.Name = "playerScore1";
            this.playerScore1.Size = new System.Drawing.Size(122, 49);
            this.playerScore1.TabIndex = 1;
            this.playerScore1.Text = "label1";
            // 
            // playerScore2
            // 
            this.playerScore2.AutoSize = true;
            this.playerScore2.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore2.Location = new System.Drawing.Point(939, 113);
            this.playerScore2.Name = "playerScore2";
            this.playerScore2.Size = new System.Drawing.Size(122, 49);
            this.playerScore2.TabIndex = 1;
            this.playerScore2.Text = "label1";
            // 
            // MultiGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1382, 494);
            this.Controls.Add(this.playerScore2);
            this.Controls.Add(this.playerScore1);
            this.Controls.Add(this.gamePan);
            this.Name = "MultiGameForm";
            this.Text = "MultiGameForm";
            this.Load += new System.EventHandler(this.MultiGameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MultiGameForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gamePan;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerScore1;
        private System.Windows.Forms.Label playerScore2;
    }
}
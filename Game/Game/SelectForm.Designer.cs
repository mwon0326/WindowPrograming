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
            this.easySButton = new System.Windows.Forms.Button();
            this.normalSButton = new System.Windows.Forms.Button();
            this.easyMButton = new System.Windows.Forms.Button();
            this.normalMButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // easySButton
            // 
            this.easySButton.Location = new System.Drawing.Point(50, 172);
            this.easySButton.Name = "easySButton";
            this.easySButton.Size = new System.Drawing.Size(155, 72);
            this.easySButton.TabIndex = 0;
            this.easySButton.UseVisualStyleBackColor = true;
            this.easySButton.Click += new System.EventHandler(this.easySButton_Click);
            // 
            // normalSButton
            // 
            this.normalSButton.Location = new System.Drawing.Point(50, 250);
            this.normalSButton.Name = "normalSButton";
            this.normalSButton.Size = new System.Drawing.Size(155, 72);
            this.normalSButton.TabIndex = 0;
            this.normalSButton.UseVisualStyleBackColor = true;
            this.normalSButton.Click += new System.EventHandler(this.normalSButton_Click);
            // 
            // easyMButton
            // 
            this.easyMButton.Location = new System.Drawing.Point(290, 172);
            this.easyMButton.Name = "easyMButton";
            this.easyMButton.Size = new System.Drawing.Size(155, 72);
            this.easyMButton.TabIndex = 0;
            this.easyMButton.UseVisualStyleBackColor = true;
            // 
            // normalMButton
            // 
            this.normalMButton.Location = new System.Drawing.Point(290, 250);
            this.normalMButton.Name = "normalMButton";
            this.normalMButton.Size = new System.Drawing.Size(155, 72);
            this.normalMButton.TabIndex = 0;
            this.normalMButton.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 501);
            this.Controls.Add(this.normalMButton);
            this.Controls.Add(this.normalSButton);
            this.Controls.Add(this.easyMButton);
            this.Controls.Add(this.easySButton);
            this.Name = "SelectForm";
            this.Text = "모드 선택";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button easySButton;
        private System.Windows.Forms.Button normalSButton;
        private System.Windows.Forms.Button easyMButton;
        private System.Windows.Forms.Button normalMButton;
    }
}
namespace _2017180010
{
    partial class MultiSelectForm
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
            this.Selectbutton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.RadioButton();
            this.normalButton = new System.Windows.Forms.RadioButton();
            this.easyButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Selectbutton
            // 
            this.Selectbutton.Location = new System.Drawing.Point(54, 174);
            this.Selectbutton.Name = "Selectbutton";
            this.Selectbutton.Size = new System.Drawing.Size(178, 39);
            this.Selectbutton.TabIndex = 5;
            this.Selectbutton.Text = "확인";
            this.Selectbutton.UseVisualStyleBackColor = true;
            this.Selectbutton.Click += new System.EventHandler(this.Selectbutton_Click);
            // 
            // hardButton
            // 
            this.hardButton.AutoSize = true;
            this.hardButton.Location = new System.Drawing.Point(50, 126);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(58, 19);
            this.hardButton.TabIndex = 2;
            this.hardButton.TabStop = true;
            this.hardButton.Text = "고급";
            this.hardButton.UseVisualStyleBackColor = true;
            // 
            // normalButton
            // 
            this.normalButton.AutoSize = true;
            this.normalButton.Location = new System.Drawing.Point(50, 82);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(58, 19);
            this.normalButton.TabIndex = 3;
            this.normalButton.TabStop = true;
            this.normalButton.Text = "중급";
            this.normalButton.UseVisualStyleBackColor = true;
            // 
            // easyButton
            // 
            this.easyButton.AutoSize = true;
            this.easyButton.Location = new System.Drawing.Point(50, 40);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(58, 19);
            this.easyButton.TabIndex = 4;
            this.easyButton.TabStop = true;
            this.easyButton.Text = "초급";
            this.easyButton.UseVisualStyleBackColor = true;
            // 
            // multi_SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.Selectbutton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.easyButton);
            this.Name = "multi_SelectForm";
            this.Text = "2인용 난이도";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Selectbutton;
        private System.Windows.Forms.RadioButton hardButton;
        private System.Windows.Forms.RadioButton normalButton;
        private System.Windows.Forms.RadioButton easyButton;
    }
}
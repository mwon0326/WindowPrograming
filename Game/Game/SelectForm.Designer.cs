﻿namespace Game
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
            this.singleEasyButton = new System.Windows.Forms.Panel();
            this.singleNormalButton = new System.Windows.Forms.Panel();
            this.multiEasyButton = new System.Windows.Forms.Panel();
            this.multiNormalButton = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // singleEasyButton
            // 
            this.singleEasyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.singleEasyButton.Location = new System.Drawing.Point(51, 172);
            this.singleEasyButton.Name = "singleEasyButton";
            this.singleEasyButton.Size = new System.Drawing.Size(154, 70);
            this.singleEasyButton.TabIndex = 1;
            this.singleEasyButton.Click += new System.EventHandler(this.singleEasyButton_Click);
            this.singleEasyButton.MouseEnter += new System.EventHandler(this.singleEasyButton_MouseEnter);
            this.singleEasyButton.MouseLeave += new System.EventHandler(this.singleEasyButton_MouseLeave);
            // 
            // singleNormalButton
            // 
            this.singleNormalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.singleNormalButton.Location = new System.Drawing.Point(51, 248);
            this.singleNormalButton.Name = "singleNormalButton";
            this.singleNormalButton.Size = new System.Drawing.Size(154, 70);
            this.singleNormalButton.TabIndex = 1;
            this.singleNormalButton.Click += new System.EventHandler(this.singleNormalButton_Click);
            this.singleNormalButton.MouseEnter += new System.EventHandler(this.singleNormalButton_MouseEnter);
            this.singleNormalButton.MouseLeave += new System.EventHandler(this.singleNormalButton_MouseLeave);
            // 
            // multiEasyButton
            // 
            this.multiEasyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.multiEasyButton.Location = new System.Drawing.Point(290, 172);
            this.multiEasyButton.Name = "multiEasyButton";
            this.multiEasyButton.Size = new System.Drawing.Size(154, 70);
            this.multiEasyButton.TabIndex = 1;
            this.multiEasyButton.Click += new System.EventHandler(this.multiEasyButton_Click);
            this.multiEasyButton.MouseEnter += new System.EventHandler(this.multiEasyButton_MouseEnter);
            this.multiEasyButton.MouseLeave += new System.EventHandler(this.multiEasyButton_MouseLeave);
            // 
            // multiNormalButton
            // 
            this.multiNormalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.multiNormalButton.Location = new System.Drawing.Point(290, 248);
            this.multiNormalButton.Name = "multiNormalButton";
            this.multiNormalButton.Size = new System.Drawing.Size(154, 70);
            this.multiNormalButton.TabIndex = 1;
            this.multiNormalButton.Click += new System.EventHandler(this.multiNormalButton_Click);
            this.multiNormalButton.MouseEnter += new System.EventHandler(this.multiNormalButton_MouseEnter);
            this.multiNormalButton.MouseLeave += new System.EventHandler(this.multiNormalButton_MouseLeave);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 501);
            this.Controls.Add(this.multiNormalButton);
            this.Controls.Add(this.singleNormalButton);
            this.Controls.Add(this.multiEasyButton);
            this.Controls.Add(this.singleEasyButton);
            this.Name = "SelectForm";
            this.Text = "모드 선택";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel singleEasyButton;
        private System.Windows.Forms.Panel singleNormalButton;
        private System.Windows.Forms.Panel multiEasyButton;
        private System.Windows.Forms.Panel multiNormalButton;
    }
}
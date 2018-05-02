namespace _2017180010
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.singleButton = new System.Windows.Forms.Button();
            this.mutiButton = new System.Windows.Forms.Button();
            this.imageButton = new System.Windows.Forms.Button();
            this.highScoreButton = new System.Windows.Forms.Button();
            this.openImageFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // singleButton
            // 
            this.singleButton.Location = new System.Drawing.Point(29, 332);
            this.singleButton.Name = "singleButton";
            this.singleButton.Size = new System.Drawing.Size(176, 57);
            this.singleButton.TabIndex = 0;
            this.singleButton.Text = "1인용";
            this.singleButton.UseVisualStyleBackColor = true;
            this.singleButton.Click += new System.EventHandler(this.singleButton_Click);
            // 
            // mutiButton
            // 
            this.mutiButton.Location = new System.Drawing.Point(232, 332);
            this.mutiButton.Name = "mutiButton";
            this.mutiButton.Size = new System.Drawing.Size(176, 57);
            this.mutiButton.TabIndex = 0;
            this.mutiButton.Text = "2인용";
            this.mutiButton.UseVisualStyleBackColor = true;
            this.mutiButton.Click += new System.EventHandler(this.mutiButton_Click);
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(29, 410);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(176, 57);
            this.imageButton.TabIndex = 0;
            this.imageButton.Text = "이미지 선택";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // highScoreButton
            // 
            this.highScoreButton.Location = new System.Drawing.Point(232, 410);
            this.highScoreButton.Name = "highScoreButton";
            this.highScoreButton.Size = new System.Drawing.Size(176, 57);
            this.highScoreButton.TabIndex = 0;
            this.highScoreButton.Text = "하이스코어";
            this.highScoreButton.UseVisualStyleBackColor = true;
            this.highScoreButton.Click += new System.EventHandler(this.highScoreButton_Click);
            // 
            // openImageFile
            // 
            this.openImageFile.FileName = "openImageFile";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 516);
            this.Controls.Add(this.mutiButton);
            this.Controls.Add(this.highScoreButton);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.singleButton);
            this.Name = "MainForm";
            this.Text = "짝맞추기 게임";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button singleButton;
        private System.Windows.Forms.Button mutiButton;
        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.Button highScoreButton;
        private System.Windows.Forms.OpenFileDialog openImageFile;
    }
}


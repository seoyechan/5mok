namespace Client
{
    partial class MenuForm
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.singleplay = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singleplay
            // 
            this.singleplay.Location = new System.Drawing.Point(191, 66);
            this.singleplay.Name = "singleplay";
            this.singleplay.Size = new System.Drawing.Size(97, 59);
            this.singleplay.TabIndex = 0;
            this.singleplay.Text = "혼자하기";
            this.singleplay.UseVisualStyleBackColor = true;
            this.singleplay.Click += new System.EventHandler(this.singleplay_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(191, 146);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(97, 59);
            this.exit.TabIndex = 1;
            this.exit.Text = "종료하기";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.singleplay);
            this.Name = "MenuForm";
            this.Text = "5mok";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button singleplay;
        private System.Windows.Forms.Button exit;

    }
}


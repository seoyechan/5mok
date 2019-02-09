namespace Client
{
    partial class board_bk
    {
        private System.ComponentModel.IContainer components = null;
        
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
            this.boardpicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boardpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // boardpicture
            // 
            this.boardpicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.boardpicture.Location = new System.Drawing.Point(12, 12);
            this.boardpicture.Name = "boardpicture";
            this.boardpicture.Size = new System.Drawing.Size(500, 500);
            this.boardpicture.TabIndex = 0;
            this.boardpicture.TabStop = false;
            this.boardpicture.Paint += new System.Windows.Forms.PaintEventHandler(this.boardpicture_Paint);
            this.boardpicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boardpicture_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "게임시작";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(535, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "게임을 시작해주세요.";
            // 
            // board_bk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boardpicture);
            this.Name = "board_bk";
            this.Text = "SinglePlayForm";
            ((System.ComponentModel.ISupportInitialize)(this.boardpicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox boardpicture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
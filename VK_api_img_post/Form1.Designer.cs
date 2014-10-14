namespace VK_api_img_post
{
    partial class Form1
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
            this.load_btn = new System.Windows.Forms.Button();
            this.load_pic_btn = new System.Windows.Forms.Button();
            this.start_bnt = new System.Windows.Forms.Button();
            this.fromSleep_tb = new System.Windows.Forms.TextBox();
            this.toSleep_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(12, 12);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(173, 23);
            this.load_btn.TabIndex = 0;
            this.load_btn.Text = "Загрузить пользователей";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // load_pic_btn
            // 
            this.load_pic_btn.Location = new System.Drawing.Point(12, 55);
            this.load_pic_btn.Name = "load_pic_btn";
            this.load_pic_btn.Size = new System.Drawing.Size(173, 23);
            this.load_pic_btn.TabIndex = 1;
            this.load_pic_btn.Text = "Загрузить картинку";
            this.load_pic_btn.UseVisualStyleBackColor = true;
            // 
            // start_bnt
            // 
            this.start_bnt.Location = new System.Drawing.Point(12, 132);
            this.start_bnt.Name = "start_bnt";
            this.start_bnt.Size = new System.Drawing.Size(75, 23);
            this.start_bnt.TabIndex = 2;
            this.start_bnt.Text = "Go";
            this.start_bnt.UseVisualStyleBackColor = true;
            // 
            // fromSleep_tb
            // 
            this.fromSleep_tb.Location = new System.Drawing.Point(36, 94);
            this.fromSleep_tb.Name = "fromSleep_tb";
            this.fromSleep_tb.Size = new System.Drawing.Size(34, 20);
            this.fromSleep_tb.TabIndex = 3;
            // 
            // toSleep_tb
            // 
            this.toSleep_tb.Location = new System.Drawing.Point(107, 94);
            this.toSleep_tb.Name = "toSleep_tb";
            this.toSleep_tb.Size = new System.Drawing.Size(34, 20);
            this.toSleep_tb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "- до";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toSleep_tb);
            this.Controls.Add(this.fromSleep_tb);
            this.Controls.Add(this.start_bnt);
            this.Controls.Add(this.load_pic_btn);
            this.Controls.Add(this.load_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button load_pic_btn;
        private System.Windows.Forms.Button start_bnt;
        private System.Windows.Forms.TextBox fromSleep_tb;
        private System.Windows.Forms.TextBox toSleep_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


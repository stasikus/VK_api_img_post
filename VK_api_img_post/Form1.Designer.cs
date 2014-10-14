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
            this.appID_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.validUser_lbl = new System.Windows.Forms.Label();
            this.notValidUser_lbl = new System.Windows.Forms.Label();
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
            this.load_pic_btn.Location = new System.Drawing.Point(12, 73);
            this.load_pic_btn.Name = "load_pic_btn";
            this.load_pic_btn.Size = new System.Drawing.Size(173, 23);
            this.load_pic_btn.TabIndex = 1;
            this.load_pic_btn.Text = "Загрузить картинку";
            this.load_pic_btn.UseVisualStyleBackColor = true;
            // 
            // start_bnt
            // 
            this.start_bnt.Location = new System.Drawing.Point(12, 171);
            this.start_bnt.Name = "start_bnt";
            this.start_bnt.Size = new System.Drawing.Size(75, 23);
            this.start_bnt.TabIndex = 2;
            this.start_bnt.Text = "Go";
            this.start_bnt.UseVisualStyleBackColor = true;
            this.start_bnt.Click += new System.EventHandler(this.start_bnt_Click);
            // 
            // fromSleep_tb
            // 
            this.fromSleep_tb.Location = new System.Drawing.Point(36, 133);
            this.fromSleep_tb.Name = "fromSleep_tb";
            this.fromSleep_tb.Size = new System.Drawing.Size(34, 20);
            this.fromSleep_tb.TabIndex = 3;
            // 
            // toSleep_tb
            // 
            this.toSleep_tb.Location = new System.Drawing.Point(107, 133);
            this.toSleep_tb.Name = "toSleep_tb";
            this.toSleep_tb.Size = new System.Drawing.Size(34, 20);
            this.toSleep_tb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "- до";
            // 
            // appID_tb
            // 
            this.appID_tb.Location = new System.Drawing.Point(101, 102);
            this.appID_tb.Name = "appID_tb";
            this.appID_tb.Size = new System.Drawing.Size(100, 20);
            this.appID_tb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID приложения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Валидных юзеров:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Не валидных юзеров:";
            // 
            // validUser_lbl
            // 
            this.validUser_lbl.AutoSize = true;
            this.validUser_lbl.Location = new System.Drawing.Point(115, 39);
            this.validUser_lbl.Name = "validUser_lbl";
            this.validUser_lbl.Size = new System.Drawing.Size(13, 13);
            this.validUser_lbl.TabIndex = 11;
            this.validUser_lbl.Text = "0";
            // 
            // notValidUser_lbl
            // 
            this.notValidUser_lbl.AutoSize = true;
            this.notValidUser_lbl.Location = new System.Drawing.Point(130, 52);
            this.notValidUser_lbl.Name = "notValidUser_lbl";
            this.notValidUser_lbl.Size = new System.Drawing.Size(13, 13);
            this.notValidUser_lbl.TabIndex = 12;
            this.notValidUser_lbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.notValidUser_lbl);
            this.Controls.Add(this.validUser_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.appID_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toSleep_tb);
            this.Controls.Add(this.fromSleep_tb);
            this.Controls.Add(this.start_bnt);
            this.Controls.Add(this.load_pic_btn);
            this.Controls.Add(this.load_btn);
            this.Name = "Form1";
            this.Text = "VK Img Sender";
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
        private System.Windows.Forms.TextBox appID_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label validUser_lbl;
        private System.Windows.Forms.Label notValidUser_lbl;
    }
}


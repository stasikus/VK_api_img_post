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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.notSendMsg_lbl = new System.Windows.Forms.Label();
            this.sendMsg_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msgText_tb = new System.Windows.Forms.TextBox();
            this.loadedPic_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.check_balance_btn = new System.Windows.Forms.Button();
            this.balance_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.antigateKey_TB = new System.Windows.Forms.TextBox();
            this.captcha_antigate = new System.Windows.Forms.RadioButton();
            this.captcha_manual = new System.Windows.Forms.RadioButton();
            this.INFO = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.INFO.SuspendLayout();
            this.SuspendLayout();
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(12, 33);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(230, 23);
            this.load_btn.TabIndex = 0;
            this.load_btn.Text = "Загрузить пользователей";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // load_pic_btn
            // 
            this.load_pic_btn.Location = new System.Drawing.Point(12, 91);
            this.load_pic_btn.Name = "load_pic_btn";
            this.load_pic_btn.Size = new System.Drawing.Size(230, 23);
            this.load_pic_btn.TabIndex = 1;
            this.load_pic_btn.Text = "Загрузить картинку";
            this.load_pic_btn.UseVisualStyleBackColor = true;
            this.load_pic_btn.Click += new System.EventHandler(this.load_pic_btn_Click);
            // 
            // start_bnt
            // 
            this.start_bnt.Location = new System.Drawing.Point(15, 457);
            this.start_bnt.Name = "start_bnt";
            this.start_bnt.Size = new System.Drawing.Size(227, 23);
            this.start_bnt.TabIndex = 2;
            this.start_bnt.Text = "Go";
            this.start_bnt.UseVisualStyleBackColor = true;
            this.start_bnt.Click += new System.EventHandler(this.start_bnt_Click);
            // 
            // fromSleep_tb
            // 
            this.fromSleep_tb.Location = new System.Drawing.Point(106, 144);
            this.fromSleep_tb.Name = "fromSleep_tb";
            this.fromSleep_tb.Size = new System.Drawing.Size(40, 20);
            this.fromSleep_tb.TabIndex = 3;
            // 
            // toSleep_tb
            // 
            this.toSleep_tb.Location = new System.Drawing.Point(183, 144);
            this.toSleep_tb.Name = "toSleep_tb";
            this.toSleep_tb.Size = new System.Drawing.Size(40, 20);
            this.toSleep_tb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Задержка от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "- до";
            // 
            // appID_tb
            // 
            this.appID_tb.Location = new System.Drawing.Point(122, 6);
            this.appID_tb.Name = "appID_tb";
            this.appID_tb.Size = new System.Drawing.Size(100, 20);
            this.appID_tb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID приложения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Валидных юзеров:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Не валидных юзеров:";
            // 
            // validUser_lbl
            // 
            this.validUser_lbl.AutoSize = true;
            this.validUser_lbl.Location = new System.Drawing.Point(115, 61);
            this.validUser_lbl.Name = "validUser_lbl";
            this.validUser_lbl.Size = new System.Drawing.Size(13, 13);
            this.validUser_lbl.TabIndex = 11;
            this.validUser_lbl.Text = "0";
            // 
            // notValidUser_lbl
            // 
            this.notValidUser_lbl.AutoSize = true;
            this.notValidUser_lbl.Location = new System.Drawing.Point(130, 74);
            this.notValidUser_lbl.Name = "notValidUser_lbl";
            this.notValidUser_lbl.Size = new System.Drawing.Size(13, 13);
            this.notValidUser_lbl.TabIndex = 12;
            this.notValidUser_lbl.Text = "0";
            // 
            // notSendMsg_lbl
            // 
            this.notSendMsg_lbl.AutoSize = true;
            this.notSendMsg_lbl.Location = new System.Drawing.Point(175, 503);
            this.notSendMsg_lbl.Name = "notSendMsg_lbl";
            this.notSendMsg_lbl.Size = new System.Drawing.Size(13, 13);
            this.notSendMsg_lbl.TabIndex = 16;
            this.notSendMsg_lbl.Text = "0";
            // 
            // sendMsg_lbl
            // 
            this.sendMsg_lbl.AutoSize = true;
            this.sendMsg_lbl.Location = new System.Drawing.Point(157, 490);
            this.sendMsg_lbl.Name = "sendMsg_lbl";
            this.sendMsg_lbl.Size = new System.Drawing.Size(13, 13);
            this.sendMsg_lbl.TabIndex = 15;
            this.sendMsg_lbl.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Не отправленных сообщений:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Отправленных сообщений:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msgText_tb);
            this.groupBox1.Location = new System.Drawing.Point(12, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 131);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сообщение";
            // 
            // msgText_tb
            // 
            this.msgText_tb.Location = new System.Drawing.Point(3, 12);
            this.msgText_tb.Multiline = true;
            this.msgText_tb.Name = "msgText_tb";
            this.msgText_tb.Size = new System.Drawing.Size(224, 116);
            this.msgText_tb.TabIndex = 18;
            // 
            // loadedPic_lbl
            // 
            this.loadedPic_lbl.AutoSize = true;
            this.loadedPic_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadedPic_lbl.Location = new System.Drawing.Point(126, 120);
            this.loadedPic_lbl.Name = "loadedPic_lbl";
            this.loadedPic_lbl.Size = new System.Drawing.Size(72, 13);
            this.loadedPic_lbl.TabIndex = 19;
            this.loadedPic_lbl.Text = "не выбранно";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Выбранная картинка:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.check_balance_btn);
            this.groupBox2.Controls.Add(this.balance_lbl);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.antigateKey_TB);
            this.groupBox2.Controls.Add(this.captcha_antigate);
            this.groupBox2.Controls.Add(this.captcha_manual);
            this.groupBox2.Location = new System.Drawing.Point(14, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 139);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Капча";
            // 
            // check_balance_btn
            // 
            this.check_balance_btn.Location = new System.Drawing.Point(147, 110);
            this.check_balance_btn.Name = "check_balance_btn";
            this.check_balance_btn.Size = new System.Drawing.Size(75, 23);
            this.check_balance_btn.TabIndex = 17;
            this.check_balance_btn.Text = "Проверить";
            this.check_balance_btn.UseVisualStyleBackColor = true;
            this.check_balance_btn.Click += new System.EventHandler(this.check_balance_btn_Click);
            // 
            // balance_lbl
            // 
            this.balance_lbl.AutoSize = true;
            this.balance_lbl.Location = new System.Drawing.Point(48, 116);
            this.balance_lbl.Name = "balance_lbl";
            this.balance_lbl.Size = new System.Drawing.Size(13, 13);
            this.balance_lbl.TabIndex = 16;
            this.balance_lbl.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Баланс:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ключ Antigate";
            // 
            // antigateKey_TB
            // 
            this.antigateKey_TB.Location = new System.Drawing.Point(6, 86);
            this.antigateKey_TB.Name = "antigateKey_TB";
            this.antigateKey_TB.Size = new System.Drawing.Size(216, 20);
            this.antigateKey_TB.TabIndex = 2;
            // 
            // captcha_antigate
            // 
            this.captcha_antigate.AutoSize = true;
            this.captcha_antigate.Location = new System.Drawing.Point(6, 39);
            this.captcha_antigate.Name = "captcha_antigate";
            this.captcha_antigate.Size = new System.Drawing.Size(64, 17);
            this.captcha_antigate.TabIndex = 1;
            this.captcha_antigate.Text = "Antigate";
            this.captcha_antigate.UseVisualStyleBackColor = true;
            // 
            // captcha_manual
            // 
            this.captcha_manual.AutoSize = true;
            this.captcha_manual.Checked = true;
            this.captcha_manual.Location = new System.Drawing.Point(6, 18);
            this.captcha_manual.Name = "captcha_manual";
            this.captcha_manual.Size = new System.Drawing.Size(138, 17);
            this.captcha_manual.TabIndex = 0;
            this.captcha_manual.TabStop = true;
            this.captcha_manual.Text = "Вводить капчу руками";
            this.captcha_manual.UseVisualStyleBackColor = true;
            this.captcha_manual.CheckedChanged += new System.EventHandler(this.captcha_manual_CheckedChanged);
            // 
            // INFO
            // 
            this.INFO.Controls.Add(this.label11);
            this.INFO.Location = new System.Drawing.Point(12, 522);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(230, 53);
            this.INFO.TabIndex = 21;
            this.INFO.TabStop = false;
            this.INFO.Text = "INFO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.OrangeRed;
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "skype: wmwork   |   ICQ: 216 871 447";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 582);
            this.Controls.Add(this.INFO);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.loadedPic_lbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.notSendMsg_lbl);
            this.Controls.Add(this.sendMsg_lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(270, 620);
            this.MinimumSize = new System.Drawing.Size(270, 620);
            this.Name = "Form1";
            this.Text = "VK Img Sender";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.INFO.ResumeLayout(false);
            this.INFO.PerformLayout();
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
        private System.Windows.Forms.Label notSendMsg_lbl;
        private System.Windows.Forms.Label sendMsg_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox msgText_tb;
        private System.Windows.Forms.Label loadedPic_lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button check_balance_btn;
        private System.Windows.Forms.Label balance_lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox antigateKey_TB;
        private System.Windows.Forms.RadioButton captcha_antigate;
        private System.Windows.Forms.RadioButton captcha_manual;
        private System.Windows.Forms.GroupBox INFO;
        private System.Windows.Forms.Label label11;
    }
}


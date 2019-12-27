namespace MARC
{
    partial class LogIn
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_box_eye = new System.Windows.Forms.PictureBox();
            this.txt_box_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_log_in = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.link_label_sign_up = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_box_email = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_eye)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_box_password);
            this.panel2.Controls.Add(this.pic_box_eye);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_log_in);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.link_label_sign_up);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_box_email);
            this.panel2.Location = new System.Drawing.Point(257, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 325);
            this.panel2.TabIndex = 10;
            // 
            // pic_box_eye
            // 
            this.pic_box_eye.Image = ((System.Drawing.Image)(resources.GetObject("pic_box_eye.Image")));
            this.pic_box_eye.Location = new System.Drawing.Point(309, 182);
            this.pic_box_eye.Name = "pic_box_eye";
            this.pic_box_eye.Size = new System.Drawing.Size(20, 20);
            this.pic_box_eye.TabIndex = 4;
            this.pic_box_eye.TabStop = false;
            this.pic_box_eye.MouseEnter += new System.EventHandler(this.pic_box_eye_MouseEnter);
            this.pic_box_eye.MouseLeave += new System.EventHandler(this.pic_box_eye_MouseLeave);
            // 
            // txt_box_password
            // 
            this.txt_box_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txt_box_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_box_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_box_password.Location = new System.Drawing.Point(127, 182);
            this.txt_box_password.Name = "txt_box_password";
            this.txt_box_password.PasswordChar = '●';
            this.txt_box_password.Size = new System.Drawing.Size(176, 20);
            this.txt_box_password.TabIndex = 3;
            this.txt_box_password.Click += new System.EventHandler(this.txt_box_password_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label4.Location = new System.Drawing.Point(7, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 106);
            this.label4.TabIndex = 9;
            this.label4.Text = "LOG IN";
            // 
            // btn_log_in
            // 
            this.btn_log_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_log_in.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_log_in.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_log_in.Location = new System.Drawing.Point(73, 208);
            this.btn_log_in.Name = "btn_log_in";
            this.btn_log_in.Size = new System.Drawing.Size(230, 26);
            this.btn_log_in.TabIndex = 4;
            this.btn_log_in.Text = "Log In";
            this.btn_log_in.UseVisualStyleBackColor = false;
            this.btn_log_in.Click += new System.EventHandler(this.btn_log_in_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(70, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Mail";
            // 
            // link_label_sign_up
            // 
            this.link_label_sign_up.ActiveLinkColor = System.Drawing.Color.Red;
            this.link_label_sign_up.AutoSize = true;
            this.link_label_sign_up.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.link_label_sign_up.Location = new System.Drawing.Point(112, 237);
            this.link_label_sign_up.Name = "link_label_sign_up";
            this.link_label_sign_up.Size = new System.Drawing.Size(145, 13);
            this.link_label_sign_up.TabIndex = 5;
            this.link_label_sign_up.TabStop = true;
            this.link_label_sign_up.Text = "You don\'t have an account ?";
            this.link_label_sign_up.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_label_sign_up_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label2.Location = new System.Drawing.Point(70, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txt_box_email
            // 
            this.txt_box_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.txt_box_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_box_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_box_email.Location = new System.Drawing.Point(127, 159);
            this.txt_box_email.Name = "txt_box_email";
            this.txt_box_email.Size = new System.Drawing.Size(176, 20);
            this.txt_box_email.TabIndex = 2;
            this.txt_box_email.Text = "@marun.edu";
            this.txt_box_email.Click += new System.EventHandler(this.txt_box_email_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.panel2);
            this.Name = "LogIn";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_eye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_box_eye;
        private System.Windows.Forms.TextBox txt_box_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_log_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_label_sign_up;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_box_email;
    }
}

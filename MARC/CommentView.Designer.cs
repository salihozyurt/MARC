namespace MARC
{
    partial class CommentView
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
            this.cmb_box_ref_user = new System.Windows.Forms.ComboBox();
            this.btn_send_comment = new System.Windows.Forms.Button();
            this.txt_box_comment = new System.Windows.Forms.TextBox();
            CommentView.flow_panel_container = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // cmb_box_ref_user
            // 
            this.cmb_box_ref_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cmb_box_ref_user.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_box_ref_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.cmb_box_ref_user.FormattingEnabled = true;
            this.cmb_box_ref_user.ItemHeight = 13;
            this.cmb_box_ref_user.Items.AddRange(new object[] {
            "None"});
            this.cmb_box_ref_user.Location = new System.Drawing.Point(442, 37);
            this.cmb_box_ref_user.Name = "cmb_box_ref_user";
            this.cmb_box_ref_user.Size = new System.Drawing.Size(230, 21);
            this.cmb_box_ref_user.TabIndex = 2;
            // 
            // btn_send_comment
            // 
            this.btn_send_comment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_send_comment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_send_comment.Location = new System.Drawing.Point(442, 3);
            this.btn_send_comment.Name = "btn_send_comment";
            this.btn_send_comment.Size = new System.Drawing.Size(230, 28);
            this.btn_send_comment.TabIndex = 1;
            this.btn_send_comment.Text = "Send Comment";
            this.btn_send_comment.UseVisualStyleBackColor = true;
            this.btn_send_comment.Click += new System.EventHandler(this.btn_send_comment_Click);
            // 
            // txt_box_comment
            // 
            this.txt_box_comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txt_box_comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_box_comment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_box_comment.Location = new System.Drawing.Point(3, 3);
            this.txt_box_comment.MaxLength = 255;
            this.txt_box_comment.Multiline = true;
            this.txt_box_comment.Name = "txt_box_comment";
            this.txt_box_comment.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_box_comment.Size = new System.Drawing.Size(433, 55);
            this.txt_box_comment.TabIndex = 0;
            // 
            // flow_panel_container
            // 
            CommentView.flow_panel_container.AutoScroll = true;
            CommentView.flow_panel_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            CommentView.flow_panel_container.Location = new System.Drawing.Point(3, 64);
            CommentView.flow_panel_container.Name = "flow_panel_container";
            CommentView.flow_panel_container.Size = new System.Drawing.Size(669, 230);
            CommentView.flow_panel_container.TabIndex = 3;
            // 
            // CommentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Controls.Add(CommentView.flow_panel_container);
            this.Controls.Add(this.txt_box_comment);
            this.Controls.Add(this.btn_send_comment);
            this.Controls.Add(this.cmb_box_ref_user);
            this.Name = "CommentView";
            this.Size = new System.Drawing.Size(675, 294);
            this.Load += new System.EventHandler(this.CommentView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.ComboBox cmb_box_ref_user;
        private System.Windows.Forms.Button btn_send_comment;
        private System.Windows.Forms.TextBox txt_box_comment;
        private static System.Windows.Forms.FlowLayoutPanel flow_panel_container;
    }
}

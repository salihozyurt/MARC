namespace MARC
{
    partial class AnnouncementView
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
            this.lbl_node_title = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_creation_date = new System.Windows.Forms.Label();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_node_type = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            AnnouncementView.pnl_comment = new System.Windows.Forms.Panel();
            this.pnl_left.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_node_title
            // 
            this.lbl_node_title.AutoSize = true;
            this.lbl_node_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_node_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lbl_node_title.Location = new System.Drawing.Point(-1, 0);
            this.lbl_node_title.Name = "lbl_node_title";
            this.lbl_node_title.Size = new System.Drawing.Size(90, 20);
            this.lbl_node_title.TabIndex = 5;
            this.lbl_node_title.Text = "Node Title";
            // 
            // lbl_description
            // 
            this.lbl_description.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lbl_description.Location = new System.Drawing.Point(0, 31);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(494, 113);
            this.lbl_description.TabIndex = 6;
            this.lbl_description.Text = "Node Description";
            // 
            // lbl_creation_date
            // 
            this.lbl_creation_date.AutoSize = true;
            this.lbl_creation_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_creation_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lbl_creation_date.Location = new System.Drawing.Point(376, 0);
            this.lbl_creation_date.Name = "lbl_creation_date";
            this.lbl_creation_date.Size = new System.Drawing.Size(118, 20);
            this.lbl_creation_date.TabIndex = 7;
            this.lbl_creation_date.Text = "Creation date";
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
            this.pnl_left.Controls.Add(this.btn_back);
            this.pnl_left.Controls.Add(this.lbl_node_type);
            this.pnl_left.Location = new System.Drawing.Point(3, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(172, 147);
            this.pnl_left.TabIndex = 8;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_back.Location = new System.Drawing.Point(0, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(172, 28);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_node_type
            // 
            this.lbl_node_type.AutoSize = true;
            this.lbl_node_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_node_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_node_type.Location = new System.Drawing.Point(3, 64);
            this.lbl_node_type.Name = "lbl_node_type";
            this.lbl_node_type.Size = new System.Drawing.Size(130, 24);
            this.lbl_node_type.TabIndex = 0;
            this.lbl_node_type.Text = "Lecture Note";
            // 
            // pnl_header
            // 
            this.pnl_header.AutoScroll = true;
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pnl_header.Controls.Add(this.lbl_description);
            this.pnl_header.Controls.Add(this.lbl_node_title);
            this.pnl_header.Controls.Add(this.lbl_creation_date);
            this.pnl_header.Location = new System.Drawing.Point(178, 3);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(494, 144);
            this.pnl_header.TabIndex = 9;
            // 
            // pnl_comment
            // 
            AnnouncementView.pnl_comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            AnnouncementView.pnl_comment.Dock = System.Windows.Forms.DockStyle.Bottom;
            AnnouncementView.pnl_comment.Location = new System.Drawing.Point(0, 153);
            AnnouncementView.pnl_comment.Name = "pnl_comment";
            AnnouncementView.pnl_comment.Size = new System.Drawing.Size(675, 294);
            AnnouncementView.pnl_comment.TabIndex = 10;
            // 
            // AnnouncementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(AnnouncementView.pnl_comment);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_left);
            this.Name = "AnnouncementView";
            this.Size = new System.Drawing.Size(675, 447);
            this.Load += new System.EventHandler(this.AnnouncementView_Load);
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_node_title;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_creation_date;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Label lbl_node_type;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_back;
        private static System.Windows.Forms.Panel pnl_comment;
    }
}

namespace MARC
{
    partial class AssignmentView
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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_node_title = new System.Windows.Forms.Label();
            this.btn_upload = new System.Windows.Forms.Button();
            this.lbl_creation_date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_node_type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_end_date = new System.Windows.Forms.Label();
            this.lbl_iscomplated = new System.Windows.Forms.Label();
            this.btn_look_complated = new System.Windows.Forms.Button();
            this.pnl_header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.AutoScroll = true;
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pnl_header.Controls.Add(this.btn_look_complated);
            this.pnl_header.Controls.Add(this.lbl_iscomplated);
            this.pnl_header.Controls.Add(this.lbl_end_date);
            this.pnl_header.Controls.Add(this.label1);
            this.pnl_header.Controls.Add(this.lbl_description);
            this.pnl_header.Controls.Add(this.lbl_node_title);
            this.pnl_header.Controls.Add(this.btn_upload);
            this.pnl_header.Controls.Add(this.lbl_creation_date);
            this.pnl_header.Location = new System.Drawing.Point(178, 3);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(494, 144);
            this.pnl_header.TabIndex = 11;
            // 
            // lbl_description
            // 
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lbl_description.Location = new System.Drawing.Point(3, 31);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(374, 113);
            this.lbl_description.TabIndex = 6;
            this.lbl_description.Text = "Node Description";
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
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_upload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_upload.Location = new System.Drawing.Point(380, 94);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(111, 47);
            this.btn_upload.TabIndex = 3;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.lbl_node_type);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 144);
            this.panel1.TabIndex = 12;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
            this.label1.Location = new System.Drawing.Point(383, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Deadline";
            // 
            // lbl_end_date
            // 
            this.lbl_end_date.AutoSize = true;
            this.lbl_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_end_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
            this.lbl_end_date.Location = new System.Drawing.Point(383, 51);
            this.lbl_end_date.Name = "lbl_end_date";
            this.lbl_end_date.Size = new System.Drawing.Size(64, 16);
            this.lbl_end_date.TabIndex = 9;
            this.lbl_end_date.Text = "End Date";
            // 
            // lbl_iscomplated
            // 
            this.lbl_iscomplated.AutoSize = true;
            this.lbl_iscomplated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_iscomplated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
            this.lbl_iscomplated.Location = new System.Drawing.Point(383, 71);
            this.lbl_iscomplated.Name = "lbl_iscomplated";
            this.lbl_iscomplated.Size = new System.Drawing.Size(98, 16);
            this.lbl_iscomplated.TabIndex = 10;
            this.lbl_iscomplated.Text = "Not Complated";
            // 
            // btn_look_complated
            // 
            this.btn_look_complated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_look_complated.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_look_complated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_look_complated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_look_complated.Location = new System.Drawing.Point(380, 94);
            this.btn_look_complated.Name = "btn_look_complated";
            this.btn_look_complated.Size = new System.Drawing.Size(111, 47);
            this.btn_look_complated.TabIndex = 11;
            this.btn_look_complated.Text = "Look Complated";
            this.btn_look_complated.UseVisualStyleBackColor = false;
            this.btn_look_complated.Visible = false;
            this.btn_look_complated.Click += new System.EventHandler(this.btn_look_complated_Click);
            // 
            // AssignmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_header);
            this.Name = "AssignmentView";
            this.Size = new System.Drawing.Size(675, 447);
            this.Load += new System.EventHandler(this.AssignmentView_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_node_title;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label lbl_creation_date;
        private System.Windows.Forms.Label lbl_end_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_node_type;
        private System.Windows.Forms.Label lbl_iscomplated;
        private System.Windows.Forms.Button btn_look_complated;
    }
}

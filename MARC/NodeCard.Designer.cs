namespace MARC
{
    partial class NodeCard
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
            this.pnl_left = new System.Windows.Forms.Panel();
            this.lbl_node_type = new System.Windows.Forms.Label();
            this.btn_view = new System.Windows.Forms.Button();
            this.lbl_node_title = new System.Windows.Forms.Label();
            this.lbl_creation_date = new System.Windows.Forms.Label();
            this.pnl_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
            this.pnl_left.Controls.Add(this.lbl_node_type);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(156, 148);
            this.pnl_left.TabIndex = 1;
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
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_view.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_view.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_view.Location = new System.Drawing.Point(498, 0);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(162, 148);
            this.btn_view.TabIndex = 3;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // lbl_node_title
            // 
            this.lbl_node_title.AutoSize = true;
            this.lbl_node_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_node_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lbl_node_title.Location = new System.Drawing.Point(162, 64);
            this.lbl_node_title.Name = "lbl_node_title";
            this.lbl_node_title.Size = new System.Drawing.Size(90, 20);
            this.lbl_node_title.TabIndex = 4;
            this.lbl_node_title.Text = "Node Title";
            // 
            // lbl_creation_date
            // 
            this.lbl_creation_date.AutoSize = true;
            this.lbl_creation_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_creation_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lbl_creation_date.Location = new System.Drawing.Point(352, 19);
            this.lbl_creation_date.Name = "lbl_creation_date";
            this.lbl_creation_date.Size = new System.Drawing.Size(118, 20);
            this.lbl_creation_date.TabIndex = 6;
            this.lbl_creation_date.Text = "Creation date";
            // 
            // NodeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.lbl_creation_date);
            this.Controls.Add(this.lbl_node_title);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.pnl_left);
            this.Name = "NodeCard";
            this.Size = new System.Drawing.Size(660, 148);
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Label lbl_node_type;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Label lbl_node_title;
        private System.Windows.Forms.Label lbl_creation_date;
    }
}

namespace MARC
{
    partial class CourseCard
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
            this.lbl_course_first_letter = new System.Windows.Forms.Label();
            this.lbl_course_name = new System.Windows.Forms.Label();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_take = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_drop = new System.Windows.Forms.Button();
            this.pnl_left.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
            this.pnl_left.Controls.Add(this.lbl_course_first_letter);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(156, 153);
            this.pnl_left.TabIndex = 0;
            // 
            // lbl_course_first_letter
            // 
            this.lbl_course_first_letter.AutoSize = true;
            this.lbl_course_first_letter.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_course_first_letter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_course_first_letter.Location = new System.Drawing.Point(30, 19);
            this.lbl_course_first_letter.Name = "lbl_course_first_letter";
            this.lbl_course_first_letter.Size = new System.Drawing.Size(99, 108);
            this.lbl_course_first_letter.TabIndex = 0;
            this.lbl_course_first_letter.Text = "L";
            // 
            // lbl_course_name
            // 
            this.lbl_course_name.AutoSize = true;
            this.lbl_course_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_course_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lbl_course_name.Location = new System.Drawing.Point(162, 59);
            this.lbl_course_name.Name = "lbl_course_name";
            this.lbl_course_name.Size = new System.Drawing.Size(117, 20);
            this.lbl_course_name.TabIndex = 1;
            this.lbl_course_name.Text = "Course Name";
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_view.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_view.Enabled = false;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_view.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_view.Location = new System.Drawing.Point(0, 0);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(162, 76);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_take
            // 
            this.btn_take.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_take.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_take.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_take.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_take.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_take.Location = new System.Drawing.Point(0, 77);
            this.btn_take.Name = "btn_take";
            this.btn_take.Size = new System.Drawing.Size(162, 76);
            this.btn_take.TabIndex = 3;
            this.btn_take.Text = "Take";
            this.btn_take.UseVisualStyleBackColor = false;
            this.btn_take.Click += new System.EventHandler(this.btn_take_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_drop);
            this.panel1.Controls.Add(this.btn_view);
            this.panel1.Controls.Add(this.btn_take);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(498, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 153);
            this.panel1.TabIndex = 4;
            // 
            // btn_drop
            // 
            this.btn_drop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_drop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_drop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_drop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_drop.Location = new System.Drawing.Point(0, 77);
            this.btn_drop.Name = "btn_drop";
            this.btn_drop.Size = new System.Drawing.Size(162, 76);
            this.btn_drop.TabIndex = 4;
            this.btn_drop.Text = "Drop";
            this.btn_drop.UseVisualStyleBackColor = false;
            this.btn_drop.Visible = false;
            this.btn_drop.Click += new System.EventHandler(this.btn_drop_Click);
            // 
            // CourseCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_course_name);
            this.Controls.Add(this.pnl_left);
            this.Name = "CourseCard";
            this.Size = new System.Drawing.Size(660, 153);
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Label lbl_course_first_letter;
        private System.Windows.Forms.Label lbl_course_name;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_take;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_drop;
    }
}

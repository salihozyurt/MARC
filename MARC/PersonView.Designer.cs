namespace MARC
{
    partial class PersonView
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
            this.lbl_create = new System.Windows.Forms.Label();
            this.pnl_profil = new System.Windows.Forms.Panel();
            this.lbl_name_fisrt_letter = new System.Windows.Forms.Label();
            this.lbl_pointer = new System.Windows.Forms.Label();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.lbl_lec_std = new System.Windows.Forms.Label();
            this.lbl_name_surname = new System.Windows.Forms.Label();
            PersonView.lbl_announcements = new System.Windows.Forms.Label();
            PersonView.lbl_assignments = new System.Windows.Forms.Label();
            PersonView.lbl_lecture_notes = new System.Windows.Forms.Label();
            this.lbl_course = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            PersonView.lbl_course_title = new System.Windows.Forms.Label();
            PersonView.pnl_container = new System.Windows.Forms.Panel();
            this.pnl_left.SuspendLayout();
            this.pnl_profil.SuspendLayout();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(21)))));
            this.pnl_left.Controls.Add(this.lbl_create);
            this.pnl_left.Controls.Add(this.pnl_profil);
            this.pnl_left.Controls.Add(this.lbl_pointer);
            this.pnl_left.Controls.Add(this.btn_log_out);
            this.pnl_left.Controls.Add(this.lbl_lec_std);
            this.pnl_left.Controls.Add(this.lbl_name_surname);
            this.pnl_left.Controls.Add(PersonView.lbl_announcements);
            this.pnl_left.Controls.Add(PersonView.lbl_assignments);
            this.pnl_left.Controls.Add(PersonView.lbl_lecture_notes);
            this.pnl_left.Controls.Add(this.lbl_course);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(214, 500);
            this.pnl_left.TabIndex = 0;
            // 
            // lbl_create
            // 
            this.lbl_create.AutoSize = true;
            this.lbl_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_create.Location = new System.Drawing.Point(39, 238);
            this.lbl_create.Name = "lbl_create";
            this.lbl_create.Size = new System.Drawing.Size(63, 20);
            this.lbl_create.TabIndex = 15;
            this.lbl_create.Text = "Create";
            this.lbl_create.Visible = false;
            this.lbl_create.Click += new System.EventHandler(this.lbl_profile_Click);
            // 
            // pnl_profil
            // 
            this.pnl_profil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pnl_profil.Controls.Add(this.lbl_name_fisrt_letter);
            this.pnl_profil.Location = new System.Drawing.Point(68, 35);
            this.pnl_profil.Name = "pnl_profil";
            this.pnl_profil.Size = new System.Drawing.Size(82, 76);
            this.pnl_profil.TabIndex = 14;
            // 
            // lbl_name_fisrt_letter
            // 
            this.lbl_name_fisrt_letter.AutoSize = true;
            this.lbl_name_fisrt_letter.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name_fisrt_letter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name_fisrt_letter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.lbl_name_fisrt_letter.Location = new System.Drawing.Point(16, 10);
            this.lbl_name_fisrt_letter.Name = "lbl_name_fisrt_letter";
            this.lbl_name_fisrt_letter.Size = new System.Drawing.Size(52, 55);
            this.lbl_name_fisrt_letter.TabIndex = 1;
            this.lbl_name_fisrt_letter.Text = "L";
            // 
            // lbl_pointer
            // 
            this.lbl_pointer.AutoSize = true;
            this.lbl_pointer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pointer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_pointer.Location = new System.Drawing.Point(13, 278);
            this.lbl_pointer.Name = "lbl_pointer";
            this.lbl_pointer.Size = new System.Drawing.Size(20, 20);
            this.lbl_pointer.TabIndex = 13;
            this.lbl_pointer.Text = "●";
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_log_out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_log_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btn_log_out.Location = new System.Drawing.Point(38, 181);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(133, 39);
            this.btn_log_out.TabIndex = 12;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // lbl_lec_std
            // 
            this.lbl_lec_std.AutoSize = true;
            this.lbl_lec_std.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_lec_std.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_lec_std.Location = new System.Drawing.Point(79, 146);
            this.lbl_lec_std.Name = "lbl_lec_std";
            this.lbl_lec_std.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_lec_std.Size = new System.Drawing.Size(51, 20);
            this.lbl_lec_std.TabIndex = 11;
            this.lbl_lec_std.Text = "email";
            this.lbl_lec_std.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name_surname
            // 
            this.lbl_name_surname.AutoSize = true;
            this.lbl_name_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name_surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_name_surname.Location = new System.Drawing.Point(39, 126);
            this.lbl_name_surname.Name = "lbl_name_surname";
            this.lbl_name_surname.Size = new System.Drawing.Size(132, 20);
            this.lbl_name_surname.TabIndex = 10;
            this.lbl_name_surname.Text = "Name Surname";
            // 
            // lbl_announcements
            // 
            PersonView.lbl_announcements.AutoSize = true;
            PersonView.lbl_announcements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            PersonView.lbl_announcements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            PersonView.lbl_announcements.Location = new System.Drawing.Point(39, 412);
            PersonView.lbl_announcements.Name = "lbl_announcements";
            PersonView.lbl_announcements.Size = new System.Drawing.Size(139, 20);
            PersonView.lbl_announcements.TabIndex = 9;
            PersonView.lbl_announcements.Text = "Announcements";
            PersonView.lbl_announcements.Visible = false;
            PersonView.lbl_announcements.Click += new System.EventHandler(this.lbl_announcements_Click);
            // 
            // lbl_assignments
            // 
            PersonView.lbl_assignments.AutoSize = true;
            PersonView.lbl_assignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            PersonView.lbl_assignments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            PersonView.lbl_assignments.Location = new System.Drawing.Point(39, 365);
            PersonView.lbl_assignments.Name = "lbl_assignments";
            PersonView.lbl_assignments.Size = new System.Drawing.Size(102, 20);
            PersonView.lbl_assignments.TabIndex = 7;
            PersonView.lbl_assignments.Text = "Assigments";
            PersonView.lbl_assignments.Visible = false;
            PersonView.lbl_assignments.Click += new System.EventHandler(this.lbl_assignments_Click);
            // 
            // lbl_lecture_notes
            // 
            PersonView.lbl_lecture_notes.AutoSize = true;
            PersonView.lbl_lecture_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            PersonView.lbl_lecture_notes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            PersonView.lbl_lecture_notes.Location = new System.Drawing.Point(39, 320);
            PersonView.lbl_lecture_notes.Name = "lbl_lecture_notes";
            PersonView.lbl_lecture_notes.Size = new System.Drawing.Size(122, 20);
            PersonView.lbl_lecture_notes.TabIndex = 5;
            PersonView.lbl_lecture_notes.Text = "Lecture Notes";
            PersonView.lbl_lecture_notes.Visible = false;
            PersonView.lbl_lecture_notes.Click += new System.EventHandler(this.lbl_lecture_notes_Click);
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbl_course.Location = new System.Drawing.Point(39, 278);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(75, 20);
            this.lbl_course.TabIndex = 3;
            this.lbl_course.Text = "Courses";
            this.lbl_course.Click += new System.EventHandler(this.lbl_course_Click);
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pnl_header.Controls.Add(PersonView.lbl_course_title);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(214, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(686, 44);
            this.pnl_header.TabIndex = 1;
            // 
            // lbl_course_title
            // 
            PersonView.lbl_course_title.AutoSize = true;
            PersonView.lbl_course_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            PersonView.lbl_course_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            PersonView.lbl_course_title.Location = new System.Drawing.Point(6, 13);
            PersonView.lbl_course_title.Name = "lbl_course_title";
            PersonView.lbl_course_title.Size = new System.Drawing.Size(105, 20);
            PersonView.lbl_course_title.TabIndex = 16;
            PersonView.lbl_course_title.Text = "Course Title";
            // 
            // pnl_container
            // 
            PersonView.pnl_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            PersonView.pnl_container.Location = new System.Drawing.Point(214, 50);
            PersonView.pnl_container.Name = "pnl_container";
            PersonView.pnl_container.Size = new System.Drawing.Size(686, 450);
            PersonView.pnl_container.TabIndex = 2;
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(PersonView.pnl_container);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_left);
            this.Name = "StudentView";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.StudentView_Load);
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            this.pnl_profil.ResumeLayout(false);
            this.pnl_profil.PerformLayout();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_name_fisrt_letter;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Label lbl_name_surname;
        private static System.Windows.Forms.Label lbl_announcements;
        private static System.Windows.Forms.Label lbl_assignments;
        private static System.Windows.Forms.Label lbl_lecture_notes;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.Label lbl_pointer;
        private System.Windows.Forms.Label lbl_create;
        private System.Windows.Forms.Panel pnl_profil;
        private System.Windows.Forms.Label lbl_lec_std;
        private static System.Windows.Forms.Label lbl_course_title;
        private static System.Windows.Forms.Panel pnl_container;
    }
}

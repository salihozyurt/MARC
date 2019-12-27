using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MARC
{
    public partial class PersonView : UserControl
    {
        public static String selected_course_name;

        public PersonView()
        {
            InitializeComponent();
        }

        public static void form_loader_student(String form_name)
        {
            switch (form_name)
            {
                case "coursecardview":
                    CourseCardView courseCardView = new CourseCardView();
                    if (!pnl_container.Controls.Contains(courseCardView))
                    {
                        pnl_container.Controls.Add(courseCardView);
                        courseCardView.Dock = DockStyle.Fill;
                        courseCardView.BringToFront();
                    }
                    else
                    {
                        courseCardView.BringToFront();
                    }
                    break;
                case "nodecardview":
                    lbl_course_title.Text = selected_course_name;
                    lbl_announcements.Visible = true;
                    lbl_assignments.Visible = true;
                    lbl_lecture_notes.Visible = true;
                    NodeCardView nodeCardView = new NodeCardView();
                    if (!pnl_container.Controls.Contains(nodeCardView))
                    {
                        pnl_container.Controls.Add(nodeCardView);
                        nodeCardView.Dock = DockStyle.Fill;
                        nodeCardView.BringToFront();
                    }
                    else
                    {
                        nodeCardView.BringToFront();
                    }
                    break;
                case "announcementview":
                    AnnouncementView announcementView = new AnnouncementView();
                    if (!pnl_container.Controls.Contains(announcementView))
                    {
                        pnl_container.Controls.Add(announcementView);
                        announcementView.Dock = DockStyle.Fill;
                        announcementView.BringToFront();
                    }
                    else
                    {
                        announcementView.BringToFront();
                    }
                    break;
                case "lecturenoteview":
                    LectureNoteView lectureNoteView = new LectureNoteView();
                    if (!pnl_container.Controls.Contains(lectureNoteView))
                    {
                        pnl_container.Controls.Add(lectureNoteView);
                        lectureNoteView.Dock = DockStyle.Fill;
                        lectureNoteView.BringToFront();
                    }
                    else
                    {
                        lectureNoteView.BringToFront();
                    }
                    break; 
                case "assignmentview":
                    AssignmentView assignmentView = new AssignmentView();
                    if (!pnl_container.Controls.Contains(assignmentView))
                    {
                        pnl_container.Controls.Add(assignmentView);
                        assignmentView.Dock = DockStyle.Fill;
                        assignmentView.BringToFront();
                    }
                    else
                    {
                        assignmentView.BringToFront();
                    }
                    break;
                default:
                    MessageBox.Show("An error exist witout cause. Please, close the program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void StudentView_Load(object sender, EventArgs e)
        {
            MainForm.connectDB();
            SqlDataReader data_reader = MainForm.execute_query("SELECT * FROM Person_T WHERE person_id = " + LogIn.getPersonId());
            if (data_reader.Read())
            {
                lbl_name_fisrt_letter.Text = data_reader["person_name"].ToString().Substring(0,1);
                lbl_name_surname.Text = data_reader["person_name"].ToString() + " " + data_reader["surname"].ToString();
                lbl_pointer.Location = new Point(13,278);
                lbl_course_title.Text = "";
                data_reader.Close();
            }
            else
            {
                MessageBox.Show("There are few problems. Please close the program.");
                data_reader.Close();
            }

            if(LogIn.getPersonType())
            {
                lbl_lec_std.Text = "Lecturer";
            }
            else
            {
                lbl_lec_std.Text = "Student";
            }

            form_loader_student("coursecardview");
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure about that ? ", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                MainForm.form_loader("login");
            }
        }

        private void lbl_profile_Click(object sender, EventArgs e)
        {
            lbl_pointer.Location = new Point(13, 238);
        }

        private void lbl_course_Click(object sender, EventArgs e)
        {
            lbl_course_title.Text = "";
            lbl_announcements.Visible = false;
            lbl_assignments.Visible = false;
            lbl_lecture_notes.Visible = false;
            lbl_pointer.Location = new Point(13, 278);
            form_loader_student("coursecardview");
        }

        private void lbl_lecture_notes_Click(object sender, EventArgs e)
        {
            lbl_pointer.Location = new Point(13, 320);
            NodeCardView.setNodeType(1);
            form_loader_student("nodecardview");
        }

        private void lbl_assignments_Click(object sender, EventArgs e)
        {
            lbl_pointer.Location = new Point(13, 365);
            NodeCardView.setNodeType(3);
            form_loader_student("nodecardview");
        }

        private void lbl_announcements_Click(object sender, EventArgs e)
        {
            lbl_pointer.Location = new Point(13, 412);
            NodeCardView.setNodeType(2);
            form_loader_student("nodecardview");
        }

        public static void setLblPoint(Point point)
        {
            lbl_pointer.Location = point;
        }
    }
}

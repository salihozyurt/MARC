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
    public partial class CourseCardView : UserControl
    {

        public CourseCardView()
        {
            InitializeComponent();
        }

        private void CourseCardView_Load(object sender, EventArgs e)
        {
            MainForm.connectDB();
            init_course_cards();
        }

        private void init_course_cards()
        {
            int course_count = 0;

            SqlDataReader data_reader = MainForm.execute_query("SELECT COUNT(*) AS Count_Of_Course FROM Person_T P, Course_T C WHERE C.department_id = P.department_id AND P.person_id = " + LogIn.getPersonId());
            if (data_reader.Read())
            {
                course_count = Convert.ToInt32(data_reader["Count_Of_Course"]);
            }
            data_reader.Close();

            String[] course_name = new String[course_count];
            int[] course_id = new int[course_count];
            int course_index = 0;

            SqlDataReader data_reader_init = MainForm.execute_query("SELECT C.course_id, C.course_name FROM Person_T P, Course_T C WHERE C.department_id = P.department_id AND P.person_id = " + LogIn.getPersonId());
            while (data_reader_init.Read())
            {
                course_name[course_index] = data_reader_init["course_name"].ToString();
                course_id[course_index] = Convert.ToInt32(data_reader_init["course_id"]);
                course_index++;
            }
            data_reader_init.Close();

            CourseCard[] courseCards = new CourseCard[course_count];

            for (int i = 0 ; i < courseCards.Length ; i++)
            {
                courseCards[i] = new CourseCard();
                courseCards[i].Course_ID = course_id[i];
                courseCards[i].Course_First_Letter = course_name[i].Substring(0, 1);
                courseCards[i].Course_Name = course_name[i];

                SqlDataReader unique_courses = MainForm.execute_query("SELECT C.course_id, C.course_name FROM Person_T P, Course_T C, Classroom_T CC WHERE CC.person_id = P.person_id AND C.course_id = CC.course_id AND CC.end_date > GETDATE() AND P.person_id = " + LogIn.getPersonId());
                while (unique_courses.Read())
                {
                    if (Convert.ToInt32(unique_courses["course_id"]) == course_id[i])
                    {
                        courseCards[i].View_Button = true;
                        courseCards[i].Drop_Button = true;
                        courseCards[i].Take_Button = false;
                    }
                }
                unique_courses.Close();

                if (flow_panel_container.Controls.Count < 0)
                {
                    flow_panel_container.Controls.Clear();
                }
                else
                {
                    flow_panel_container.Controls.Add(courseCards[i]);
                }
            }

        }

    }
}

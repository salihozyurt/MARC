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
    public partial class CourseCard : UserControl
    {
        public CourseCard()
        {
            InitializeComponent();
        }

        #region Properties

        private String _course_first_letter;
        private String _course_name;
        private int _course_id;
        private Boolean _View_Button;
        private Boolean _Take_Button;
        private Boolean _Drop_Button;

        [Category("Custom Props")]
        public String Course_First_Letter
        {
            get { return this._course_first_letter; }
            set { _course_first_letter = value; lbl_course_first_letter.Text = value; }
        }

        [Category("Custom Props")]
        public String Course_Name
        {
            get { return this._course_name; }
            set { _course_name = value; lbl_course_name.Text = value; }
        }

        [Category("Custom Props")]
        public int Course_ID
        {
            get { return this._course_id; }
            set { _course_id = value; }
        }

        [Category("Custom Props")]
        public Boolean View_Button
        {
            get { return this._View_Button; }
            set { _View_Button = value; btn_view.Enabled = value; }
        }

        [Category("Custom Props")]
        public Boolean Take_Button
        {
            get { return this._Take_Button; }
            set { _Take_Button = value; btn_take.Visible = value; }
        }

        [Category("Custom Props")]
        public Boolean Drop_Button
        {
            get { return this._Drop_Button; }
            set { _Drop_Button = value; btn_drop.Visible = value; }
        }

        #endregion

        private void btn_view_Click(object sender, EventArgs e)
        {
            NodeCardView.setCourseId(_course_id);
            PersonView.selected_course_name = _course_name;
            NodeCardView.setNodeType(4);
            PersonView.form_loader_student("nodecardview");
        }

        private void btn_drop_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure about that ?", "Drop Course", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MainForm.execute_non_query("DELETE FROM Classroom_T WHERE person_id = " + LogIn.getPersonId() + " AND course_id = " + _course_id);
            }
            btn_drop.Visible = false;
            btn_take.Visible = true;
            btn_view.Enabled = false;
        }

        private void btn_take_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure about that ?", "Take Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MainForm.execute_non_query("INSERT INTO Classroom_T VALUES (" + _course_id + "," + LogIn.getPersonId() + ",'2020-01-09')");
            }
            btn_drop.Visible = true;
            btn_take.Visible = false;
            btn_view.Enabled = true;
        }
    }
}

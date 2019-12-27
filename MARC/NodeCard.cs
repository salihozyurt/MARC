using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARC
{
    public partial class NodeCard : UserControl
    {
        public static int selected_student_id = 201;

        public NodeCard()
        {
            InitializeComponent();
        }

        #region Properties

        private String _node_type;
        private String _node_title;
        private String _node_creation_date;
        private int _node_id;

        [Category("Custom Props")]
        public String Node_Type
        {
            get { return this._node_type; }
            set { _node_type = value; lbl_node_type.Text = value; }
        }

        [Category("Custom Props")]
        public String Node_Title
        {
            get { return this._node_title; }
            set { _node_title = value; lbl_node_title.Text = value; }
        }

        [Category("Custom Props")]
        public String Node_Creation_Date
        {
            get { return this._node_creation_date; }
            set { _node_creation_date = value; lbl_creation_date.Text = value; }
        }

        [Category("Custom Props")]
        public int Node_ID
        {
            get { return this._node_id; }
            set { _node_id = value; }
        }

        #endregion

        private void btn_view_Click(object sender, EventArgs e)
        {
            switch (_node_type)
            {
                case "Lecture Note":
                    PersonView.setLblPoint(new Point(13, 320));
                    LectureNoteView.setPersonId(selected_student_id);
                    LectureNoteView.setNodeId(_node_id);
                    PersonView.form_loader_student("lecturenoteview");
                    break;
                case "Announcement":
                    PersonView.setLblPoint(new Point(13, 412));
                    AnnouncementView.setPersonId(selected_student_id);
                    AnnouncementView.setNodeId(_node_id);
                    PersonView.form_loader_student("announcementview");
                    break;
                case "Assignment":
                    PersonView.setLblPoint(new Point(13, 365));
                    AssignmentView.setPersonId(selected_student_id);
                    AssignmentView.setNodeId(_node_id);
                    PersonView.form_loader_student("assignmentview");
                    break;
                default:
                    break;
            }
        }
    }
}

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
    public partial class AnnouncementView : UserControl
    {
        private static int _selected_person_id;

        public static int getPersonId()
        {
            return _selected_person_id;
        }

        public static void setPersonId(int value)
        {
            _selected_person_id = value;
        }

        private static int _selected_node_id;

        public static int getNodeId()
        {
            return _selected_node_id;
        }

        public static void setNodeId(int value)
        {
            _selected_node_id = value;
        }

        private static String _node_type;

        public static String getNodeType()
        {
            return _node_type;
        }

        public static void setNodeType(String value)
        {
            _node_type = value;
        }

        public AnnouncementView()
        {
            InitializeComponent();
        }

        public static void init_comments()
        {
            CommentView commentView = new CommentView();
            if (!pnl_comment.Controls.Contains(commentView))
            {
                pnl_comment.Controls.Add(commentView);
                commentView.Dock = DockStyle.Fill;
                commentView.BringToFront();
            }
            else
            {
                commentView.BringToFront();
            }
        }

        private void AnnouncementView_Load(object sender, EventArgs e)
        {
            //init labels

            MainForm.connectDB();
            SqlDataReader node_reader = MainForm.execute_query("SELECT * FROM All_Node_Info WHERE node_id = " + getNodeId());
            if (node_reader.Read())
            {
                lbl_node_type.Text = node_reader["node_type"].ToString();
                lbl_node_title.Text = node_reader["title"].ToString();
                String[] temp = node_reader["creation_date"].ToString().Split(' ');
                lbl_creation_date.Text = temp[0];
                lbl_description.Text = node_reader["node_description"].ToString();
                setNodeType(node_reader["node_type"].ToString());
                node_reader.Close();
            }
            else
            {
                MessageBox.Show("There are few problems. Please close the program.");
                node_reader.Close();
            }

            //init comments

            CommentView.setNodeId(getNodeId());
            CommentView.setPersonId(getPersonId());
            CommentView.setNodeType(getNodeType());
            init_comments();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            PersonView.form_loader_student("nodecardview");
        }
    }
}

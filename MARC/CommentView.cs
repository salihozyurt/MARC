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
    public partial class CommentView : UserControl
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

        private static List<int> list_cmb_box_person_id = new List<int>();

        public CommentView()
        {
            InitializeComponent();
        }

        private void CommentView_Load(object sender, EventArgs e)
        {
            //Init combo box item

            SqlDataReader cmb_box_ref_user_item = MainForm.execute_query("SELECT P.person_id, P.person_name, P.surname FROM Person_T P, Node_T N, Comment_T C WHERE C.person_id = P.person_id AND C.node_id = N.node_id AND C.node_id = " + getNodeId());
            while (cmb_box_ref_user_item.Read())
            {
                if (Convert.ToInt32(cmb_box_ref_user_item["person_id"]) != getPersonId())
                {
                    cmb_box_ref_user.Items.Add(cmb_box_ref_user_item["person_name"] + " " + cmb_box_ref_user_item["surname"]);
                    list_cmb_box_person_id.Add(Convert.ToInt32(cmb_box_ref_user_item["person_id"]));
                }
            }
            cmb_box_ref_user_item.Close();

            cmb_box_ref_user.SelectedIndex = 0;

            MainForm.connectDB();
            init_comment_cards();
        }

        public static void init_comment_cards()
        {
            int comment_count = 0;

            SqlDataReader data_reader = MainForm.execute_query("SELECT COUNT(*) AS Count_Of_Comment FROM Person_T P, Comment_T C WHERE C.person_id = P.person_id AND C.node_id = " + getNodeId());
            if (data_reader.Read())
            {
                comment_count = Convert.ToInt32(data_reader["Count_Of_Comment"]);
            }
            data_reader.Close();

            String[] temp_person_name = new String[comment_count];
            int[] temp_person_id = new int[comment_count];
            int temp_index = 0;

            SqlDataReader temp_data_reader = MainForm.execute_query("SELECT P.person_name, P.surname, P.person_id FROM Person_T P, Comment_T C WHERE C.person_id = P.person_id AND C.node_id = " + getNodeId());
            while (temp_data_reader.Read())
            {
                temp_person_name[temp_index] = temp_data_reader["person_name"].ToString() + " " + temp_data_reader["surname"].ToString();
                temp_person_id[temp_index] = Convert.ToInt32(temp_data_reader["person_id"]);
                temp_index++;
            }
            temp_data_reader.Close();

            CommentCard[] commentCard = new CommentCard[comment_count];
            int index_comment = 0;

            SqlDataReader comment_reader = MainForm.execute_query("SELECT P.person_name, P.surname, C.comment_text, C.reference_user FROM Person_T P, Comment_T C WHERE C.person_id = P.person_id AND C.node_id = " + getNodeId());
            while (comment_reader.Read())
            {
                commentCard[index_comment] = new CommentCard();
                commentCard[index_comment].Comment_Owner = comment_reader["person_name"].ToString() + " " + comment_reader["surname"].ToString();
                commentCard[index_comment].Comment_Content = comment_reader["comment_text"].ToString();
                if (Convert.ToInt32(comment_reader["reference_user"]) != -1)
                {
                    for(int i = 0; i < comment_count; i++)
                    {
                        if(Convert.ToInt32(comment_reader["reference_user"]) == temp_person_id[i])
                        {
                            commentCard[index_comment].Comment_Content = temp_person_name[i] + " Referanced : " + commentCard[index_comment].Comment_Content;
                            break;
                        }
                    }
                }
                if (flow_panel_container.Controls.Count < 0)
                {
                    flow_panel_container.Controls.Clear();
                }
                else
                {
                    flow_panel_container.Controls.Add(commentCard[index_comment]);
                }
                index_comment++;

            }
            comment_reader.Close();
        }

        private void btn_send_comment_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure about that ?", "Send Comment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txt_box_comment.Text != "")
                {
                    if (cmb_box_ref_user.SelectedIndex != 0)
                    {
                        MainForm.execute_non_query("INSERT INTO Comment_T VALUES (" + getNodeId() + "," + getPersonId() + ",'" + txt_box_comment.Text + "'," + list_cmb_box_person_id[cmb_box_ref_user.SelectedIndex - 1] + ")");
                    }
                    else
                    {
                        MainForm.execute_non_query("INSERT INTO Comment_T VALUES (" + getNodeId() + "," + getPersonId() + ",'" + txt_box_comment.Text + "',-1)");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter comment.");
                }
            }
            cmb_box_ref_user.SelectedIndex = 0;
            txt_box_comment.Text = "";
            switch (_node_type)
            {
                case "Lecture Note":
                    LectureNoteView.init_comments();
                    break;
                case "Announcement":
                    AnnouncementView.init_comments();
                    break;
                case "Assignment":
                    break;
                default:
                    break;
            }
        }
    }
}

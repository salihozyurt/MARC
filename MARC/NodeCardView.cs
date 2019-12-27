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
    public partial class NodeCardView : UserControl
    {
        public static int selected_student_id = 201;

        private static int selected_course_id;
        
        public static int getCourseId()
        {
            return selected_course_id;
        }

        public static void setCourseId(int value)
        {
            selected_course_id = value;
        }

        private static int _selected_node_type;

        public static int getNodeType()
        {
            return _selected_node_type;
        }

        public static void setNodeType(int value)
        {
            _selected_node_type = value;
        }

        public NodeCardView()
        {
            InitializeComponent();
        }

        private void NodeCardView_Load(object sender, EventArgs e)
        {
            MainForm.connectDB();
            init_node_cards();
        }

        private static SqlDataReader data_reader;
        private static SqlDataReader node_reader;

        public static void init_node_cards()
        {
            switch (_selected_node_type)
            {
                case 1://Lecturer Note
                    data_reader = MainForm.execute_query("SELECT COUNT(*) AS Count_Of_Node FROM All_Node_Info WHERE course_id = " + getCourseId()+ " AND node_type = 'Lecture Note'");
                    break;
                case 2://Announcement
                    data_reader = MainForm.execute_query("SELECT COUNT(*) AS Count_Of_Node FROM All_Node_Info WHERE course_id = " + getCourseId() + " AND node_type = 'Announcement'");
                    break;
                case 3://Assignment
                    data_reader = MainForm.execute_query("SELECT COUNT(*) AS Count_Of_Node FROM All_Node_Info WHERE course_id = " + getCourseId() + " AND node_type = 'Assignment'");
                    break;
                case 4://All Type
                    data_reader = MainForm.execute_query("SELECT COUNT(*) AS Count_Of_Node FROM All_Node_Info WHERE course_id = " + getCourseId());
                    break;
                default:
                    break;
            }


            int node_count = 0;

            if (data_reader.Read())
            {
                node_count = Convert.ToInt32(data_reader["Count_Of_Node"]);
            }
            data_reader.Close();

            NodeCard[] nodeCard = new NodeCard[node_count];
            int index_node = 0;

            switch (_selected_node_type)
            {
                case 1://Lecturer Note
                    node_reader = MainForm.execute_query("SELECT * FROM All_Node_Info WHERE course_id = " + getCourseId() + " AND node_type = 'Lecture Note'");
                    break;
                case 2://Announcement
                    node_reader = MainForm.execute_query("SELECT * FROM All_Node_Info WHERE course_id = " + getCourseId() + " AND node_type = 'Announcement'");
                    break;
                case 3://Assignment
                    node_reader = MainForm.execute_query("SELECT * FROM All_Node_Info WHERE course_id = " + getCourseId() + " AND node_type = 'Assignment'");
                    break;
                case 4://All Type
                    node_reader = MainForm.execute_query("SELECT * FROM All_Node_Info WHERE course_id = " + getCourseId());
                    break;
                default:
                    break;
            }

            while (node_reader.Read())
            {
                nodeCard[index_node] = new NodeCard();
                nodeCard[index_node].Node_ID = Convert.ToInt32(node_reader["node_id"]);
                nodeCard[index_node].Node_Type = node_reader["node_type"].ToString();
                nodeCard[index_node].Node_Title = node_reader["title"].ToString();
                String[] temp = node_reader["creation_date"].ToString().Split(' ');
                nodeCard[index_node].Node_Creation_Date = temp[0];

                if (flow_panel_container.Controls.Count < 0)
                {
                    flow_panel_container.Controls.Clear();
                }
                else
                {
                    flow_panel_container.Controls.Add(nodeCard[index_node]);
                }
                index_node++;
            }
            node_reader.Close();


        }
    }
}

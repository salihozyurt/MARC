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
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;

namespace MARC
{
    public partial class AssignmentView : UserControl
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

        private static String _file_name;

        public static String getFileName()
        {
            return _file_name;
        }

        public static void setFileName(String value)
        {
            _file_name = value;
        }

        public AssignmentView()
        {
            InitializeComponent();
        }

        private void AssignmentView_Load(object sender, EventArgs e)
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

            SqlDataReader node_reader2 = MainForm.execute_query("SELECT end_date FROM Assignment_T WHERE assignment_id = " + getNodeId());
            if (node_reader2.Read())
            {
                String[] temp = node_reader2["end_date"].ToString().Split(' ');
                lbl_end_date.Text = temp[0];
                node_reader2.Close();
            }
            else
            {
                MessageBox.Show("There are few problems. Please close the program.");
                node_reader2.Close();
            }

            SqlDataReader node_reader3 = MainForm.execute_query("SELECT student_id, document  FROM Delivery_T WHERE student_id = " + getPersonId());
            if (node_reader3.Read())
            {
                if(Convert.ToInt32(node_reader3["student_id"]) == getPersonId())
                {
                    btn_upload.Text = "Upload Again";
                    lbl_iscomplated.Text = "Complated";
                    setFileName(node_reader3["document"].ToString());
                }
                
            }
            node_reader3.Close();

            DateTime creation_time = DateTime.ParseExact(lbl_creation_date.Text, "dd.MM.yyyy",null);
            DateTime end_time = DateTime.ParseExact(lbl_end_date.Text, "dd.MM.yyyy", null);

            if(!(creation_time <= end_time))
            {
                btn_upload.Enabled = false;
            }

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure about that ?", "Send Comment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Files (*.pdf, *.docx, *.doc) | *.pdf; *.docx; *.doc;";
                openFileDialog.Title = "Choose Upload File";

                String dateNow = System.DateTime.Now.ToString();
                dateNow = Regex.Replace(dateNow, "[^0-9]", string.Empty);


                if (btn_upload.Text == "Upload")
                {
                    try
                    {
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            String new_file_name = dateNow + "_" + getPersonId().ToString() + Path.GetExtension(openFileDialog.SafeFileName);
                            String destPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\documents\\Assignment\\" + new_file_name;
                            String sourcePath = openFileDialog.FileName;

                            MainForm.execute_non_query("INSERT INTO Delivery_T VALUES (" + getPersonId() + "," + getNodeId() + ",'" + new_file_name + "')");

                            FileInfo fileInfo = new FileInfo(sourcePath);
                            fileInfo.CopyTo(destPath);
                            

                            btn_upload.Text = "Upload Again";
                            lbl_iscomplated.Text = "Complated";
                            setFileName(new_file_name);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please select a file. " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            String currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\documents\\Assignment\\";
                            File.Delete(currentPath + getFileName());

                            String new_file_name = dateNow + "_" + getPersonId().ToString() + Path.GetExtension(openFileDialog.SafeFileName);
                            String sourcePath = openFileDialog.FileName;

                            MainForm.execute_non_query("UPDATE Delivery_T SET document = '" + new_file_name + "' WHERE student_id = " + getPersonId() + " AND assignment_id =" + getNodeId());

                            FileInfo fileInfo = new FileInfo(sourcePath);
                            fileInfo.CopyTo(currentPath + new_file_name);

                            setFileName(new_file_name);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please select a file. " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_look_complated_Click(object sender, EventArgs e)
        {
            //TODO Lecturer
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            PersonView.form_loader_student("nodecardview");
        }
    }
}

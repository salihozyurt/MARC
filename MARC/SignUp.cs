using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARC
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void change_person_type()
        {
            txt_box_id.Text = "";
            cmb_box_department.SelectedIndex = 0;
            txt_box_name.Text = "";
            txt_box_surname.Text = "";
            txt_box_surname.Text = "@marun.edu";
            txt_box_pass.Text = "";
            txt_box_pass_repeat.Text = "";
            txt_box_pass_repeat.Enabled = false;
            data_birth_date.Value = DateTime.Today;
            txt_box_street.Text = "";
            txt_box_city.Text = "";
            txt_box_state.Text = "";
            cmb_box_rank.SelectedIndex = 0;
            cmb_box_semester.SelectedIndex = 0;
            txt_box_tey.Text = "";
            txt_box_gpa.Text = "";
            txt_box_tcredits.Text = "";
        }

        private void rd_button_lecturer_CheckedChanged(object sender, EventArgs e)
        {
            lbl_id.Text = "Lecturer ID";
            lbl_rank_semester.Text = "Rank";
            cmb_box_rank.Visible = true;
            cmb_box_semester.Visible = false;
            lbl_tey_gpa.Text = "Total Education Year";
            txt_box_tey.Visible = true;
            txt_box_gpa.Visible = false;
            lbl_tcredits.Visible = false;
            txt_box_tcredits.Visible = false;
            change_person_type();
        }

        private void rd_btn_student_CheckedChanged(object sender, EventArgs e)
        {
            lbl_id.Text = "Student ID";
            lbl_rank_semester.Text = "Semester";
            cmb_box_rank.Visible = false;
            cmb_box_semester.Visible = true;
            lbl_tey_gpa.Text = "GPA";
            txt_box_tey.Visible = false;
            txt_box_gpa.Visible = true;
            lbl_tcredits.Visible = true;
            txt_box_tcredits.Visible = true;
            change_person_type();
        }

        private String date_parser(String input_date)
        {
            String[] temp = input_date.Split(' ');
            String parsed_date = temp[0];
            temp = parsed_date.Split('.');
            if(temp[1].Length == 1)
            {
                temp[1] = "0" + temp[1];
            }
            if (temp[0].Length == 1)
            {
                temp[0] = "0" + temp[0];
            }
            parsed_date = temp[2] + "-" + temp[1] + "-" + temp[0];
            return parsed_date;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            MainForm.connectDB();
            data_birth_date.MaxDate = DateTime.Today;
            SqlDataReader cmb_box_dept_item = MainForm.execute_query("SELECT department_name FROM Department_T");
            while (cmb_box_dept_item.Read())
            {
                cmb_box_department.Items.Add(cmb_box_dept_item["department_name"]);
            }
            cmb_box_dept_item.Close();
            cmb_box_department.SelectedIndex = 0;
            cmb_box_rank.SelectedIndex = 0;
            cmb_box_semester.SelectedIndex = 0;
        }

        private Boolean can_signup_data_save()
        {
            if (txt_box_id.Text == "" || txt_box_name.Text == "" || txt_box_surname.Text == "" || txt_box_email.Text == "" || txt_box_pass.Text == "" || txt_box_pass_repeat.Text == "" || data_birth_date.Value == System.DateTime.Now || txt_box_street.Text == "" || txt_box_city.Text == "" || txt_box_state.Text == "" )
            {
                return false;
            }

            if (rd_btn_student.Checked && (txt_box_gpa.Text == "" || txt_box_tcredits.Text == ""))
            {
                return false;
            }

            if (rd_button_lecturer.Checked && txt_box_tey.Text == "")
            {
                return false;
            }

            return true;
        }

        private void link_lbl_log_in_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.form_loader("login");
        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            Boolean sign_up_controler = can_signup_data_save();
            if (sign_up_controler)
            {
                if (rd_button_lecturer.Checked)
                {
                    MainForm.execute_non_query("INSERT INTO Person_T VALUES (" + System.Convert.ToInt32(txt_box_id.Text) + "," + cmb_box_department.SelectedIndex + 1 + ",'" + txt_box_name.Text + "','" + txt_box_surname.Text + "','" + txt_box_email.Text+ "'," +
                                               "'" + txt_box_pass.Text + "','" + date_parser(data_birth_date.Value.ToString()) + "','" + txt_box_street.Text + "','" + txt_box_city.Text + "','" + txt_box_state.Text + "')");
                    MainForm.execute_non_query("INSERT INTO Lecturer_T VALUES (" + System.Convert.ToInt32(txt_box_id.Text) + ",'" + cmb_box_rank.SelectedItem.ToString() + "'," + System.Convert.ToInt32(txt_box_tey.Text) + ")");
                }
                else
                {
                    MainForm.execute_non_query("INSERT INTO Person_T VALUES (" + System.Convert.ToInt32(txt_box_id.Text) + "," + cmb_box_department.SelectedIndex + 1 + ",'" + txt_box_name.Text + "','" + txt_box_surname.Text + "','" + txt_box_email.Text + "'," +
                                               "'" + txt_box_pass.Text + "','" + date_parser(data_birth_date.Value.ToString()) + "','" + txt_box_street.Text + "','" + txt_box_city.Text + "','" + txt_box_state.Text + "')");
                    MainForm.execute_non_query("INSERT INTO Student_T VALUES (" + System.Convert.ToInt32(txt_box_id.Text) + "," + cmb_box_semester.SelectedIndex + 1 + ",0.0," + System.Convert.ToInt32(txt_box_tcredits.Text) + "," + (System.Convert.ToSingle(txt_box_gpa.Text) >= 3 ? 1 : 0) + ")");
                    String query = "UPDATE Student_T SET GPA = @gpa WHERE student_id = @id";
                    SqlCommand sqlCommand = new SqlCommand(query, MainForm.connectionURL);
                    sqlCommand.Parameters.AddWithValue("@gpa",Convert.ToSingle(txt_box_gpa.Text));
                    sqlCommand.Parameters.AddWithValue("@id", System.Convert.ToInt32(txt_box_id.Text));
                    sqlCommand.ExecuteNonQuery();
                }
                MainForm.form_loader("login");
            }
            else
            {
                MessageBox.Show("Please, control your informations.");
            }


        }

        private void txt_box_id_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_box_id.Text, "[^0-9]"))
            {
                MessageBox.Show("ID can only contain numbers.");
                txt_box_id.Text = txt_box_id.Text.Remove(txt_box_id.Text.Length - 1);
            }
        }

        private void txt_box_id_Leave(object sender, EventArgs e)
        {
            if(txt_box_id.Text != "")
            {
                SqlDataReader is_id_match = MainForm.execute_query("SELECT person_id FROM Person_T WHERE person_id = " + txt_box_id.Text);
                if (is_id_match.Read())
                {
                    MessageBox.Show("There is same ID. Are you sure You have no account?");
                    txt_box_id.Text = "";
                }
                is_id_match.Close();
            }
        }

        private void txt_box_name_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_box_name.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Name can only contain letters.");
                txt_box_name.Text = txt_box_name.Text.Remove(txt_box_name.Text.Length - 1);
            }
        }

        private void txt_box_surname_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_box_surname.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Surname can only contain letters.");
                txt_box_surname.Text = txt_box_surname.Text.Remove(txt_box_surname.Text.Length - 1);
            }
        }

        private void txt_box_email_Enter(object sender, EventArgs e)
        {
            txt_box_email.Text = "";
        }

        private void txt_box_email_Leave(object sender, EventArgs e)
        {
            if(txt_box_email.Text != "")
            {
                if (txt_box_email.Text.Contains("@"))
                {
                    String[] email_temp = txt_box_email.Text.Split('@');
                    if (email_temp[1] != "marun.edu")
                    {
                        MessageBox.Show("Please sure you write @marun.edu e-mail.");
                        txt_box_email.Text = "@marun.edu";
                    }
                }
                else
                {
                    MessageBox.Show("Please sure you write correct type e-mail.");
                    txt_box_email.Text = "@marun.edu";
                }
                
                SqlDataReader is_email_match = MainForm.execute_query("SELECT email FROM Person_T WHERE email = '" + txt_box_email.Text + "'");
                if (is_email_match.Read())
                {
                    MessageBox.Show("There is same e-mail. Are you sure You have no account?");
                    txt_box_email.Text = "@marun.edu";
                }
                is_email_match.Close();
            }
            else
            {
                txt_box_email.Text = "@marun.edu";
            }
        }

        private void txt_box_pass_TextChanged(object sender, EventArgs e)
        {
            if(txt_box_pass.Text.Length == 0)
            {
                txt_box_pass_repeat.Text = "";
                txt_box_pass_repeat.Enabled = false;
            }
            else
            {
                txt_box_pass_repeat.Enabled = true;
            }
        }

        private void pic_box_eye_MouseEnter(object sender, EventArgs e)
        {
            txt_box_pass.PasswordChar = '\0';
        }

        private void pic_box_eye_MouseLeave(object sender, EventArgs e)
        {
            txt_box_pass.PasswordChar = '●';
        }

        private void pic_box_eye_pass_repeat_MouseEnter(object sender, EventArgs e)
        {
            txt_box_pass_repeat.PasswordChar = '\0';
        }

        private void pic_box_eye_pass_repeat_MouseLeave(object sender, EventArgs e)
        {
            txt_box_pass_repeat.PasswordChar = '●';
        }

        private void txt_box_pass_repeat_Leave(object sender, EventArgs e)
        {
            if(txt_box_pass_repeat.Text != txt_box_pass.Text)
            {
                MessageBox.Show("Repeated password and password are not same.");
                txt_box_pass_repeat.Text = "";
            }
        }

        private void txt_box_gpa_Leave(object sender, EventArgs e)
        {
            if(txt_box_gpa.Text != "")
            {
                Single temp = Convert.ToSingle(txt_box_gpa.Text);
                if (temp > 4)
                {
                    MessageBox.Show("GPA is not greater than 4");
                    txt_box_gpa.Text = "";
                }
                else if (temp < 1)
                {
                    MessageBox.Show("GPA is not lower than 1");
                    txt_box_gpa.Text = "";
                }
            }
        }

        private void txt_box_gpa_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_box_gpa.Text, "[^0-9,]"))
            {
                MessageBox.Show("GPA can only contain numbers and comma.");
                txt_box_gpa.Text = txt_box_gpa.Text.Remove(txt_box_gpa.Text.Length - 1);
            }
        }

        private void txt_box_tey_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_box_tey.Text, "[^0-9]"))
            {
                MessageBox.Show("Total education year can only contain numbers.");
                txt_box_tey.Text = txt_box_tey.Text.Remove(txt_box_tey.Text.Length - 1);
            }
        }

        private void txt_box_tcredits_Leave(object sender, EventArgs e)
        {
            if (txt_box_tcredits.Text != "")
            {
                int temp = Convert.ToInt32(txt_box_tcredits.Text);
                if (temp > 300)
                {
                    MessageBox.Show("Total credits is not greater than 300");
                    txt_box_tcredits.Text = "";
                }
            }
        }

        private void txt_box_tcredits_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_box_tcredits.Text, "[^0-9]"))
            {
                MessageBox.Show("Total credits can only contain numbers.");
                txt_box_tcredits.Text = txt_box_tcredits.Text.Remove(txt_box_tcredits.Text.Length - 1);
            }
        }

        private void data_birth_date_Leave(object sender, EventArgs e)
        {
            String[] temp = data_birth_date.Value.ToString().Split(' ');
            String parsed_date = temp[0];
            temp = parsed_date.Split('.');
            int control_temp = System.Convert.ToInt32(temp[2]);

            String[] temp2 = System.DateTime.Today.ToString().Split(' ');
            String parsed_date2 = temp2[0];
            temp2 = parsed_date2.Split('.');
            int control_temp2 = System.Convert.ToInt32(temp2[2]);

            if (control_temp > control_temp2 - 17)
            {
                MessageBox.Show("Your age cannot be lover than 17.");
                data_birth_date.Value = DateTime.Today;
            }
        }
    }
}

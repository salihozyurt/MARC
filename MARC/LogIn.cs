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
    public partial class LogIn : UserControl
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

        //false student true lecturer
        private static Boolean _selected_person_type;

        public static Boolean getPersonType()
        {
            return _selected_person_type;
        }

        public static void setPersonType(Boolean value)
        {
            _selected_person_type = value;
        }

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            MainForm.connectDB();
        }

        private void btn_log_in_Click(object sender, EventArgs e)
        {
            if (txt_box_email.Text.Length >= 10)
            {
                String control_email = txt_box_email.Text.Substring(txt_box_email.Text.Length - 10);
                if (control_email != "@marun.edu")
                {
                    MessageBox.Show("Plese, write an e-mail ended with @marun.edu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txt_box_password.Text.Length != 0)
                    {
                        SqlDataReader data_reader = MainForm.execute_query("SELECT * FROM Person_T WHERE email = '" + txt_box_email.Text + "' AND person_password = '" + txt_box_password.Text + "'");
                        if (data_reader.Read())
                        {
                            setPersonId(Convert.ToInt32(data_reader["person_id"]));
                            data_reader.Close();
                            SqlDataReader user_reader = MainForm.execute_query("SELECT L.lecturer_id FROM Person_T P, Lecturer_T L WHERE P.person_id = L.lecturer_id AND P.email = '" + txt_box_email.Text + "'");
                            if (user_reader.Read())
                            {
                                user_reader.Close();
                                setPersonType(true);
                                MainForm.form_loader("personview");
                            }
                            else
                            {
                                user_reader.Close();
                                setPersonType(false);
                                MainForm.form_loader("personview"); 
                            }
                        }
                        else
                        {
                            data_reader.Close();
                            MessageBox.Show("E-mail or password is wrong. Please, check your e-mail and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please, enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Plese, write an e-mail ended with @marun.edu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic_box_eye_MouseEnter(object sender, EventArgs e)
        {
            txt_box_password.PasswordChar = '\0';
        }

        private void pic_box_eye_MouseLeave(object sender, EventArgs e)
        {
            txt_box_password.PasswordChar = '●';
        }

        private void txt_box_email_Click(object sender, EventArgs e)
        {
            txt_box_email.Text = "";
        }

        private void txt_box_password_Click(object sender, EventArgs e)
        {
            txt_box_password.Text = "";
        }

        private void link_label_sign_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.form_loader("signup");
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARC
{
    public partial class MainForm : Form
    {
        private int move, move_X, move_Y;
        public static SqlConnection connectionURL = new SqlConnection(@"Data Source=DESKTOP-0OQQ2MS\SQLEXPRESS;Initial Catalog=MARC;User Id=admin;Password=password;");
        private static SqlCommand query;
        private static SqlDataReader data_reader;

        public static void connectDB()
        {
            if (connectionURL.State == ConnectionState.Closed)
            {
                connectionURL.Open();
            }
        }

        public static SqlDataReader execute_query(String Query)
        {
            try
            {
                query = new SqlCommand();
                query.Connection = connectionURL;
                query.CommandText = Query;
                query.ExecuteNonQuery();
                data_reader = query.ExecuteReader();
                return data_reader;
            }
            catch(SqlException e)
            {
                MessageBox.Show("An error exist witout cause. Please, close the program. "+e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static void execute_non_query(String Query)
        {
            try
            {
                query = new SqlCommand();
                query.Connection = connectionURL;
                query.CommandText = Query;
                query.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show("An error exist witout cause. Please, close the program. "+e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void form_loader(String form_name)
        {
            
            switch (form_name)
            {
                case "login":
                    LogIn logIn = new LogIn();
                    if (!pnl_container.Controls.Contains(logIn))
                    {
                        pnl_container.Controls.Add(logIn);
                        logIn.Dock = DockStyle.Fill;
                        logIn.BringToFront();
                    }
                    else
                    {
                        logIn.BringToFront();
                    }
                    break;
                case "signup":
                    SignUp signUp = new SignUp();
                    if (!pnl_container.Controls.Contains(signUp))
                    {
                        pnl_container.Controls.Add(signUp);
                        signUp.Dock = DockStyle.Fill;
                        signUp.BringToFront();
                    }
                    else
                    {
                        signUp.BringToFront();
                    }
                    break;
                case "personview":
                    PersonView personView = new PersonView();
                    if (!pnl_container.Controls.Contains(personView))
                    {
                        pnl_container.Controls.Add(personView);
                        personView.Dock = DockStyle.Fill;
                        personView.BringToFront();
                    }
                    else
                    {
                        personView.BringToFront();
                    }
                    break;
                default:
                    MessageBox.Show("An error exist witout cause. Please, close the program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            connectDB();
            form_loader("login");
        }

        private void pnl_header_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            move_X = e.X;
            move_Y = e.Y;
        }

        private void pnl_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - move_X, MousePosition.Y - move_Y);
            }
        }

        private void pnl_header_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void pic_box_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure about that ?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void pic_box_underscore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

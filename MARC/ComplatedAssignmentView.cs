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
    public partial class ComplatedAssignmentView : UserControl
    {

        private static ComplatedAssignmentView _instance;

        public static ComplatedAssignmentView Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ComplatedAssignmentView();
                }
                return _instance;
            }
        }

        public ComplatedAssignmentView()
        {
            InitializeComponent();
        }

        private void LecturerView_Load(object sender, EventArgs e)
        {
            MainForm.connectDB();
        }
    }
}

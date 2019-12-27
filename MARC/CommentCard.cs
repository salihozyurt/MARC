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
    public partial class CommentCard : UserControl
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

        public CommentCard()
        {
            InitializeComponent();
        }

        #region Properties

        private String _comment_owner;
        private String _comment_content;

        [Category("Custom Props")]
        public String Comment_Owner
        {
            get { return this._comment_owner; }
            set { _comment_owner = value; lbl_comment_owner.Text = value; }
        }

        [Category("Custom Props")]
        public String Comment_Content
        {
            get { return this._comment_content; }
            set { _comment_content = value; lbl_comment.Text = value; }
        }

        #endregion

    }
}

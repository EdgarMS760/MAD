using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD
{
    public partial class ResultsBible : UserControl
    {
        public ResultsBible()
        {

            InitializeComponent();
            PIC_UserControl_icon.Image = Properties.Resources.bookIcon;
        }


        private void PIC_UserControl_icon_Click(object sender, EventArgs e)
        {

        }
        #region properties
        private string _title;
        private string _message;
        private Image _icon;

        private void ResultsBible_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void ResultsBible_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                LBL_UserControl_Title.Text = value;
            }
        }
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                LBL_UserControl_Content.Text = value;
            }
        }
        public Image Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                PIC_UserControl_icon.Image = value;
            }
        }
        #endregion
    }
}

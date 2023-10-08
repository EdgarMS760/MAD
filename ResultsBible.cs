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
        }
        #region properties
        private string _title;
        private string _message;
        private Image _icon;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                LBL_UserControl_Title.Text = value;
            }
        }
        [Category("Custom Props")]
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

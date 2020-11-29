using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.UsrCtrlManage
{
    public partial class CategoryUsrCtrl : UserControl
    {
        public CategoryUsrCtrl()
        {
            InitializeComponent();
        }

       
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form formAccount = new FormAccount();
            formAccount.ShowDialog();
        }
    }
}

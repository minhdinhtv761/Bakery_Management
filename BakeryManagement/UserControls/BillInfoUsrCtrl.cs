using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace BakeryManagement.UserControls
{
    public partial class BillInfoUsrCtrl : UserControl
    {
        public BillInfoUsrCtrl()
        {
            InitializeComponent();
        }

        public void icTrash_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}

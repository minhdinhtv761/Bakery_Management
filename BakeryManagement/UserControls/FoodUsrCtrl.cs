using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryManagement.UserControls
{
    public partial class FoodUserControl : UserControl
    {
        private bool action; //Lưu hành động click
        public FoodUserControl()
        {
            InitializeComponent();
            this.action = false;
              }
 
        private void DoAction(bool act)
        {
            //Đổi màu nếu được click/chạm
            if (act == false)
            {
                this.shadowPanel.FillColor = StyleTheme.RGBs.color1;
                this.lbName.Font = StyleTheme.FontUserControl.activateFont;
            }
            else
            {
                this.shadowPanel.FillColor = Color.White;
                this.lbName.Font = StyleTheme.FontUserControl.defaultFont;
            }

        }
        public void btnImage_Click(object sender, EventArgs e)
        {
            DoAction(action);
            this.action = !action;
        }
        public void panelInfo_Click(object sender, EventArgs e)
        {
            DoAction(action);
            this.action = !action;
        }

        private void btnImage_MouseHover(object sender, EventArgs e)
        {
            DoAction(false);
        }

        private void btnImage_MouseLeave(object sender, EventArgs e)
        {
            if (action == false)
                DoAction(true);
        }

        private void btnImage_MouseDown(object sender, MouseEventArgs e)
        {
            this.shadowPanel.FillColor = StyleTheme.RGBs.color3;
            this.lbName.Font = StyleTheme.FontUserControl.activateFont;
        }


    }
}

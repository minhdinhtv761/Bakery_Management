using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.UsrCtrlMenu
{
    public partial class FoodInfoUsrCtrl : UserControl
    {
        public FoodInfoUsrCtrl()
        {
            InitializeComponent();
        }
        public Image PicFood
        {
            get { return this.picFood.Image; }
            set { this.picFood.Image = value; }
        }
        public string ItemName
        {
            get { return this.lbName.Text; }
            set { this.lbName.Text = value; }
        }
        public string Price
        {
            get { return this.lbPrice.Text; }
            set { this.lbPrice.Text = value; }
        }
        bool selectedItem = false;
        public void Activate()
        {
            this.lbPrice.BackColor = this.lbName.BackColor = Styles.RGBs.blue;
            this.lbName.ForeColor = Color.White;
            this.lbPrice.ForeColor = Color.White;
        }
        public void Disable()
        {
            this.lbPrice.BackColor = this.lbName.BackColor = SystemColors.Control;
            this.lbName.ForeColor = Styles.RGBs.blue;
            this.lbPrice.ForeColor = Styles.RGBs.pink;
        }

        private void MousseClick(object sender, EventArgs e)
        {
            this.Activate();
            selectedItem = true;
        }
        private void MousseDoubleClick(object sender, EventArgs e)
        {
            this.Disable();
            selectedItem = false;
        }
        private void MousseHover(object sender, EventArgs e)
        {
            this.Activate();
        }
        private void MousseLeave(object sender, EventArgs e)
        {
            if(!selectedItem)
                this.Disable();
        }
      
      
    }
}

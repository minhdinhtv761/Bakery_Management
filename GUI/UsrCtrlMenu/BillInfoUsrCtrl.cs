using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUI.DAL;

namespace GUI.UsrCtrlMenu
{
    public partial class BillInfoUsrCtrl : UserControl
    {
        public BillInfoUsrCtrl()
        {
            InitializeComponent();
            this.lbTotal.Text = this.lbPrice.Text;
        }

        public BillInfoUsrCtrl(int MaHD, string TenMA, int price, int count)
        {
            InitializeComponent();
            this.lbNO.Text = MaHD.ToString();
            this.lbName.Text = TenMA;
            this.lbPrice.Text = string.Format("{0:n0}", price).ToString();
            this.txbQTY.Text = count.ToString();
            this.lbTotal.Text= string.Format("{0:n0}", price * count).ToString();
        }

        public event EventHandler onValueChanged = null;
        public event EventHandler onDel = null;


        public int NO
        {
            get { return Convert.ToInt32(this.lbNO.Text); }
            set
            {
                this.lbNO.Text = value.ToString();
            }
        }
        public string ItemName
        {
            get { return this.lbName.Text; }
            set { this.lbName.Text = value; }
        }

        public string Price
        {
            get { return this.lbPrice.Text; }
            set
            {
                if (Convert.ToInt32(value) >= 0)
                {

                    this.lbPrice.Text = string.Format("{0:n0}", value);
                }
            }
        }

        public int QTY
        {
            get { return Convert.ToInt32(this.txbQTY.Text); }
            set
            {
                if (value > 0)
                    txbQTY.Text = value.ToString();
                else
                    txbQTY.Text = "1";
            }
        }
        public uint Total
        {
            get { return Convert.ToUInt32(lbTotal.Text); }
            set
            {
                lbTotal.Text = string.Format("{0:n0}", value);
            }
        }
        private void ComputeTotal()
        {
            uint total = Convert.ToUInt32(Price) * Convert.ToUInt32(QTY);
            Total = total;            
        }

        private void icBtnTrash_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (txbQTY.Text == null)
                txbQTY.Text = "1";
            else
                QTY++;
            OnQTYChanged();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (txbQTY.Text == null)
                txbQTY.Text = "1";
            else
                QTY--;
            OnQTYChanged();
        }

        private void txbQTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            OnQTYChanged();
        }
        private void txbQTY_TextChange(object sender, EventArgs e)
        {
            ComputeTotal();

            BillInfoDAL.Instance.UpdateBillInfo(int.Parse(this.lbName.Text), int.Parse(this.txbQTY.Text));
            if (onValueChanged != null)
            {
                onValueChanged.Invoke(this, new EventArgs());
            }
        }
        //#1
        public event System.EventHandler QTYChanged;
        //#2
        protected virtual void OnQTYChanged()
        {
            if ( QTYChanged!= null) QTYChanged(this, EventArgs.Empty);
        }
    }
}

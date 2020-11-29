using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using Bunifu.UI.WinForms.BunifuButton;
using System.Windows.Forms;
using GUI.DTO;
using GUI.DAL;

namespace GUI.UsrCtrlMenu
{
    public partial class MenuUsrCtrl : UserControl
    {

        public Panel bottomBorderBtn;
        public BunifuButton currButton;
        public MenuUsrCtrl()
        {
            InitializeComponent();
            bottomBorderBtn = new Panel();
            bottomBorderBtn.Size = new Size(69, 2);
            bottomBorderBtn.BackColor = Styles.RGBs.pink;
            pnList.Controls.Add(bottomBorderBtn);
            this.btnAll_Click(btnAll, new EventArgs());
        }
        private void ActivateButton(object senderButton)
        {
            if (senderButton != null)
            {
                //Button
                DisableButton();
                currButton = (BunifuButton)senderButton;
                currButton.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //Border Button
                bottomBorderBtn.Location = new Point(currButton.Location.X, 49);
                bottomBorderBtn.Visible = true;
                bottomBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currButton != null)
            {
                currButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.layoutPanel.Controls.Clear();
            LoadFood();
        }

        private void btnOrdered_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.layoutPanel.Controls.Clear();
            LoadBread();
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.layoutPanel.Controls.Clear();
            LoadCake();
        }

        void LoadCake()
        {
            List<FoodDTO> listFood = FoodDAL.Instance.GetFood();

            foreach (FoodDTO item in listFood)
            {

                FoodInfoUsrCtrl foodInfo = new FoodInfoUsrCtrl(item.TenMA, item.DonGia);
                if (item.MaLoai == "LOAI02")
                    this.layoutPanel.Controls.Add(foodInfo);
            }
        }
        void LoadBread()
        {
            List<FoodDTO> listFood = FoodDAL.Instance.GetFood();

            foreach (FoodDTO item in listFood)
            {

                FoodInfoUsrCtrl foodInfo = new FoodInfoUsrCtrl(item.TenMA, item.DonGia);
                if (item.MaLoai == "LOAI01")
                    this.layoutPanel.Controls.Add(foodInfo);
            }
        }
        void LoadFood()
        {
            List<FoodDTO> listFood = FoodDAL.Instance.GetFood();

            foreach (FoodDTO item in listFood)
            {

                FoodInfoUsrCtrl foodInfo = new FoodInfoUsrCtrl(item.TenMA, item.DonGia);

                this.layoutPanel.Controls.Add(foodInfo);
            }
        }

        private void insertFood()
        {
            /*FoodInfoUsrCtrl food = new GUI.UsrCtrlMenu.FoodInfoUsrCtrl();
            // 
            // food
            // 
            food.Cursor = System.Windows.Forms.Cursors.Hand;
            food.ItemName = "Item name";
            food.Location = new System.Drawing.Point(2, 3);
            food.Margin = new System.Windows.Forms.Padding(2, 3, 1, 1);
            food.PicFood = null;
            food.Price = "0";
            food.Size = new System.Drawing.Size(122, 147);
            food.TabIndex = 27;
            //
            // end
            //
            this.layoutPanel.Controls.Add(food);*/

        }
    }
}

namespace GUI
{
    partial class FormManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.pnControl = new System.Windows.Forms.Panel();
            this.minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnList = new System.Windows.Forms.Panel();
            this.pnLine = new System.Windows.Forms.Panel();
            this.btnInvoices = new FontAwesome.Sharp.IconButton();
            this.btnCagory = new FontAwesome.Sharp.IconButton();
            this.btnAccount = new FontAwesome.Sharp.IconButton();
            this.btnEmployee = new FontAwesome.Sharp.IconButton();
            this.btnTable = new FontAwesome.Sharp.IconButton();
            this.btnProduct = new FontAwesome.Sharp.IconButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnMain = new System.Windows.Forms.Panel();
            this.pages = new Bunifu.UI.WinForms.BunifuPages();
            this.PRODUCT = new System.Windows.Forms.TabPage();
            this.productUsrCtrl1 = new GUI.UsrCtrlManage.ProductUsrCtrl();
            this.TABLE = new System.Windows.Forms.TabPage();
            this.tableUsrCtrl1 = new GUI.UsrCtrlManage.TableUsrCtrl();
            this.CATEGORY = new System.Windows.Forms.TabPage();
            this.categoryUsrCtrl1 = new GUI.UsrCtrlManage.CategoryUsrCtrl();
            this.EMPLOYEE = new System.Windows.Forms.TabPage();
            this.employeeUsrCtrl1 = new GUI.UsrCtrlManage.EmployeeUsrCtrl();
            this.INVOICES = new System.Windows.Forms.TabPage();
            this.invoicesUsrCtrl1 = new GUI.UsrCtrlManage.InvoicesUsrCtrl();
            this.ACCOUNT = new System.Windows.Forms.TabPage();
            this.accountUsrCtrl1 = new GUI.UsrCtrlManage.AccountUsrCtrl();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.pnList.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.pages.SuspendLayout();
            this.PRODUCT.SuspendLayout();
            this.TABLE.SuspendLayout();
            this.CATEGORY.SuspendLayout();
            this.EMPLOYEE.SuspendLayout();
            this.INVOICES.SuspendLayout();
            this.ACCOUNT.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.pnControl.Controls.Add(this.minimize);
            this.pnControl.Controls.Add(this.close);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(1683, 44);
            this.pnControl.TabIndex = 0;
            // 
            // minimize
            // 
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageActive = null;
            this.minimize.Location = new System.Drawing.Point(1560, 7);
            this.minimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(51, 30);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 12;
            this.minimize.TabStop = false;
            this.minimize.Zoom = 10;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(1616, 7);
            this.close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(51, 30);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 11;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pnList
            // 
            this.pnList.BackColor = System.Drawing.SystemColors.Control;
            this.pnList.Controls.Add(this.pnLine);
            this.pnList.Controls.Add(this.btnInvoices);
            this.pnList.Controls.Add(this.btnCagory);
            this.pnList.Controls.Add(this.btnAccount);
            this.pnList.Controls.Add(this.btnEmployee);
            this.pnList.Controls.Add(this.btnTable);
            this.pnList.Controls.Add(this.btnProduct);
            this.pnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnList.Location = new System.Drawing.Point(0, 44);
            this.pnList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnList.Name = "pnList";
            this.pnList.Size = new System.Drawing.Size(1683, 64);
            this.pnList.TabIndex = 1;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnLine.Location = new System.Drawing.Point(0, 62);
            this.pnLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(1683, 2);
            this.pnLine.TabIndex = 15;
            // 
            // btnInvoices
            // 
            this.btnInvoices.BackColor = System.Drawing.Color.Transparent;
            this.btnInvoices.FlatAppearance.BorderSize = 0;
            this.btnInvoices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoices.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnInvoices.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnInvoices.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnInvoices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInvoices.IconSize = 18;
            this.btnInvoices.Location = new System.Drawing.Point(1091, -2);
            this.btnInvoices.Margin = new System.Windows.Forms.Padding(0);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(273, 66);
            this.btnInvoices.TabIndex = 16;
            this.btnInvoices.Text = "INVOICES";
            this.btnInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoices.UseVisualStyleBackColor = false;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnCagory
            // 
            this.btnCagory.BackColor = System.Drawing.Color.Transparent;
            this.btnCagory.FlatAppearance.BorderSize = 0;
            this.btnCagory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCagory.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCagory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnCagory.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnCagory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnCagory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCagory.IconSize = 18;
            this.btnCagory.Location = new System.Drawing.Point(547, -2);
            this.btnCagory.Margin = new System.Windows.Forms.Padding(0);
            this.btnCagory.Name = "btnCagory";
            this.btnCagory.Size = new System.Drawing.Size(273, 66);
            this.btnCagory.TabIndex = 14;
            this.btnCagory.Text = "CATEGORY";
            this.btnCagory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCagory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCagory.UseVisualStyleBackColor = false;
            this.btnCagory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnAccount.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnAccount.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccount.IconSize = 18;
            this.btnAccount.Location = new System.Drawing.Point(1364, -2);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(273, 66);
            this.btnAccount.TabIndex = 12;
            this.btnAccount.Text = "ACCOUNT";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnEmployee.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnEmployee.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmployee.IconSize = 18;
            this.btnEmployee.Location = new System.Drawing.Point(817, -2);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(273, 66);
            this.btnEmployee.TabIndex = 11;
            this.btnEmployee.Text = "EMPLOYEE";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.Transparent;
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnTable.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnTable.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTable.IconSize = 18;
            this.btnTable.Location = new System.Drawing.Point(273, -2);
            this.btnTable.Margin = new System.Windows.Forms.Padding(0);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(273, 66);
            this.btnTable.TabIndex = 10;
            this.btnTable.Text = "TABLE";
            this.btnTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnProduct.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnProduct.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(113)))));
            this.btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduct.IconSize = 18;
            this.btnProduct.Location = new System.Drawing.Point(0, -2);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(273, 66);
            this.btnProduct.TabIndex = 9;
            this.btnProduct.Text = "PRODUCT";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pages);
            this.pnMain.Location = new System.Drawing.Point(0, 107);
            this.pnMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1683, 692);
            this.pnMain.TabIndex = 2;
            // 
            // pages
            // 
            this.pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pages.AllowTransitions = false;
            this.pages.Controls.Add(this.PRODUCT);
            this.pages.Controls.Add(this.TABLE);
            this.pages.Controls.Add(this.CATEGORY);
            this.pages.Controls.Add(this.EMPLOYEE);
            this.pages.Controls.Add(this.INVOICES);
            this.pages.Controls.Add(this.ACCOUNT);
            this.pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pages.Location = new System.Drawing.Point(0, 0);
            this.pages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pages.Multiline = true;
            this.pages.Name = "pages";
            this.pages.Padding = new System.Drawing.Point(0, 0);
            this.pages.Page = this.TABLE;
            this.pages.PageIndex = 1;
            this.pages.PageName = "TABLE";
            this.pages.PageTitle = "TABLE";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(1683, 692);
            this.pages.TabIndex = 0;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.pages.Transition = animation1;
            this.pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // PRODUCT
            // 
            this.PRODUCT.Controls.Add(this.productUsrCtrl1);
            this.PRODUCT.Location = new System.Drawing.Point(4, 4);
            this.PRODUCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PRODUCT.Name = "PRODUCT";
            this.PRODUCT.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PRODUCT.Size = new System.Drawing.Size(1675, 663);
            this.PRODUCT.TabIndex = 0;
            this.PRODUCT.Text = "PRODUCT";
            this.PRODUCT.UseVisualStyleBackColor = true;
            // 
            // productUsrCtrl1
            // 
            this.productUsrCtrl1.BackColor = System.Drawing.Color.White;
            this.productUsrCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productUsrCtrl1.Location = new System.Drawing.Point(4, 4);
            this.productUsrCtrl1.Margin = new System.Windows.Forms.Padding(0);
            this.productUsrCtrl1.MaximumSize = new System.Drawing.Size(1683, 692);
            this.productUsrCtrl1.MinimumSize = new System.Drawing.Size(1683, 692);
            this.productUsrCtrl1.Name = "productUsrCtrl1";
            this.productUsrCtrl1.Size = new System.Drawing.Size(1683, 692);
            this.productUsrCtrl1.TabIndex = 0;
            // 
            // TABLE
            // 
            this.TABLE.Controls.Add(this.tableUsrCtrl1);
            this.TABLE.Location = new System.Drawing.Point(4, 4);
            this.TABLE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TABLE.Name = "TABLE";
            this.TABLE.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TABLE.Size = new System.Drawing.Size(1675, 663);
            this.TABLE.TabIndex = 1;
            this.TABLE.Text = "TABLE";
            this.TABLE.UseVisualStyleBackColor = true;
            // 
            // tableUsrCtrl1
            // 
            this.tableUsrCtrl1.BackColor = System.Drawing.Color.White;
            this.tableUsrCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableUsrCtrl1.Location = new System.Drawing.Point(4, 4);
            this.tableUsrCtrl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableUsrCtrl1.MaximumSize = new System.Drawing.Size(1683, 692);
            this.tableUsrCtrl1.MinimumSize = new System.Drawing.Size(1683, 692);
            this.tableUsrCtrl1.Name = "tableUsrCtrl1";
            this.tableUsrCtrl1.Size = new System.Drawing.Size(1683, 692);
            this.tableUsrCtrl1.TabIndex = 0;
            // 
            // CATEGORY
            // 
            this.CATEGORY.Controls.Add(this.categoryUsrCtrl1);
            this.CATEGORY.Location = new System.Drawing.Point(4, 4);
            this.CATEGORY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CATEGORY.Name = "CATEGORY";
            this.CATEGORY.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CATEGORY.Size = new System.Drawing.Size(1675, 663);
            this.CATEGORY.TabIndex = 2;
            this.CATEGORY.Text = "CATEGORY";
            this.CATEGORY.UseVisualStyleBackColor = true;
            // 
            // categoryUsrCtrl1
            // 
            this.categoryUsrCtrl1.BackColor = System.Drawing.Color.White;
            this.categoryUsrCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryUsrCtrl1.Location = new System.Drawing.Point(4, 4);
            this.categoryUsrCtrl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.categoryUsrCtrl1.MaximumSize = new System.Drawing.Size(1683, 692);
            this.categoryUsrCtrl1.MinimumSize = new System.Drawing.Size(1683, 692);
            this.categoryUsrCtrl1.Name = "categoryUsrCtrl1";
            this.categoryUsrCtrl1.Size = new System.Drawing.Size(1683, 692);
            this.categoryUsrCtrl1.TabIndex = 0;
            // 
            // EMPLOYEE
            // 
            this.EMPLOYEE.Controls.Add(this.employeeUsrCtrl1);
            this.EMPLOYEE.Location = new System.Drawing.Point(4, 4);
            this.EMPLOYEE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EMPLOYEE.Name = "EMPLOYEE";
            this.EMPLOYEE.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EMPLOYEE.Size = new System.Drawing.Size(1675, 663);
            this.EMPLOYEE.TabIndex = 3;
            this.EMPLOYEE.Text = "EMPLOYEE";
            this.EMPLOYEE.UseVisualStyleBackColor = true;
            // 
            // employeeUsrCtrl1
            // 
            this.employeeUsrCtrl1.BackColor = System.Drawing.Color.White;
            this.employeeUsrCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeUsrCtrl1.Location = new System.Drawing.Point(4, 4);
            this.employeeUsrCtrl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.employeeUsrCtrl1.MaximumSize = new System.Drawing.Size(1683, 692);
            this.employeeUsrCtrl1.MinimumSize = new System.Drawing.Size(1683, 692);
            this.employeeUsrCtrl1.Name = "employeeUsrCtrl1";
            this.employeeUsrCtrl1.Size = new System.Drawing.Size(1683, 692);
            this.employeeUsrCtrl1.TabIndex = 0;
            // 
            // INVOICES
            // 
            this.INVOICES.Controls.Add(this.invoicesUsrCtrl1);
            this.INVOICES.Location = new System.Drawing.Point(4, 4);
            this.INVOICES.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.INVOICES.Name = "INVOICES";
            this.INVOICES.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.INVOICES.Size = new System.Drawing.Size(1675, 663);
            this.INVOICES.TabIndex = 4;
            this.INVOICES.Text = "INVOICES";
            this.INVOICES.UseVisualStyleBackColor = true;
            // 
            // invoicesUsrCtrl1
            // 
            this.invoicesUsrCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoicesUsrCtrl1.Location = new System.Drawing.Point(4, 4);
            this.invoicesUsrCtrl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.invoicesUsrCtrl1.MaximumSize = new System.Drawing.Size(1683, 692);
            this.invoicesUsrCtrl1.MinimumSize = new System.Drawing.Size(1683, 692);
            this.invoicesUsrCtrl1.Name = "invoicesUsrCtrl1";
            this.invoicesUsrCtrl1.Size = new System.Drawing.Size(1683, 692);
            this.invoicesUsrCtrl1.TabIndex = 0;
            // 
            // ACCOUNT
            // 
            this.ACCOUNT.Controls.Add(this.accountUsrCtrl1);
            this.ACCOUNT.Location = new System.Drawing.Point(4, 4);
            this.ACCOUNT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ACCOUNT.Name = "ACCOUNT";
            this.ACCOUNT.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ACCOUNT.Size = new System.Drawing.Size(1675, 663);
            this.ACCOUNT.TabIndex = 5;
            this.ACCOUNT.Text = "ACCOUNT";
            this.ACCOUNT.UseVisualStyleBackColor = true;
            // 
            // accountUsrCtrl1
            // 
            this.accountUsrCtrl1.BackColor = System.Drawing.Color.White;
            this.accountUsrCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountUsrCtrl1.Location = new System.Drawing.Point(4, 4);
            this.accountUsrCtrl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.accountUsrCtrl1.MaximumSize = new System.Drawing.Size(1683, 692);
            this.accountUsrCtrl1.MinimumSize = new System.Drawing.Size(1683, 692);
            this.accountUsrCtrl1.Name = "accountUsrCtrl1";
            this.accountUsrCtrl1.Size = new System.Drawing.Size(1683, 692);
            this.accountUsrCtrl1.TabIndex = 0;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1683, 800);
            this.Controls.Add(this.pnList);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManager";
            this.pnControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.pnList.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.pages.ResumeLayout(false);
            this.PRODUCT.ResumeLayout(false);
            this.TABLE.ResumeLayout(false);
            this.CATEGORY.ResumeLayout(false);
            this.EMPLOYEE.ResumeLayout(false);
            this.INVOICES.ResumeLayout(false);
            this.ACCOUNT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuImageButton minimize;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Panel pnList;
        private FontAwesome.Sharp.IconButton btnAccount;
        private FontAwesome.Sharp.IconButton btnEmployee;
        private FontAwesome.Sharp.IconButton btnTable;
        private FontAwesome.Sharp.IconButton btnProduct;
        private System.Windows.Forms.Panel pnLine;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnMain;
        private FontAwesome.Sharp.IconButton btnInvoices;
        private FontAwesome.Sharp.IconButton btnCagory;
        private Bunifu.UI.WinForms.BunifuPages pages;
        private System.Windows.Forms.TabPage PRODUCT;
        private UsrCtrlManage.ProductUsrCtrl productUsrCtrl1;
        private System.Windows.Forms.TabPage TABLE;
        private System.Windows.Forms.TabPage CATEGORY;
        private System.Windows.Forms.TabPage EMPLOYEE;
        private UsrCtrlManage.EmployeeUsrCtrl employeeUsrCtrl1;
        private System.Windows.Forms.TabPage INVOICES;
        private System.Windows.Forms.TabPage ACCOUNT;
        private UsrCtrlManage.AccountUsrCtrl accountUsrCtrl1;
        private UsrCtrlManage.InvoicesUsrCtrl invoicesUsrCtrl1;
        private UsrCtrlManage.TableUsrCtrl tableUsrCtrl1;
        private UsrCtrlManage.CategoryUsrCtrl categoryUsrCtrl1;
    }
}
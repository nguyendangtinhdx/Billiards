namespace Billiards
{
    partial class frmTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableManager));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bắtĐầuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tênHiểnThịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTotalPriceFormat = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbSwitchTable = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMoneyPlayTime = new System.Windows.Forms.Label();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.txtTotalPriceBill = new System.Windows.Forms.TextBox();
            this.lbShowTime = new System.Windows.Forms.Label();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lbMinutePLayTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChangePlayTime = new System.Windows.Forms.Button();
            this.cbbStatusPlayTime = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbHourPLayTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPriceTimePlay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lbTotalPriceBillFormat = new System.Windows.Forms.Label();
            this.lbTotalPriceTimePlayFormat = new System.Windows.Forms.Label();
            this.lbMinute = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.Width = 54;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvBill.GridLines = true;
            this.lvBill.Location = new System.Drawing.Point(3, 3);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(407, 249);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 33;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên hàng";
            this.columnHeader2.Width = 162;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ĐVT";
            this.columnHeader3.Width = 39;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn giá";
            this.columnHeader5.Width = 55;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thành tiền";
            this.columnHeader6.Width = 63;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvBill);
            this.panel2.Location = new System.Drawing.Point(533, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 255);
            this.panel2.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thêmNợToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.tênHiểnThịToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1095, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Image = global::Billiards.Properties.Resources.manager;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.adminToolStripMenuItem.Text = "Quản lý thông tin quán";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thêmNợToolStripMenuItem
            // 
            this.thêmNợToolStripMenuItem.Image = global::Billiards.Properties.Resources.debt;
            this.thêmNợToolStripMenuItem.Name = "thêmNợToolStripMenuItem";
            this.thêmNợToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.thêmNợToolStripMenuItem.Text = "Quản lý nợ";
            this.thêmNợToolStripMenuItem.Click += new System.EventHandler(this.thêmNợToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bắtĐầuToolStripMenuItem,
            this.thêmMónToolStripMenuItem,
            this.chuyểnBànToolStripMenuItem,
            this.thanhToánToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Image = global::Billiards.Properties.Resources.shortcut;
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.chứcNăngToolStripMenuItem.Text = "Phím nhanh";
            // 
            // thêmMónToolStripMenuItem
            // 
            this.thêmMónToolStripMenuItem.Image = global::Billiards.Properties.Resources.add;
            this.thêmMónToolStripMenuItem.Name = "thêmMónToolStripMenuItem";
            this.thêmMónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.thêmMónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thêmMónToolStripMenuItem.Text = "Thêm hàng";
            this.thêmMónToolStripMenuItem.Click += new System.EventHandler(this.thêmMónToolStripMenuItem_Click);
            // 
            // chuyểnBànToolStripMenuItem
            // 
            this.chuyểnBànToolStripMenuItem.Image = global::Billiards.Properties.Resources.change;
            this.chuyểnBànToolStripMenuItem.Name = "chuyểnBànToolStripMenuItem";
            this.chuyểnBànToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.chuyểnBànToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chuyểnBànToolStripMenuItem.Text = "Chuyển bàn";
            this.chuyểnBànToolStripMenuItem.Click += new System.EventHandler(this.chuyểnBànToolStripMenuItem_Click);
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Image = global::Billiards.Properties.Resources.checkout;
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // bắtĐầuToolStripMenuItem
            // 
            this.bắtĐầuToolStripMenuItem.Image = global::Billiards.Properties.Resources.start;
            this.bắtĐầuToolStripMenuItem.Name = "bắtĐầuToolStripMenuItem";
            this.bắtĐầuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.bắtĐầuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bắtĐầuToolStripMenuItem.Text = "Bắt đầu";
            this.bắtĐầuToolStripMenuItem.Click += new System.EventHandler(this.bắtĐầuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::Billiards.Properties.Resources.logout;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // tênHiểnThịToolStripMenuItem
            // 
            this.tênHiểnThịToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tênHiểnThịToolStripMenuItem.Image = global::Billiards.Properties.Resources.user;
            this.tênHiểnThịToolStripMenuItem.Name = "tênHiểnThịToolStripMenuItem";
            this.tênHiểnThịToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.tênHiểnThịToolStripMenuItem.Text = "Người truy cập:";
            this.tênHiểnThịToolStripMenuItem.Click += new System.EventHandler(this.tênHiểnThịToolStripMenuItem_Click);
            // 
            // lbTotalPriceFormat
            // 
            this.lbTotalPriceFormat.AutoSize = true;
            this.lbTotalPriceFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPriceFormat.Location = new System.Drawing.Point(728, 409);
            this.lbTotalPriceFormat.Name = "lbTotalPriceFormat";
            this.lbTotalPriceFormat.Size = new System.Drawing.Size(16, 16);
            this.lbTotalPriceFormat.TabIndex = 23;
            this.lbTotalPriceFormat.Text = "0";
            this.lbTotalPriceFormat.Visible = false;
            this.lbTotalPriceFormat.TextChanged += new System.EventHandler(this.lbTotalPriceFormat_TextChanged);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(604, 443);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(61, 16);
            this.lbTotalPrice.TabIndex = 22;
            this.lbTotalPrice.Text = "Ba triệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bằng chữ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(532, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tiền hóa đơn:";
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(289, 28);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(121, 20);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbbFood
            // 
            this.cbbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Location = new System.Drawing.Point(74, 28);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(208, 21);
            this.cbbFood.TabIndex = 1;
            this.cbbFood.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbbFood_Format);
            // 
            // cbbCategory
            // 
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(74, 3);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(208, 21);
            this.cbbCategory.TabIndex = 0;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.cbbFood);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Controls.Add(this.cbbCategory);
            this.panel4.Location = new System.Drawing.Point(533, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 52);
            this.panel4.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(286, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Danh mục:";
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddFood.Image = global::Billiards.Properties.Resources.add;
            this.btnAddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.Location = new System.Drawing.Point(420, 6);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(125, 46);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm hàng";
            this.btnAddFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbSwitchTable);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbMoneyPlayTime);
            this.panel3.Controls.Add(this.nmDiscount);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Controls.Add(this.btnSwitchTable);
            this.panel3.Location = new System.Drawing.Point(533, 472);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 55);
            this.panel3.TabIndex = 18;
            // 
            // cbbSwitchTable
            // 
            this.cbbSwitchTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSwitchTable.FormattingEnabled = true;
            this.cbbSwitchTable.Location = new System.Drawing.Point(3, 30);
            this.cbbSwitchTable.Name = "cbbSwitchTable";
            this.cbbSwitchTable.Size = new System.Drawing.Size(125, 21);
            this.cbbSwitchTable.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(484, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "đ / 1h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giảm giá (%)";
            // 
            // lbMoneyPlayTime
            // 
            this.lbMoneyPlayTime.AutoSize = true;
            this.lbMoneyPlayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyPlayTime.ForeColor = System.Drawing.Color.Red;
            this.lbMoneyPlayTime.Location = new System.Drawing.Point(430, 18);
            this.lbMoneyPlayTime.Name = "lbMoneyPlayTime";
            this.lbMoneyPlayTime.Size = new System.Drawing.Size(19, 20);
            this.lbMoneyPlayTime.TabIndex = 29;
            this.lbMoneyPlayTime.Text = "0";
            this.lbMoneyPlayTime.TextChanged += new System.EventHandler(this.lbMoneyPlayTime_TextChanged);
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(160, 31);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(100, 20);
            this.nmDiscount.TabIndex = 4;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCheckOut.Image = global::Billiards.Properties.Resources.checkout;
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.Location = new System.Drawing.Point(288, 3);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(125, 46);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchTable.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSwitchTable.Image = global::Billiards.Properties.Resources.change;
            this.btnSwitchTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSwitchTable.Location = new System.Drawing.Point(3, 3);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(125, 25);
            this.btnSwitchTable.TabIndex = 6;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSwitchTable.UseVisualStyleBackColor = false;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // txtTotalPriceBill
            // 
            this.txtTotalPriceBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPriceBill.ForeColor = System.Drawing.Color.Red;
            this.txtTotalPriceBill.Location = new System.Drawing.Point(795, 340);
            this.txtTotalPriceBill.Name = "txtTotalPriceBill";
            this.txtTotalPriceBill.ReadOnly = true;
            this.txtTotalPriceBill.Size = new System.Drawing.Size(148, 26);
            this.txtTotalPriceBill.TabIndex = 14;
            this.txtTotalPriceBill.Text = "0";
            this.txtTotalPriceBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbShowTime
            // 
            this.lbShowTime.AutoSize = true;
            this.lbShowTime.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowTime.Location = new System.Drawing.Point(620, 4);
            this.lbShowTime.Name = "lbShowTime";
            this.lbShowTime.Size = new System.Drawing.Size(76, 16);
            this.lbShowTime.TabIndex = 24;
            this.lbShowTime.Text = "ShowTimer";
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 27);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(514, 500);
            this.flpTable.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lbMinutePLayTime);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnChangePlayTime);
            this.panel1.Controls.Add(this.cbbStatusPlayTime);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbHourPLayTime);
            this.panel1.Location = new System.Drawing.Point(949, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 348);
            this.panel1.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(58, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = ":";
            // 
            // lbMinutePLayTime
            // 
            this.lbMinutePLayTime.AutoSize = true;
            this.lbMinutePLayTime.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbMinutePLayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinutePLayTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbMinutePLayTime.Location = new System.Drawing.Point(70, 89);
            this.lbMinutePLayTime.Name = "lbMinutePLayTime";
            this.lbMinutePLayTime.Size = new System.Drawing.Size(19, 20);
            this.lbMinutePLayTime.TabIndex = 32;
            this.lbMinutePLayTime.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Chọn trạng thái:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(4, 275);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(124, 20);
            this.txtPassword.TabIndex = 30;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Mật khẩu:";
            // 
            // btnChangePlayTime
            // 
            this.btnChangePlayTime.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnChangePlayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePlayTime.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnChangePlayTime.Image = global::Billiards.Properties.Resources.refresh_money_playtime;
            this.btnChangePlayTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePlayTime.Location = new System.Drawing.Point(4, 299);
            this.btnChangePlayTime.Name = "btnChangePlayTime";
            this.btnChangePlayTime.Size = new System.Drawing.Size(125, 46);
            this.btnChangePlayTime.TabIndex = 28;
            this.btnChangePlayTime.Text = "Đổi tiền giờ";
            this.btnChangePlayTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePlayTime.UseVisualStyleBackColor = false;
            this.btnChangePlayTime.Click += new System.EventHandler(this.btnChangePlayTime_Click);
            // 
            // cbbStatusPlayTime
            // 
            this.cbbStatusPlayTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatusPlayTime.FormattingEnabled = true;
            this.cbbStatusPlayTime.Items.AddRange(new object[] {
            "Không máy lạnh",
            "Có máy lạnh"});
            this.cbbStatusPlayTime.Location = new System.Drawing.Point(4, 230);
            this.cbbStatusPlayTime.Name = "cbbStatusPlayTime";
            this.cbbStatusPlayTime.Size = new System.Drawing.Size(125, 21);
            this.cbbStatusPlayTime.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnStart.Image = global::Billiards.Properties.Resources.start;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 46);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Số giờ đã đánh:";
            // 
            // lbHourPLayTime
            // 
            this.lbHourPLayTime.AutoSize = true;
            this.lbHourPLayTime.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbHourPLayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHourPLayTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbHourPLayTime.Location = new System.Drawing.Point(24, 89);
            this.lbHourPLayTime.Name = "lbHourPLayTime";
            this.lbHourPLayTime.Size = new System.Drawing.Size(19, 20);
            this.lbHourPLayTime.TabIndex = 26;
            this.lbHourPLayTime.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(532, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tiền giờ:";
            // 
            // txtTotalPriceTimePlay
            // 
            this.txtTotalPriceTimePlay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPriceTimePlay.ForeColor = System.Drawing.Color.Red;
            this.txtTotalPriceTimePlay.Location = new System.Drawing.Point(795, 372);
            this.txtTotalPriceTimePlay.Name = "txtTotalPriceTimePlay";
            this.txtTotalPriceTimePlay.ReadOnly = true;
            this.txtTotalPriceTimePlay.Size = new System.Drawing.Size(148, 26);
            this.txtTotalPriceTimePlay.TabIndex = 26;
            this.txtTotalPriceTimePlay.Text = "0";
            this.txtTotalPriceTimePlay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(532, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tổng tiền thanh toán:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.txtTotalPrice.Location = new System.Drawing.Point(795, 404);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(148, 26);
            this.txtTotalPrice.TabIndex = 28;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTotalPriceBillFormat
            // 
            this.lbTotalPriceBillFormat.AutoSize = true;
            this.lbTotalPriceBillFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPriceBillFormat.Location = new System.Drawing.Point(728, 345);
            this.lbTotalPriceBillFormat.Name = "lbTotalPriceBillFormat";
            this.lbTotalPriceBillFormat.Size = new System.Drawing.Size(16, 16);
            this.lbTotalPriceBillFormat.TabIndex = 30;
            this.lbTotalPriceBillFormat.Text = "0";
            this.lbTotalPriceBillFormat.Visible = false;
            // 
            // lbTotalPriceTimePlayFormat
            // 
            this.lbTotalPriceTimePlayFormat.AutoSize = true;
            this.lbTotalPriceTimePlayFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPriceTimePlayFormat.Location = new System.Drawing.Point(728, 377);
            this.lbTotalPriceTimePlayFormat.Name = "lbTotalPriceTimePlayFormat";
            this.lbTotalPriceTimePlayFormat.Size = new System.Drawing.Size(16, 16);
            this.lbTotalPriceTimePlayFormat.TabIndex = 31;
            this.lbTotalPriceTimePlayFormat.Text = "0";
            this.lbTotalPriceTimePlayFormat.Visible = false;
            // 
            // lbMinute
            // 
            this.lbMinute.AutoSize = true;
            this.lbMinute.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinute.Location = new System.Drawing.Point(562, 4);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(47, 16);
            this.lbMinute.TabIndex = 32;
            this.lbMinute.Text = "Minute";
            this.lbMinute.Visible = false;
            this.lbMinute.TextChanged += new System.EventHandler(this.lbMinute_TextChanged);
            // 
            // frmTableManager
            // 
            this.AcceptButton = this.btnAddFood;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1095, 539);
            this.Controls.Add(this.lbMinute);
            this.Controls.Add(this.lbTotalPriceTimePlayFormat);
            this.Controls.Add(this.lbTotalPriceBillFormat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbShowTime);
            this.Controls.Add(this.txtTotalPriceTimePlay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbTotalPriceFormat);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtTotalPriceBill);
            this.Controls.Add(this.flpTable);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán Billiards";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTableManager_FormClosing);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tênHiểnThịToolStripMenuItem;
        private System.Windows.Forms.Label lbTotalPriceFormat;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.ComboBox cbbFood;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtTotalPriceBill;
        private System.Windows.Forms.Label lbShowTime;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbHourPLayTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalPriceTimePlay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem bắtĐầuToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lbTotalPriceBillFormat;
        private System.Windows.Forms.Label lbTotalPriceTimePlayFormat;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.Label lbMoneyPlayTime;
        private System.Windows.Forms.ComboBox cbbStatusPlayTime;
        private System.Windows.Forms.Button btnChangePlayTime;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbMinutePLayTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbbSwitchTable;
        private System.Windows.Forms.ToolStripMenuItem thêmNợToolStripMenuItem;

    }
}
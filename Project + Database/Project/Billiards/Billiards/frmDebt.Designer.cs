namespace Billiards
{
    partial class frmDebt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDebt));
            this.panel19 = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lbTotalPriceDebt = new System.Windows.Forms.Label();
            this.lbMinute = new System.Windows.Forms.Label();
            this.lbHour = new System.Windows.Forms.Label();
            this.lbDateCheckOut = new System.Windows.Forms.Label();
            this.lbDateCheckIn = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.nmMoney = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.panel32 = new System.Windows.Forms.Panel();
            this.cbbStatusDebt = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel36 = new System.Windows.Forms.Panel();
            this.cbbBill = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.panel37 = new System.Windows.Forms.Panel();
            this.txtNameDebt = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.panel38 = new System.Windows.Forms.Panel();
            this.txtIDDebt = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel39 = new System.Windows.Forms.Panel();
            this.panel40 = new System.Windows.Forms.Panel();
            this.dtgvDebt = new System.Windows.Forms.DataGridView();
            this.IDDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefreshDebt = new System.Windows.Forms.Button();
            this.btnShowDebt = new System.Windows.Forms.Button();
            this.btnEditDebt = new System.Windows.Forms.Button();
            this.btnAddDebt = new System.Windows.Forms.Button();
            this.panel19.SuspendLayout();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoney)).BeginInit();
            this.panel32.SuspendLayout();
            this.panel36.SuspendLayout();
            this.panel37.SuspendLayout();
            this.panel38.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel40.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDebt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.label39);
            this.panel19.Controls.Add(this.label35);
            this.panel19.Controls.Add(this.label36);
            this.panel19.Controls.Add(this.label37);
            this.panel19.Controls.Add(this.label38);
            this.panel19.Controls.Add(this.lbTotalPriceDebt);
            this.panel19.Controls.Add(this.lbMinute);
            this.panel19.Controls.Add(this.lbHour);
            this.panel19.Controls.Add(this.lbDateCheckOut);
            this.panel19.Controls.Add(this.lbDateCheckIn);
            this.panel19.Controls.Add(this.panel22);
            this.panel19.Controls.Add(this.panel32);
            this.panel19.Controls.Add(this.panel36);
            this.panel19.Controls.Add(this.panel37);
            this.panel19.Controls.Add(this.panel38);
            this.panel19.Location = new System.Drawing.Point(636, 6);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(295, 343);
            this.panel19.TabIndex = 9;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(191, 299);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(101, 13);
            this.label39.TabIndex = 18;
            this.label39.Text = "Tổng thành tiền:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(6, 321);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(55, 13);
            this.label35.TabIndex = 17;
            this.label35.Text = "Số phút:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(6, 299);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(47, 13);
            this.label36.TabIndex = 16;
            this.label36.Text = "Số giờ:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(6, 277);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(76, 13);
            this.label37.TabIndex = 15;
            this.label37.Text = "Ngày giờ ra:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(6, 255);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(86, 13);
            this.label38.TabIndex = 14;
            this.label38.Text = "Ngày giờ vào:";
            // 
            // lbTotalPriceDebt
            // 
            this.lbTotalPriceDebt.AutoSize = true;
            this.lbTotalPriceDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPriceDebt.Location = new System.Drawing.Point(191, 321);
            this.lbTotalPriceDebt.Name = "lbTotalPriceDebt";
            this.lbTotalPriceDebt.Size = new System.Drawing.Size(48, 13);
            this.lbTotalPriceDebt.TabIndex = 13;
            this.lbTotalPriceDebt.Text = "label35";
            // 
            // lbMinute
            // 
            this.lbMinute.AutoSize = true;
            this.lbMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinute.Location = new System.Drawing.Point(79, 321);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(48, 13);
            this.lbMinute.TabIndex = 12;
            this.lbMinute.Text = "label35";
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour.Location = new System.Drawing.Point(79, 299);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(48, 13);
            this.lbHour.TabIndex = 11;
            this.lbHour.Text = "label35";
            // 
            // lbDateCheckOut
            // 
            this.lbDateCheckOut.AutoSize = true;
            this.lbDateCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateCheckOut.Location = new System.Drawing.Point(92, 277);
            this.lbDateCheckOut.Name = "lbDateCheckOut";
            this.lbDateCheckOut.Size = new System.Drawing.Size(48, 13);
            this.lbDateCheckOut.TabIndex = 10;
            this.lbDateCheckOut.Text = "label35";
            // 
            // lbDateCheckIn
            // 
            this.lbDateCheckIn.AutoSize = true;
            this.lbDateCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateCheckIn.Location = new System.Drawing.Point(92, 255);
            this.lbDateCheckIn.Name = "lbDateCheckIn";
            this.lbDateCheckIn.Size = new System.Drawing.Size(48, 13);
            this.lbDateCheckIn.TabIndex = 9;
            this.lbDateCheckIn.Text = "label35";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.nmMoney);
            this.panel22.Controls.Add(this.label24);
            this.panel22.Location = new System.Drawing.Point(3, 103);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(289, 44);
            this.panel22.TabIndex = 3;
            // 
            // nmMoney
            // 
            this.nmMoney.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmMoney.Location = new System.Drawing.Point(92, 13);
            this.nmMoney.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmMoney.Name = "nmMoney";
            this.nmMoney.Size = new System.Drawing.Size(194, 20);
            this.nmMoney.TabIndex = 2;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(3, 13);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(78, 16);
            this.label24.TabIndex = 0;
            this.label24.Text = "Số tiền nợ:";
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.cbbStatusDebt);
            this.panel32.Controls.Add(this.label25);
            this.panel32.Location = new System.Drawing.Point(3, 153);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(289, 44);
            this.panel32.TabIndex = 4;
            // 
            // cbbStatusDebt
            // 
            this.cbbStatusDebt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatusDebt.FormattingEnabled = true;
            this.cbbStatusDebt.Items.AddRange(new object[] {
            "Chưa trả nợ",
            "Đã trả nợ"});
            this.cbbStatusDebt.Location = new System.Drawing.Point(92, 12);
            this.cbbStatusDebt.Name = "cbbStatusDebt";
            this.cbbStatusDebt.Size = new System.Drawing.Size(194, 21);
            this.cbbStatusDebt.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(3, 13);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 16);
            this.label25.TabIndex = 0;
            this.label25.Text = "Trạng thái:";
            // 
            // panel36
            // 
            this.panel36.Controls.Add(this.cbbBill);
            this.panel36.Controls.Add(this.label26);
            this.panel36.Location = new System.Drawing.Point(3, 203);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(289, 44);
            this.panel36.TabIndex = 5;
            // 
            // cbbBill
            // 
            this.cbbBill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBill.FormattingEnabled = true;
            this.cbbBill.Location = new System.Drawing.Point(6, 20);
            this.cbbBill.Name = "cbbBill";
            this.cbbBill.Size = new System.Drawing.Size(280, 21);
            this.cbbBill.TabIndex = 1;
            this.cbbBill.SelectedIndexChanged += new System.EventHandler(this.cbbBill_SelectedIndexChanged);
            this.cbbBill.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbbBill_Format);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 2);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(264, 16);
            this.label26.TabIndex = 0;
            this.label26.Text = "Số hóa đơn - Ngày giờ thanh toán - Bàn:";
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.txtNameDebt);
            this.panel37.Controls.Add(this.label27);
            this.panel37.Location = new System.Drawing.Point(3, 53);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(289, 44);
            this.panel37.TabIndex = 2;
            // 
            // txtNameDebt
            // 
            this.txtNameDebt.Location = new System.Drawing.Point(92, 12);
            this.txtNameDebt.Name = "txtNameDebt";
            this.txtNameDebt.Size = new System.Drawing.Size(194, 20);
            this.txtNameDebt.TabIndex = 1;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 13);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(72, 16);
            this.label27.TabIndex = 0;
            this.label27.Text = "Người nợ:";
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.txtIDDebt);
            this.panel38.Controls.Add(this.label28);
            this.panel38.Location = new System.Drawing.Point(3, 3);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(289, 44);
            this.panel38.TabIndex = 1;
            // 
            // txtIDDebt
            // 
            this.txtIDDebt.Location = new System.Drawing.Point(92, 12);
            this.txtIDDebt.Name = "txtIDDebt";
            this.txtIDDebt.ReadOnly = true;
            this.txtIDDebt.Size = new System.Drawing.Size(194, 20);
            this.txtIDDebt.TabIndex = 1;
            this.txtIDDebt.TextChanged += new System.EventHandler(this.txtIDDebt_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(3, 13);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 16);
            this.label28.TabIndex = 0;
            this.label28.Text = "Mã nợ:";
            // 
            // panel39
            // 
            this.panel39.Controls.Add(this.btnShowDebt);
            this.panel39.Controls.Add(this.btnEditDebt);
            this.panel39.Controls.Add(this.btnAddDebt);
            this.panel39.Location = new System.Drawing.Point(12, 6);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(404, 52);
            this.panel39.TabIndex = 10;
            // 
            // panel40
            // 
            this.panel40.Controls.Add(this.dtgvDebt);
            this.panel40.Location = new System.Drawing.Point(12, 63);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(618, 338);
            this.panel40.TabIndex = 11;
            // 
            // dtgvDebt
            // 
            this.dtgvDebt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDebt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDebt,
            this.NameDebt,
            this.Money,
            this.StatusDebt,
            this.IDBill});
            this.dtgvDebt.Location = new System.Drawing.Point(3, 3);
            this.dtgvDebt.Name = "dtgvDebt";
            this.dtgvDebt.ReadOnly = true;
            this.dtgvDebt.Size = new System.Drawing.Size(612, 332);
            this.dtgvDebt.TabIndex = 0;
            // 
            // IDDebt
            // 
            this.IDDebt.DataPropertyName = "IDDebt";
            this.IDDebt.HeaderText = "Mã nợ";
            this.IDDebt.Name = "IDDebt";
            this.IDDebt.ReadOnly = true;
            // 
            // NameDebt
            // 
            this.NameDebt.DataPropertyName = "NameDebt";
            this.NameDebt.HeaderText = "Người nợ";
            this.NameDebt.Name = "NameDebt";
            this.NameDebt.ReadOnly = true;
            // 
            // Money
            // 
            this.Money.DataPropertyName = "Money";
            this.Money.HeaderText = "Số tiền";
            this.Money.Name = "Money";
            this.Money.ReadOnly = true;
            // 
            // StatusDebt
            // 
            this.StatusDebt.DataPropertyName = "StatusDebt";
            this.StatusDebt.HeaderText = "Trạng thái";
            this.StatusDebt.Name = "StatusDebt";
            this.StatusDebt.ReadOnly = true;
            // 
            // IDBill
            // 
            this.IDBill.DataPropertyName = "IDBill";
            this.IDBill.HeaderText = "Mã hóa đơn";
            this.IDBill.Name = "IDBill";
            this.IDBill.ReadOnly = true;
            // 
            // btnRefreshDebt
            // 
            this.btnRefreshDebt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRefreshDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDebt.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRefreshDebt.Image = global::Billiards.Properties.Resources.eraser;
            this.btnRefreshDebt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshDebt.Location = new System.Drawing.Point(636, 352);
            this.btnRefreshDebt.Name = "btnRefreshDebt";
            this.btnRefreshDebt.Size = new System.Drawing.Size(125, 46);
            this.btnRefreshDebt.TabIndex = 20;
            this.btnRefreshDebt.Text = "Làm mới";
            this.btnRefreshDebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshDebt.UseVisualStyleBackColor = false;
            this.btnRefreshDebt.Click += new System.EventHandler(this.btnRefreshDebt_Click);
            // 
            // btnShowDebt
            // 
            this.btnShowDebt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShowDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDebt.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnShowDebt.Image = global::Billiards.Properties.Resources.look;
            this.btnShowDebt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowDebt.Location = new System.Drawing.Point(265, 3);
            this.btnShowDebt.Name = "btnShowDebt";
            this.btnShowDebt.Size = new System.Drawing.Size(136, 46);
            this.btnShowDebt.TabIndex = 4;
            this.btnShowDebt.Text = "Xem tất cả";
            this.btnShowDebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowDebt.UseVisualStyleBackColor = false;
            this.btnShowDebt.Click += new System.EventHandler(this.btnShowDebt_Click);
            // 
            // btnEditDebt
            // 
            this.btnEditDebt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDebt.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEditDebt.Image = global::Billiards.Properties.Resources.edit;
            this.btnEditDebt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDebt.Location = new System.Drawing.Point(134, 3);
            this.btnEditDebt.Name = "btnEditDebt";
            this.btnEditDebt.Size = new System.Drawing.Size(125, 46);
            this.btnEditDebt.TabIndex = 2;
            this.btnEditDebt.Text = "Sửa";
            this.btnEditDebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditDebt.UseVisualStyleBackColor = false;
            this.btnEditDebt.Click += new System.EventHandler(this.btnEditDebt_Click);
            // 
            // btnAddDebt
            // 
            this.btnAddDebt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddDebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDebt.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddDebt.Image = global::Billiards.Properties.Resources.add;
            this.btnAddDebt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDebt.Location = new System.Drawing.Point(3, 3);
            this.btnAddDebt.Name = "btnAddDebt";
            this.btnAddDebt.Size = new System.Drawing.Size(125, 46);
            this.btnAddDebt.TabIndex = 1;
            this.btnAddDebt.Text = "Thêm";
            this.btnAddDebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddDebt.UseVisualStyleBackColor = false;
            this.btnAddDebt.Click += new System.EventHandler(this.btnAddDebt_Click);
            // 
            // frmDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(944, 415);
            this.Controls.Add(this.btnRefreshDebt);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel39);
            this.Controls.Add(this.panel40);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDebt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nợ";
            this.Load += new System.EventHandler(this.frmDebt_Load);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMoney)).EndInit();
            this.panel32.ResumeLayout(false);
            this.panel32.PerformLayout();
            this.panel36.ResumeLayout(false);
            this.panel36.PerformLayout();
            this.panel37.ResumeLayout(false);
            this.panel37.PerformLayout();
            this.panel38.ResumeLayout(false);
            this.panel38.PerformLayout();
            this.panel39.ResumeLayout(false);
            this.panel40.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDebt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lbTotalPriceDebt;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Label lbDateCheckOut;
        private System.Windows.Forms.Label lbDateCheckIn;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.NumericUpDown nmMoney;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.ComboBox cbbStatusDebt;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.ComboBox cbbBill;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.TextBox txtNameDebt;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.TextBox txtIDDebt;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.Button btnShowDebt;
        private System.Windows.Forms.Button btnEditDebt;
        private System.Windows.Forms.Button btnAddDebt;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.DataGridView dtgvDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBill;
        private System.Windows.Forms.Button btnRefreshDebt;
    }
}
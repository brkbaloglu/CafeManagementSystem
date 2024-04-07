namespace CafeManagementSystem
{
    partial class UserOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOrder = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.textboxItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboboxCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLogin = new Guna.UI2.WinForms.Guna2Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.labelDate);
            this.groupBox1.Controls.Add(this.buttonOrder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textboxAmount);
            this.groupBox1.Controls.Add(this.textboxItemName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboboxCategory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridViewMenu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(222, -11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 625);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.LightCoral;
            this.buttonOrder.BorderRadius = 20;
            this.buttonOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonOrder.FillColor = System.Drawing.Color.White;
            this.buttonOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonOrder.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonOrder.Location = new System.Drawing.Point(122, 422);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(180, 45);
            this.buttonOrder.TabIndex = 27;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Item Name";
            // 
            // textboxAmount
            // 
            this.textboxAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxAmount.DefaultText = "";
            this.textboxAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxAmount.Location = new System.Drawing.Point(150, 315);
            this.textboxAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxAmount.Name = "textboxAmount";
            this.textboxAmount.PasswordChar = '\0';
            this.textboxAmount.PlaceholderText = "";
            this.textboxAmount.SelectedText = "";
            this.textboxAmount.Size = new System.Drawing.Size(229, 48);
            this.textboxAmount.TabIndex = 24;
            // 
            // textboxItemName
            // 
            this.textboxItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxItemName.DefaultText = "";
            this.textboxItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxItemName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxItemName.Location = new System.Drawing.Point(150, 259);
            this.textboxItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxItemName.Name = "textboxItemName";
            this.textboxItemName.PasswordChar = '\0';
            this.textboxItemName.PlaceholderText = "";
            this.textboxItemName.SelectedText = "";
            this.textboxItemName.Size = new System.Drawing.Size(229, 48);
            this.textboxItemName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(535, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Category";
            // 
            // comboboxCategory
            // 
            this.comboboxCategory.BackColor = System.Drawing.Color.Transparent;
            this.comboboxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboboxCategory.ItemHeight = 30;
            this.comboboxCategory.Items.AddRange(new object[] {
            "All",
            "Food",
            "Beverage"});
            this.comboboxCategory.Location = new System.Drawing.Point(647, 162);
            this.comboboxCategory.Name = "comboboxCategory";
            this.comboboxCategory.Size = new System.Drawing.Size(145, 36);
            this.comboboxCategory.TabIndex = 10;
            this.comboboxCategory.SelectionChangeCommitted += new System.EventHandler(this.comboboxCategory_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(365, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 41);
            this.label3.TabIndex = 9;
            this.label3.Tag = "";
            this.label3.Text = "Order";
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(399, 218);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.RowTemplate.Height = 24;
            this.dataGridViewMenu.Size = new System.Drawing.Size(548, 359);
            this.dataGridViewMenu.TabIndex = 8;
            this.dataGridViewMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(923, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 20;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.LightCoral;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(23, 352);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(180, 45);
            this.guna2Button3.TabIndex = 27;
            this.guna2Button3.Text = "User Details";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUsername.ForeColor = System.Drawing.Color.LightCoral;
            this.labelUsername.Location = new System.Drawing.Point(58, 81);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(104, 28);
            this.labelUsername.TabIndex = 23;
            this.labelUsername.Text = "Username";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.LightCoral;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(23, 425);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 26;
            this.guna2Button2.Text = "Logout";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.LightCoral;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(23, 209);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 25;
            this.guna2Button1.Text = "Home";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BorderRadius = 20;
            this.buttonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLogin.FillColor = System.Drawing.Color.LightCoral;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(23, 280);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(180, 45);
            this.buttonLogin.TabIndex = 24;
            this.buttonLogin.Text = "Menu";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(795, 92);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(54, 28);
            this.labelDate.TabIndex = 28;
            this.labelDate.Text = "Date";
            // 
            // UserOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserOrder";
            this.Load += new System.EventHandler(this.UserOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Label labelUsername;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button buttonLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox textboxAmount;
        private Guna.UI2.WinForms.Guna2TextBox textboxItemName;
        private Guna.UI2.WinForms.Guna2Button buttonOrder;
        private System.Windows.Forms.Label labelDate;
    }
}
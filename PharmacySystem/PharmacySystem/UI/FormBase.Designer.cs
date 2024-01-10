
namespace PharmacySystem.UI
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnManufactures = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCategory = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStock = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSelling = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.sidebarTimer_Trick = new System.Windows.Forms.Timer(this.components);
            this.panel13 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfile)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.sidebar.Controls.Add(this.btnProfile);
            this.sidebar.Controls.Add(this.panel11);
            this.sidebar.Controls.Add(this.panel10);
            this.sidebar.Controls.Add(this.panel9);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.btnLogOut);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(193, 768);
            this.sidebar.MinimumSize = new System.Drawing.Size(74, 768);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(193, 768);
            this.sidebar.TabIndex = 4;
            // 
            // btnProfile
            // 
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.Location = new System.Drawing.Point(98, 690);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(34, 35);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.TabStop = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnProfile.MouseEnter += new System.EventHandler(this.btnProfile_MouseEnter);
            this.btnProfile.MouseLeave += new System.EventHandler(this.btnProfile_MouseLeave);
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(193, 48);
            this.panel11.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.btnUsers);
            this.panel10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(7, 518);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(242, 55);
            this.panel10.TabIndex = 3;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(-9, -8);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUsers.Size = new System.Drawing.Size(289, 72);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "               Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            this.btnUsers.MouseEnter += new System.EventHandler(this.btnUsers_MouseEnter);
            this.btnUsers.MouseLeave += new System.EventHandler(this.btnUsers_MouseLeave);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.btnTransactions);
            this.panel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(7, 459);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(242, 55);
            this.panel9.TabIndex = 2;
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.btnTransactions.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.Image = ((System.Drawing.Image)(resources.GetObject("btnTransactions.Image")));
            this.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.Location = new System.Drawing.Point(-9, -8);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTransactions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTransactions.Size = new System.Drawing.Size(289, 72);
            this.btnTransactions.TabIndex = 1;
            this.btnTransactions.Text = "               Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            this.btnTransactions.MouseEnter += new System.EventHandler(this.btnTransactions_MouseEnter);
            this.btnTransactions.MouseLeave += new System.EventHandler(this.btnTransactions_MouseLeave);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.btnManufactures);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(6, 401);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(242, 55);
            this.panel8.TabIndex = 1;
            // 
            // btnManufactures
            // 
            this.btnManufactures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.btnManufactures.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManufactures.ForeColor = System.Drawing.Color.White;
            this.btnManufactures.Image = ((System.Drawing.Image)(resources.GetObject("btnManufactures.Image")));
            this.btnManufactures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManufactures.Location = new System.Drawing.Point(-8, -8);
            this.btnManufactures.Name = "btnManufactures";
            this.btnManufactures.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnManufactures.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnManufactures.Size = new System.Drawing.Size(289, 72);
            this.btnManufactures.TabIndex = 1;
            this.btnManufactures.Text = "               Manufactures";
            this.btnManufactures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManufactures.UseVisualStyleBackColor = false;
            this.btnManufactures.Click += new System.EventHandler(this.btnManufactures_Click);
            this.btnManufactures.MouseEnter += new System.EventHandler(this.btnManufactures_MouseEnter);
            this.btnManufactures.MouseLeave += new System.EventHandler(this.btnManufactures_MouseLeave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.btnCategory);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(6, 343);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(242, 55);
            this.panel7.TabIndex = 1;
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(-9, -8);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCategory.Size = new System.Drawing.Size(261, 72);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "               Category";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            this.btnCategory.MouseEnter += new System.EventHandler(this.btnCategory_MouseEnter);
            this.btnCategory.MouseLeave += new System.EventHandler(this.btnCategory_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnStock);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(6, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 55);
            this.panel3.TabIndex = 0;
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.btnStock.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(-9, -8);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStock.Size = new System.Drawing.Size(261, 72);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "               Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            this.btnStock.MouseEnter += new System.EventHandler(this.btnStock_MouseEnter);
            this.btnStock.MouseLeave += new System.EventHandler(this.btnStock_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(6, 227);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 55);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.btnSelling);
            this.panel6.Location = new System.Drawing.Point(8, 8);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(256, 55);
            this.panel6.TabIndex = 2;
            // 
            // btnSelling
            // 
            this.btnSelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.btnSelling.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelling.ForeColor = System.Drawing.Color.White;
            this.btnSelling.Image = ((System.Drawing.Image)(resources.GetObject("btnSelling.Image")));
            this.btnSelling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelling.Location = new System.Drawing.Point(-18, -14);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSelling.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelling.Size = new System.Drawing.Size(262, 72);
            this.btnSelling.TabIndex = 1;
            this.btnSelling.Text = "               Selling";
            this.btnSelling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelling.UseVisualStyleBackColor = false;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            this.btnSelling.MouseEnter += new System.EventHandler(this.btnSelling_MouseEnter);
            this.btnSelling.MouseLeave += new System.EventHandler(this.btnSelling_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-9, -8);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(289, 72);
            this.button3.TabIndex = 1;
            this.button3.Text = "             Home";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btnHome);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(6, 169);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 55);
            this.panel4.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-9, -8);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHome.Size = new System.Drawing.Size(261, 72);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "               Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(23, 690);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(34, 35);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseEnter += new System.EventHandler(this.btnLogOut_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogOut_MouseLeave);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(26, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(30, 27);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // sidebarTimer_Trick
            // 
            this.sidebarTimer_Trick.Interval = 10;
            this.sidebarTimer_Trick.Tick += new System.EventHandler(this.sidebarTimerTick);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.panel13.Controls.Add(this.btnMenu);
            this.panel13.Controls.Add(this.label2);
            this.panel13.Controls.Add(this.btnExit);
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1366, 48);
            this.panel13.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(95, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIBM PHARMACY | MANAGEMENT SYSTEM";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1320, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 26);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.sidebar);
            this.ForeColor = System.Drawing.Color.Turquoise;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnProfile)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.PictureBox btnLogOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnManufactures;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Timer sidebarTimer_Trick;
        private System.Windows.Forms.PictureBox btnProfile;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnExit;
    }
}
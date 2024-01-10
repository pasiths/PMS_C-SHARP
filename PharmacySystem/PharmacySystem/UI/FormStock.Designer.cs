
namespace PharmacySystem
{
    partial class FormStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStock));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMedicines = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMedicineStock = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblMedicineID = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtManufacturerName = new System.Windows.Forms.TextBox();
            this.cmbMan_id = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStockMedicineName = new System.Windows.Forms.Label();
            this.lblStockMedicineType = new System.Windows.Forms.Label();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.lblStockPrice = new System.Windows.Forms.Label();
            this.lblStockManufacturer = new System.Windows.Forms.Label();
            this.lblStockManufacturerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.lblMedicines);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblMedicineID);
            this.panel1.Controls.Add(this.dgvStock);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtManufacturerName);
            this.panel1.Controls.Add(this.cmbMan_id);
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblStockMedicineName);
            this.panel1.Controls.Add(this.lblStockMedicineType);
            this.panel1.Controls.Add(this.lblStockQty);
            this.panel1.Controls.Add(this.lblStockPrice);
            this.panel1.Controls.Add(this.lblStockManufacturer);
            this.panel1.Controls.Add(this.lblStockManufacturerName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 772);
            this.panel1.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1025, 250);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 36);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMedicines
            // 
            this.lblMedicines.AutoSize = true;
            this.lblMedicines.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.lblMedicines.Location = new System.Drawing.Point(527, 56);
            this.lblMedicines.Name = "lblMedicines";
            this.lblMedicines.Size = new System.Drawing.Size(108, 40);
            this.lblMedicines.TabIndex = 26;
            this.lblMedicines.Text = "STOCK";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblMedicineStock);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(42, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 33);
            this.panel2.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1088, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // lblMedicineStock
            // 
            this.lblMedicineStock.AutoSize = true;
            this.lblMedicineStock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineStock.ForeColor = System.Drawing.Color.White;
            this.lblMedicineStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMedicineStock.Location = new System.Drawing.Point(3, 1);
            this.lblMedicineStock.Name = "lblMedicineStock";
            this.lblMedicineStock.Size = new System.Drawing.Size(187, 32);
            this.lblMedicineStock.TabIndex = 5;
            this.lblMedicineStock.Text = "Medicine Stock";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.txtSearch.Location = new System.Drawing.Point(793, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(294, 26);
            this.txtSearch.TabIndex = 49;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(175, 157);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(323, 24);
            this.txtID.TabIndex = 25;
            // 
            // lblMedicineID
            // 
            this.lblMedicineID.AutoSize = true;
            this.lblMedicineID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.lblMedicineID.Location = new System.Drawing.Point(38, 159);
            this.lblMedicineID.Name = "lblMedicineID";
            this.lblMedicineID.Size = new System.Drawing.Size(102, 21);
            this.lblMedicineID.TabIndex = 24;
            this.lblMedicineID.Text = "Medicine ID";
            // 
            // dgvStock
            // 
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(42, 339);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.Size = new System.Drawing.Size(1121, 368);
            this.dgvStock.TabIndex = 23;
            this.dgvStock.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStock_RowHeaderMouseClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(593, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 36);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(737, 250);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(138, 36);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(881, 250);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 36);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtManufacturerName
            // 
            this.txtManufacturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturerName.Location = new System.Drawing.Point(1004, 193);
            this.txtManufacturerName.Name = "txtManufacturerName";
            this.txtManufacturerName.Size = new System.Drawing.Size(159, 24);
            this.txtManufacturerName.TabIndex = 19;
            // 
            // cmbMan_id
            // 
            this.cmbMan_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMan_id.FormattingEnabled = true;
            this.cmbMan_id.Location = new System.Drawing.Point(1004, 156);
            this.cmbMan_id.Name = "cmbMan_id";
            this.cmbMan_id.Size = new System.Drawing.Size(157, 26);
            this.cmbMan_id.TabIndex = 18;
            this.cmbMan_id.SelectedIndexChanged += new System.EventHandler(this.cmbMan_id_SelectedIndexChanged);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(632, 157);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(158, 24);
            this.txtQty.TabIndex = 17;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(631, 193);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(159, 24);
            this.txtPrice.TabIndex = 16;
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(175, 230);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(157, 26);
            this.cmbType.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(175, 193);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(323, 24);
            this.txtName.TabIndex = 14;
            // 
            // lblStockMedicineName
            // 
            this.lblStockMedicineName.AutoSize = true;
            this.lblStockMedicineName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMedicineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.lblStockMedicineName.Location = new System.Drawing.Point(38, 195);
            this.lblStockMedicineName.Name = "lblStockMedicineName";
            this.lblStockMedicineName.Size = new System.Drawing.Size(131, 21);
            this.lblStockMedicineName.TabIndex = 13;
            this.lblStockMedicineName.Text = "Medicine Name";
            // 
            // lblStockMedicineType
            // 
            this.lblStockMedicineType.AutoSize = true;
            this.lblStockMedicineType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMedicineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.lblStockMedicineType.Location = new System.Drawing.Point(38, 233);
            this.lblStockMedicineType.Name = "lblStockMedicineType";
            this.lblStockMedicineType.Size = new System.Drawing.Size(121, 21);
            this.lblStockMedicineType.TabIndex = 12;
            this.lblStockMedicineType.Text = "Medicine Type";
            // 
            // lblStockQty
            // 
            this.lblStockQty.AutoSize = true;
            this.lblStockQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.lblStockQty.Location = new System.Drawing.Point(530, 159);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(77, 21);
            this.lblStockQty.TabIndex = 11;
            this.lblStockQty.Text = "Quantity";
            // 
            // lblStockPrice
            // 
            this.lblStockPrice.AutoSize = true;
            this.lblStockPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.lblStockPrice.Location = new System.Drawing.Point(530, 195);
            this.lblStockPrice.Name = "lblStockPrice";
            this.lblStockPrice.Size = new System.Drawing.Size(48, 21);
            this.lblStockPrice.TabIndex = 10;
            this.lblStockPrice.Text = "Price";
            // 
            // lblStockManufacturer
            // 
            this.lblStockManufacturer.AutoSize = true;
            this.lblStockManufacturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockManufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.lblStockManufacturer.Location = new System.Drawing.Point(828, 159);
            this.lblStockManufacturer.Name = "lblStockManufacturer";
            this.lblStockManufacturer.Size = new System.Drawing.Size(135, 21);
            this.lblStockManufacturer.TabIndex = 9;
            this.lblStockManufacturer.Text = "Manufacturer ID";
            // 
            // lblStockManufacturerName
            // 
            this.lblStockManufacturerName.AutoSize = true;
            this.lblStockManufacturerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockManufacturerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.lblStockManufacturerName.Location = new System.Drawing.Point(828, 195);
            this.lblStockManufacturerName.Name = "lblStockManufacturerName";
            this.lblStockManufacturerName.Size = new System.Drawing.Size(164, 21);
            this.lblStockManufacturerName.TabIndex = 8;
            this.lblStockManufacturerName.Text = "Manufacturer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(36, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Medicine Details";
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStock";
            this.Text = "FormStock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStockMedicineName;
        private System.Windows.Forms.Label lblStockMedicineType;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.Label lblStockPrice;
        private System.Windows.Forms.Label lblStockManufacturer;
        private System.Windows.Forms.Label lblStockManufacturerName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtManufacturerName;
        private System.Windows.Forms.ComboBox cmbMan_id;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblMedicineID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMedicineStock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMedicines;
        private System.Windows.Forms.Button btnReset;
    }
}
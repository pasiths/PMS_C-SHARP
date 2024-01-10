
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStockManufacturerName = new System.Windows.Forms.Label();
            this.lblStockManufacturer = new System.Windows.Forms.Label();
            this.lblStockPrice = new System.Windows.Forms.Label();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.lblStockMedicineType = new System.Windows.Forms.Label();
            this.lblStockMedicineName = new System.Windows.Forms.Label();
            this.txtStockMedicineName = new System.Windows.Forms.TextBox();
            this.comboBoxStockMedicineType = new System.Windows.Forms.ComboBox();
            this.txtStockPrice = new System.Windows.Forms.TextBox();
            this.txtStockQty = new System.Windows.Forms.TextBox();
            this.comboBoxStockManufacturer = new System.Windows.Forms.ComboBox();
            this.txtStockManufacturerName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "MEDICINS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtStockManufacturerName);
            this.panel1.Controls.Add(this.comboBoxStockManufacturer);
            this.panel1.Controls.Add(this.txtStockQty);
            this.panel1.Controls.Add(this.txtStockPrice);
            this.panel1.Controls.Add(this.comboBoxStockMedicineType);
            this.panel1.Controls.Add(this.txtStockMedicineName);
            this.panel1.Controls.Add(this.lblStockMedicineName);
            this.panel1.Controls.Add(this.lblStockMedicineType);
            this.panel1.Controls.Add(this.lblStockQty);
            this.panel1.Controls.Add(this.lblStockPrice);
            this.panel1.Controls.Add(this.lblStockManufacturer);
            this.panel1.Controls.Add(this.lblStockManufacturerName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 732);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Medicine Details";
            // 
            // lblStockManufacturerName
            // 
            this.lblStockManufacturerName.AutoSize = true;
            this.lblStockManufacturerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockManufacturerName.Location = new System.Drawing.Point(641, 180);
            this.lblStockManufacturerName.Name = "lblStockManufacturerName";
            this.lblStockManufacturerName.Size = new System.Drawing.Size(164, 21);
            this.lblStockManufacturerName.TabIndex = 8;
            this.lblStockManufacturerName.Text = "Manufacturer Name";
            // 
            // lblStockManufacturer
            // 
            this.lblStockManufacturer.AutoSize = true;
            this.lblStockManufacturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockManufacturer.Location = new System.Drawing.Point(641, 147);
            this.lblStockManufacturer.Name = "lblStockManufacturer";
            this.lblStockManufacturer.Size = new System.Drawing.Size(114, 21);
            this.lblStockManufacturer.TabIndex = 9;
            this.lblStockManufacturer.Text = "Manufacturer";
            // 
            // lblStockPrice
            // 
            this.lblStockPrice.AutoSize = true;
            this.lblStockPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockPrice.Location = new System.Drawing.Point(362, 180);
            this.lblStockPrice.Name = "lblStockPrice";
            this.lblStockPrice.Size = new System.Drawing.Size(48, 21);
            this.lblStockPrice.TabIndex = 10;
            this.lblStockPrice.Text = "Price";
            // 
            // lblStockQty
            // 
            this.lblStockQty.AutoSize = true;
            this.lblStockQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockQty.Location = new System.Drawing.Point(362, 147);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(77, 21);
            this.lblStockQty.TabIndex = 11;
            this.lblStockQty.Text = "Quantity";
            // 
            // lblStockMedicineType
            // 
            this.lblStockMedicineType.AutoSize = true;
            this.lblStockMedicineType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMedicineType.Location = new System.Drawing.Point(22, 180);
            this.lblStockMedicineType.Name = "lblStockMedicineType";
            this.lblStockMedicineType.Size = new System.Drawing.Size(121, 21);
            this.lblStockMedicineType.TabIndex = 12;
            this.lblStockMedicineType.Text = "Medicine Type";
            // 
            // lblStockMedicineName
            // 
            this.lblStockMedicineName.AutoSize = true;
            this.lblStockMedicineName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMedicineName.Location = new System.Drawing.Point(22, 147);
            this.lblStockMedicineName.Name = "lblStockMedicineName";
            this.lblStockMedicineName.Size = new System.Drawing.Size(131, 21);
            this.lblStockMedicineName.TabIndex = 13;
            this.lblStockMedicineName.Text = "Medicine Name";
            // 
            // txtStockMedicineName
            // 
            this.txtStockMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockMedicineName.Location = new System.Drawing.Point(159, 145);
            this.txtStockMedicineName.Name = "txtStockMedicineName";
            this.txtStockMedicineName.Size = new System.Drawing.Size(157, 24);
            this.txtStockMedicineName.TabIndex = 14;
            // 
            // comboBoxStockMedicineType
            // 
            this.comboBoxStockMedicineType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStockMedicineType.FormattingEnabled = true;
            this.comboBoxStockMedicineType.Location = new System.Drawing.Point(159, 177);
            this.comboBoxStockMedicineType.Name = "comboBoxStockMedicineType";
            this.comboBoxStockMedicineType.Size = new System.Drawing.Size(157, 26);
            this.comboBoxStockMedicineType.TabIndex = 15;
            // 
            // txtStockPrice
            // 
            this.txtStockPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockPrice.Location = new System.Drawing.Point(444, 178);
            this.txtStockPrice.Name = "txtStockPrice";
            this.txtStockPrice.Size = new System.Drawing.Size(159, 24);
            this.txtStockPrice.TabIndex = 16;
            // 
            // txtStockQty
            // 
            this.txtStockQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockQty.Location = new System.Drawing.Point(445, 145);
            this.txtStockQty.Name = "txtStockQty";
            this.txtStockQty.Size = new System.Drawing.Size(158, 24);
            this.txtStockQty.TabIndex = 17;
            // 
            // comboBoxStockManufacturer
            // 
            this.comboBoxStockManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStockManufacturer.FormattingEnabled = true;
            this.comboBoxStockManufacturer.Location = new System.Drawing.Point(817, 144);
            this.comboBoxStockManufacturer.Name = "comboBoxStockManufacturer";
            this.comboBoxStockManufacturer.Size = new System.Drawing.Size(157, 26);
            this.comboBoxStockManufacturer.TabIndex = 18;
            // 
            // txtStockManufacturerName
            // 
            this.txtStockManufacturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockManufacturerName.Location = new System.Drawing.Point(817, 178);
            this.txtStockManufacturerName.Name = "txtStockManufacturerName";
            this.txtStockManufacturerName.Size = new System.Drawing.Size(159, 24);
            this.txtStockManufacturerName.TabIndex = 19;
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Name = "FormStock";
            this.Text = "FormStock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStockMedicineName;
        private System.Windows.Forms.Label lblStockMedicineType;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.Label lblStockPrice;
        private System.Windows.Forms.Label lblStockManufacturer;
        private System.Windows.Forms.Label lblStockManufacturerName;
        private System.Windows.Forms.TextBox txtStockMedicineName;
        private System.Windows.Forms.ComboBox comboBoxStockMedicineType;
        private System.Windows.Forms.TextBox txtStockQty;
        private System.Windows.Forms.TextBox txtStockPrice;
        private System.Windows.Forms.TextBox txtStockManufacturerName;
        private System.Windows.Forms.ComboBox comboBoxStockManufacturer;
    }
}
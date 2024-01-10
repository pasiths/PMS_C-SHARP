
namespace PharmacySystem.UI
{
    partial class FormHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblShowDI = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.lblShowMI = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMedicines = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMedicineStock = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnTime = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.lblShowMI.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dgvSales);
            this.panel1.Controls.Add(this.lblShowMI);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblMedicines);
            this.panel1.Controls.Add(this.dgvStock);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 772);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.panel4.Controls.Add(this.lblShowDI);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(51, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 153);
            this.panel4.TabIndex = 62;
            // 
            // lblShowDI
            // 
            this.lblShowDI.AutoSize = true;
            this.lblShowDI.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDI.ForeColor = System.Drawing.Color.White;
            this.lblShowDI.Location = new System.Drawing.Point(26, 70);
            this.lblShowDI.Name = "lblShowDI";
            this.lblShowDI.Size = new System.Drawing.Size(109, 37);
            this.lblShowDI.TabIndex = 1;
            this.lblShowDI.Text = "Rs 0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "DAILY INCOME";
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToOrderColumns = true;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(51, 288);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.Size = new System.Drawing.Size(1110, 117);
            this.dgvSales.TabIndex = 29;
            // 
            // lblShowMI
            // 
            this.lblShowMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(168)))), ((int)(((byte)(234)))));
            this.lblShowMI.Controls.Add(this.label7);
            this.lblShowMI.Controls.Add(this.label6);
            this.lblShowMI.Location = new System.Drawing.Point(607, 96);
            this.lblShowMI.Name = "lblShowMI";
            this.lblShowMI.Size = new System.Drawing.Size(554, 153);
            this.lblShowMI.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 37);
            this.label7.TabIndex = 3;
            this.label7.Text = "Rs 0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "MONTHLY INCOME";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(51, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1110, 33);
            this.panel3.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(499, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "SALES";
            // 
            // lblMedicines
            // 
            this.lblMedicines.AutoSize = true;
            this.lblMedicines.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.lblMedicines.Location = new System.Drawing.Point(534, 48);
            this.lblMedicines.Name = "lblMedicines";
            this.lblMedicines.Size = new System.Drawing.Size(104, 40);
            this.lblMedicines.TabIndex = 27;
            this.lblMedicines.Text = "HOME";
            // 
            // dgvStock
            // 
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(51, 444);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.Size = new System.Drawing.Size(1110, 229);
            this.dgvStock.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.panel5.Controls.Add(this.lblMedicineStock);
            this.panel5.Location = new System.Drawing.Point(51, 411);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1110, 33);
            this.panel5.TabIndex = 25;
            // 
            // lblMedicineStock
            // 
            this.lblMedicineStock.AutoSize = true;
            this.lblMedicineStock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineStock.ForeColor = System.Drawing.Color.White;
            this.lblMedicineStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMedicineStock.Location = new System.Drawing.Point(3, 1);
            this.lblMedicineStock.Name = "lblMedicineStock";
            this.lblMedicineStock.Size = new System.Drawing.Size(116, 32);
            this.lblMedicineStock.TabIndex = 5;
            this.lblMedicineStock.Text = "No Stock";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.btnTime);
            this.panel6.Location = new System.Drawing.Point(847, 679);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(314, 57);
            this.panel6.TabIndex = 2;
            // 
            // btnTime
            // 
            this.btnTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(124)))), ((int)(((byte)(214)))));
            this.btnTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTime.Location = new System.Drawing.Point(-11, -13);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(352, 77);
            this.btnTime.TabIndex = 1;
            this.btnTime.Text = "ForDisplyTime AM";
            this.btnTime.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.lblShowMI.ResumeLayout(false);
            this.lblShowMI.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblMedicineStock;
        private System.Windows.Forms.Label lblMedicines;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblShowDI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel lblShowMI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
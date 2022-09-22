namespace Pharmacy_Management_System.form
{
    partial class EditReceivingFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRefNo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.comboBoxMedicine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medicine_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Receiving";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 53);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ref. No";
            // 
            // textBoxRefNo
            // 
            this.textBoxRefNo.Location = new System.Drawing.Point(554, 81);
            this.textBoxRefNo.Name = "textBoxRefNo";
            this.textBoxRefNo.ReadOnly = true;
            this.textBoxRefNo.Size = new System.Drawing.Size(257, 21);
            this.textBoxRefNo.TabIndex = 40;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(20, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 32);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddList.FlatAppearance.BorderSize = 0;
            this.btnAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddList.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddList.ForeColor = System.Drawing.Color.White;
            this.btnAddList.Location = new System.Drawing.Point(657, 119);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(154, 32);
            this.btnAddList.TabIndex = 38;
            this.btnAddList.Text = "Add to List";
            this.btnAddList.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Quantity";
            // 
            // textBoxQty
            // 
            this.textBoxQty.Location = new System.Drawing.Point(473, 125);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(100, 21);
            this.textBoxQty.TabIndex = 36;
            // 
            // comboBoxMedicine
            // 
            this.comboBoxMedicine.FormattingEnabled = true;
            this.comboBoxMedicine.Location = new System.Drawing.Point(82, 125);
            this.comboBoxMedicine.Name = "comboBoxMedicine";
            this.comboBoxMedicine.Size = new System.Drawing.Size(287, 24);
            this.comboBoxMedicine.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Medicine";
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.Enabled = false;
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(82, 81);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(287, 24);
            this.comboBoxSupplier.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Supplier";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(657, 508);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 32);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicine_id,
            this.medicine_name,
            this.medicine_description,
            this.qty,
            this.delete});
            this.dataGridView1.Location = new System.Drawing.Point(20, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(791, 333);
            this.dataGridView1.TabIndex = 30;
            // 
            // medicine_id
            // 
            this.medicine_id.HeaderText = "";
            this.medicine_id.Name = "medicine_id";
            this.medicine_id.ReadOnly = true;
            this.medicine_id.Visible = false;
            // 
            // medicine_name
            // 
            this.medicine_name.HeaderText = "Medicine Name";
            this.medicine_name.Name = "medicine_name";
            this.medicine_name.ReadOnly = true;
            this.medicine_name.Width = 300;
            // 
            // medicine_description
            // 
            this.medicine_description.HeaderText = "Medicine Description";
            this.medicine_description.Name = "medicine_description";
            this.medicine_description.ReadOnly = true;
            this.medicine_description.Width = 250;
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // delete
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            this.delete.DefaultCellStyle = dataGridViewCellStyle9;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.HeaderText = "Remove";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // EditReceivingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRefNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxQty);
            this.Controls.Add(this.comboBoxMedicine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditReceivingFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditReceivingFrm";
            this.Load += new System.EventHandler(this.EditReceivingFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRefNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.ComboBox comboBoxMedicine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}
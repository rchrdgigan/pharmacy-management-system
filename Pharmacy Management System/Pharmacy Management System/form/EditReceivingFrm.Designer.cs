﻿namespace Pharmacy_Management_System.form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReceivingFrm));
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medicine_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Receiving";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
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
            this.label5.Location = new System.Drawing.Point(479, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ref. No";
            // 
            // textBoxRefNo
            // 
            this.textBoxRefNo.Location = new System.Drawing.Point(531, 81);
            this.textBoxRefNo.Name = "textBoxRefNo";
            this.textBoxRefNo.ReadOnly = true;
            this.textBoxRefNo.Size = new System.Drawing.Size(280, 21);
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
            this.btnCancel.Size = new System.Drawing.Size(154, 30);
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
            this.btnAddList.Location = new System.Drawing.Point(657, 117);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(154, 30);
            this.btnAddList.TabIndex = 38;
            this.btnAddList.Text = "Add to List";
            this.btnAddList.UseVisualStyleBackColor = false;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Quantity";
            // 
            // textBoxQty
            // 
            this.textBoxQty.Location = new System.Drawing.Point(531, 122);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(120, 21);
            this.textBoxQty.TabIndex = 36;
            // 
            // comboBoxMedicine
            // 
            this.comboBoxMedicine.FormattingEnabled = true;
            this.comboBoxMedicine.Location = new System.Drawing.Point(110, 122);
            this.comboBoxMedicine.Name = "comboBoxMedicine";
            this.comboBoxMedicine.Size = new System.Drawing.Size(353, 24);
            this.comboBoxMedicine.TabIndex = 35;
            this.comboBoxMedicine.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedicine_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Generic Name";
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.Enabled = false;
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(110, 81);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(353, 24);
            this.comboBoxSupplier.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Supplier Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(657, 508);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 30);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicine_id,
            this.medicine_name,
            this.medicine_desc,
            this.qty,
            this.colDel});
            this.dataGridView1.Location = new System.Drawing.Point(20, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(791, 333);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // medicine_id
            // 
            this.medicine_id.DataPropertyName = "medicine_id";
            this.medicine_id.HeaderText = "";
            this.medicine_id.Name = "medicine_id";
            this.medicine_id.ReadOnly = true;
            this.medicine_id.Visible = false;
            // 
            // medicine_name
            // 
            this.medicine_name.DataPropertyName = "drug_name";
            this.medicine_name.HeaderText = "Generic Name";
            this.medicine_name.Name = "medicine_name";
            this.medicine_name.ReadOnly = true;
            this.medicine_name.Width = 300;
            // 
            // medicine_desc
            // 
            this.medicine_desc.DataPropertyName = "description";
            this.medicine_desc.HeaderText = "Generic Description";
            this.medicine_desc.Name = "medicine_desc";
            this.medicine_desc.ReadOnly = true;
            this.medicine_desc.Width = 250;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // colDel
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.colDel.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDel.HeaderText = "Remove";
            this.colDel.Name = "colDel";
            this.colDel.ReadOnly = true;
            this.colDel.Text = "Delete";
            this.colDel.UseColumnTextForButtonValue = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.Controls.Add(this.btnUpdate);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicine_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
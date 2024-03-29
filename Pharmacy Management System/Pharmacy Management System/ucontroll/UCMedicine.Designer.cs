﻿namespace Pharmacy_Management_System.ucontroll
{
    partial class UCMedicine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMedicine));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drug_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescription = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSaveBarcode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.checkBoxPrescription = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxMeasurement = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDrugName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSKU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.count_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.description,
            this.sku,
            this.cat_name,
            this.drug_name,
            this.measurement,
            this.type_name,
            this.prescription,
            this.colEdit,
            this.colDel});
            this.dataGridView1.Location = new System.Drawing.Point(392, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(670, 555);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // sku
            // 
            this.sku.DataPropertyName = "sku";
            this.sku.HeaderText = "SKU";
            this.sku.Name = "sku";
            this.sku.ReadOnly = true;
            // 
            // cat_name
            // 
            this.cat_name.DataPropertyName = "cat_name";
            this.cat_name.HeaderText = "Brand Name";
            this.cat_name.Name = "cat_name";
            this.cat_name.ReadOnly = true;
            // 
            // drug_name
            // 
            this.drug_name.DataPropertyName = "drug_name";
            this.drug_name.HeaderText = "Generic Name";
            this.drug_name.Name = "drug_name";
            this.drug_name.ReadOnly = true;
            this.drug_name.Width = 200;
            // 
            // measurement
            // 
            this.measurement.DataPropertyName = "measurement";
            this.measurement.HeaderText = "Dosage";
            this.measurement.Name = "measurement";
            this.measurement.ReadOnly = true;
            // 
            // type_name
            // 
            this.type_name.DataPropertyName = "type_name";
            this.type_name.HeaderText = "Type";
            this.type_name.Name = "type_name";
            this.type_name.ReadOnly = true;
            // 
            // prescription
            // 
            this.prescription.DataPropertyName = "prescription";
            this.prescription.HeaderText = "Prescription";
            this.prescription.Name = "prescription";
            this.prescription.ReadOnly = true;
            this.prescription.Visible = false;
            // 
            // colEdit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle1;
            this.colEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colEdit.HeaderText = "Action";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.Width = 70;
            // 
            // colDel
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.colDel.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDel.HeaderText = "";
            this.colDel.Name = "colDel";
            this.colDel.ReadOnly = true;
            this.colDel.Text = "Delete";
            this.colDel.UseColumnTextForButtonValue = true;
            this.colDel.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Medicine List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSaveBarcode);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.checkBoxPrescription);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.richTextBoxDescription);
            this.groupBox1.Controls.Add(this.textBoxMeasurement);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxDrugName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxCat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxSKU);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(22, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 555);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicine Form";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Barcode";
            // 
            // btnSaveBarcode
            // 
            this.btnSaveBarcode.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveBarcode.FlatAppearance.BorderSize = 0;
            this.btnSaveBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBarcode.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBarcode.ForeColor = System.Drawing.Color.White;
            this.btnSaveBarcode.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveBarcode.Image")));
            this.btnSaveBarcode.Location = new System.Drawing.Point(65, 111);
            this.btnSaveBarcode.Name = "btnSaveBarcode";
            this.btnSaveBarcode.Size = new System.Drawing.Size(28, 26);
            this.btnSaveBarcode.TabIndex = 37;
            this.btnSaveBarcode.UseVisualStyleBackColor = false;
            this.btnSaveBarcode.Click += new System.EventHandler(this.btnSaveBarcode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(102, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 84);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(227, 510);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 27);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // checkBoxPrescription
            // 
            this.checkBoxPrescription.AutoSize = true;
            this.checkBoxPrescription.Location = new System.Drawing.Point(102, 449);
            this.checkBoxPrescription.Name = "checkBoxPrescription";
            this.checkBoxPrescription.Size = new System.Drawing.Size(137, 20);
            this.checkBoxPrescription.TabIndex = 31;
            this.checkBoxPrescription.Text = "Requires prescription";
            this.checkBoxPrescription.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Description";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(102, 340);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(244, 96);
            this.richTextBoxDescription.TabIndex = 29;
            this.richTextBoxDescription.Text = "";
            // 
            // textBoxMeasurement
            // 
            this.textBoxMeasurement.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMeasurement.Location = new System.Drawing.Point(102, 302);
            this.textBoxMeasurement.Name = "textBoxMeasurement";
            this.textBoxMeasurement.Size = new System.Drawing.Size(244, 21);
            this.textBoxMeasurement.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Dosage";
            // 
            // textBoxDrugName
            // 
            this.textBoxDrugName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDrugName.Location = new System.Drawing.Point(102, 265);
            this.textBoxDrugName.Name = "textBoxDrugName";
            this.textBoxDrugName.Size = new System.Drawing.Size(244, 21);
            this.textBoxDrugName.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Generic Name";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(102, 223);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(244, 24);
            this.comboBoxType.TabIndex = 24;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Type";
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(102, 184);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(244, 24);
            this.comboBoxCat.TabIndex = 22;
            this.comboBoxCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCat_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Brand Name";
            // 
            // textBoxSKU
            // 
            this.textBoxSKU.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSKU.Location = new System.Drawing.Point(102, 40);
            this.textBoxSKU.Name = "textBoxSKU";
            this.textBoxSKU.Size = new System.Drawing.Size(244, 21);
            this.textBoxSKU.TabIndex = 20;
            this.textBoxSKU.TextChanged += new System.EventHandler(this.textBoxSKU_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "SKU";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(38, 510);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 27);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(227, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 27);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(529, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 21);
            this.textBox2.TabIndex = 30;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Search generic name";
            // 
            // count_lbl
            // 
            this.count_lbl.AutoSize = true;
            this.count_lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.count_lbl.Location = new System.Drawing.Point(1081, 0);
            this.count_lbl.Name = "count_lbl";
            this.count_lbl.Size = new System.Drawing.Size(0, 16);
            this.count_lbl.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(765, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Search sku";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(836, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 21);
            this.textBox1.TabIndex = 33;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UCMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.count_lbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCMedicine";
            this.Size = new System.Drawing.Size(1081, 653);
            this.Load += new System.EventHandler(this.UCMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxPrescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.TextBox textBoxMeasurement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDrugName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSKU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn sku;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn drug_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn prescription;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
        private System.Windows.Forms.Label count_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSaveBarcode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
    }
}

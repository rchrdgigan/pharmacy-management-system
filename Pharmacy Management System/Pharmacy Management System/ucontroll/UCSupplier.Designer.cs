namespace Pharmacy_Management_System.ucontroll
{
    partial class UCSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(99, 127);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(244, 56);
            this.textBoxAddress.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Address";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(99, 86);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(244, 21);
            this.textBoxContact.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Contact";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(737, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 21);
            this.textBox2.TabIndex = 35;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Search";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(99, 43);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(244, 21);
            this.textBoxName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(50, 205);
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
            this.btnSave.Location = new System.Drawing.Point(239, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 27);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Supplier List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxContact);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(22, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 257);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Form";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.supplier_name,
            this.supplier_contact,
            this.supplier_address,
            this.colEdit,
            this.colDel});
            this.dataGridView1.Location = new System.Drawing.Point(392, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(670, 555);
            this.dataGridView1.TabIndex = 32;
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
            // supplier_name
            // 
            this.supplier_name.DataPropertyName = "supplier_name";
            this.supplier_name.HeaderText = "Name";
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.ReadOnly = true;
            this.supplier_name.Width = 200;
            // 
            // supplier_contact
            // 
            this.supplier_contact.DataPropertyName = "supplier_contact";
            this.supplier_contact.HeaderText = "Contact";
            this.supplier_contact.Name = "supplier_contact";
            this.supplier_contact.ReadOnly = true;
            // 
            // supplier_address
            // 
            this.supplier_address.DataPropertyName = "supplier_address";
            this.supplier_address.HeaderText = "Address";
            this.supplier_address.Name = "supplier_address";
            this.supplier_address.ReadOnly = true;
            this.supplier_address.Width = 200;
            // 
            // colEdit
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            this.colDel.DefaultCellStyle = dataGridViewCellStyle14;
            this.colDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDel.HeaderText = "";
            this.colDel.Name = "colDel";
            this.colDel.ReadOnly = true;
            this.colDel.Text = "Delete";
            this.colDel.UseColumnTextForButtonValue = true;
            this.colDel.Width = 70;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(239, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 27);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UCSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCSupplier";
            this.Size = new System.Drawing.Size(1081, 653);
            this.Load += new System.EventHandler(this.UCSupplier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_address;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
        private System.Windows.Forms.Button btnUpdate;
    }
}

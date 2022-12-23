namespace Pharmacy_Management_System.ucontroll
{
    partial class UCInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.count_lbl = new System.Windows.Forms.Label();
            this.sku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drug_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sku,
            this.drug_name,
            this.measurement,
            this.StockIn,
            this.StockOut,
            this.StockAvailable});
            this.dataGridView1.Location = new System.Drawing.Point(20, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1040, 555);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(735, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // count_lbl
            // 
            this.count_lbl.AutoSize = true;
            this.count_lbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.count_lbl.Location = new System.Drawing.Point(1081, 0);
            this.count_lbl.Name = "count_lbl";
            this.count_lbl.Size = new System.Drawing.Size(0, 16);
            this.count_lbl.TabIndex = 32;
            // 
            // sku
            // 
            this.sku.DataPropertyName = "sku";
            this.sku.HeaderText = "SKU";
            this.sku.Name = "sku";
            this.sku.ReadOnly = true;
            this.sku.Width = 150;
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
            this.measurement.HeaderText = "Measurement";
            this.measurement.Name = "measurement";
            this.measurement.ReadOnly = true;
            // 
            // StockIn
            // 
            this.StockIn.DataPropertyName = "in_stock";
            this.StockIn.HeaderText = "Stock In";
            this.StockIn.Name = "StockIn";
            this.StockIn.ReadOnly = true;
            this.StockIn.Width = 150;
            // 
            // StockOut
            // 
            this.StockOut.DataPropertyName = "out_stock";
            this.StockOut.HeaderText = "Stock Out";
            this.StockOut.Name = "StockOut";
            this.StockOut.ReadOnly = true;
            this.StockOut.Width = 150;
            // 
            // StockAvailable
            // 
            this.StockAvailable.DataPropertyName = "total_stocks";
            this.StockAvailable.HeaderText = "Stock Available";
            this.StockAvailable.Name = "StockAvailable";
            this.StockAvailable.ReadOnly = true;
            this.StockAvailable.Width = 250;
            // 
            // UCInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.count_lbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCInventory";
            this.Size = new System.Drawing.Size(1081, 653);
            this.Load += new System.EventHandler(this.UCInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label count_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn sku;
        private System.Windows.Forms.DataGridViewTextBoxColumn drug_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurement;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockAvailable;
    }
}

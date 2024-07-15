namespace MediPriceChange
{
    partial class Form1
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
            this.Na = new System.Windows.Forms.GroupBox();
            this.btnExporttoExcel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Na.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            this.SuspendLayout();
            // 
            // Na
            // 
            this.Na.Controls.Add(this.btnExporttoExcel);
            this.Na.Controls.Add(this.btnSave);
            this.Na.Controls.Add(this.btnAddFile);
            this.Na.Controls.Add(this.btnCheck);
            this.Na.Location = new System.Drawing.Point(16, 15);
            this.Na.Margin = new System.Windows.Forms.Padding(4);
            this.Na.Name = "Na";
            this.Na.Padding = new System.Windows.Forms.Padding(4);
            this.Na.Size = new System.Drawing.Size(703, 84);
            this.Na.TabIndex = 0;
            this.Na.TabStop = false;
            // 
            // btnExporttoExcel
            // 
            this.btnExporttoExcel.Location = new System.Drawing.Point(560, 23);
            this.btnExporttoExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExporttoExcel.Name = "btnExporttoExcel";
            this.btnExporttoExcel.Size = new System.Drawing.Size(131, 38);
            this.btnExporttoExcel.TabIndex = 1;
            this.btnExporttoExcel.Text = "Export to Excel";
            this.btnExporttoExcel.UseVisualStyleBackColor = true;
            this.btnExporttoExcel.Visible = false;
            this.btnExporttoExcel.Click += new System.EventHandler(this.btnExporttoExcel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(375, 23);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(8, 23);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(100, 38);
            this.btnAddFile.TabIndex = 0;
            this.btnAddFile.Text = "Select File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(185, 23);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 38);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check Data";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dgvImport
            // 
            this.dgvImport.AllowUserToAddRows = false;
            this.dgvImport.AllowUserToDeleteRows = false;
            this.dgvImport.AllowUserToOrderColumns = true;
            this.dgvImport.AllowUserToResizeColumns = false;
            this.dgvImport.AllowUserToResizeRows = false;
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductDescription,
            this.Price});
            this.dgvImport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvImport.EnableHeadersVisualStyles = false;
            this.dgvImport.Location = new System.Drawing.Point(16, 117);
            this.dgvImport.Margin = new System.Windows.Forms.Padding(4);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.ReadOnly = true;
            this.dgvImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImport.Size = new System.Drawing.Size(918, 434);
            this.dgvImport.TabIndex = 1;
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdSelect_FileOk);
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNewPrice.Location = new System.Drawing.Point(773, 38);
            this.txtNewPrice.Multiline = true;
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(143, 38);
            this.txtNewPrice.TabIndex = 2;
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductDescription
            // 
            this.ProductDescription.DataPropertyName = "ProductDescription";
            this.ProductDescription.HeaderText = "Product Description";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ReadOnly = true;
            this.ProductDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProductDescription.Width = 250;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.NullValue = "0";
            this.Price.DefaultCellStyle = dataGridViewCellStyle1;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 566);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.dgvImport);
            this.Controls.Add(this.Na);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Price Changes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Na.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Na;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.DataGridView dgvImport;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnExporttoExcel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}


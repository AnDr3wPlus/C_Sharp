namespace COMP2614Assign07
{
    partial class MainForm
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
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.ColumnClientCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYTDSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreditHold = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditRecord = new System.Windows.Forms.Button();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelTotalYTDSales = new System.Windows.Forms.Label();
            this.labelTotalYTDSalesResult = new System.Windows.Forms.Label();
            this.labelCreditHoldCount = new System.Windows.Forms.Label();
            this.labelCreditHoldCountResult = new System.Windows.Forms.Label();
            this.checkBoxConfirmDeletion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AllowUserToResizeColumns = false;
            this.dataGridViewClients.AllowUserToResizeRows = false;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnClientCode,
            this.ColumnCompanyName,
            this.ColumnAddress1,
            this.ColumnAddress2,
            this.ColumnCity,
            this.ColumnProvince,
            this.ColumnPostalCode,
            this.ColumnYTDSales,
            this.ColumnCreditHold,
            this.ColumnNotes});
            this.dataGridViewClients.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewClients.MultiSelect = false;
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.Size = new System.Drawing.Size(840, 321);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.DoubleClick += new System.EventHandler(this.buttonEditRecord_Click);
            // 
            // ColumnClientCode
            // 
            this.ColumnClientCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnClientCode.DataPropertyName = "clientCode";
            this.ColumnClientCode.HeaderText = "ClientCode";
            this.ColumnClientCode.Name = "ColumnClientCode";
            this.ColumnClientCode.ReadOnly = true;
            this.ColumnClientCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnClientCode.Width = 64;
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnCompanyName.DataPropertyName = "companyName";
            this.ColumnCompanyName.HeaderText = "Company";
            this.ColumnCompanyName.Name = "ColumnCompanyName";
            this.ColumnCompanyName.ReadOnly = true;
            this.ColumnCompanyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnCompanyName.Width = 57;
            // 
            // ColumnAddress1
            // 
            this.ColumnAddress1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnAddress1.DataPropertyName = "address1";
            this.ColumnAddress1.HeaderText = "Add1";
            this.ColumnAddress1.Name = "ColumnAddress1";
            this.ColumnAddress1.ReadOnly = true;
            this.ColumnAddress1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnAddress1.Width = 37;
            // 
            // ColumnAddress2
            // 
            this.ColumnAddress2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnAddress2.DataPropertyName = "address2";
            this.ColumnAddress2.HeaderText = "Add2";
            this.ColumnAddress2.Name = "ColumnAddress2";
            this.ColumnAddress2.ReadOnly = true;
            this.ColumnAddress2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnAddress2.Width = 37;
            // 
            // ColumnCity
            // 
            this.ColumnCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnCity.DataPropertyName = "city";
            this.ColumnCity.HeaderText = "City";
            this.ColumnCity.Name = "ColumnCity";
            this.ColumnCity.ReadOnly = true;
            this.ColumnCity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnCity.Width = 31;
            // 
            // ColumnProvince
            // 
            this.ColumnProvince.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnProvince.DataPropertyName = "province";
            this.ColumnProvince.HeaderText = "Province";
            this.ColumnProvince.Name = "ColumnProvince";
            this.ColumnProvince.ReadOnly = true;
            this.ColumnProvince.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnProvince.Width = 52;
            // 
            // ColumnPostalCode
            // 
            this.ColumnPostalCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnPostalCode.DataPropertyName = "postalCode";
            this.ColumnPostalCode.HeaderText = "Postcode";
            this.ColumnPostalCode.Name = "ColumnPostalCode";
            this.ColumnPostalCode.ReadOnly = true;
            this.ColumnPostalCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnPostalCode.Width = 52;
            // 
            // ColumnYTDSales
            // 
            this.ColumnYTDSales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnYTDSales.DataPropertyName = "yTDSales";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnYTDSales.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnYTDSales.HeaderText = "YTDSales";
            this.ColumnYTDSales.Name = "ColumnYTDSales";
            this.ColumnYTDSales.ReadOnly = true;
            this.ColumnYTDSales.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnYTDSales.Width = 57;
            // 
            // ColumnCreditHold
            // 
            this.ColumnCreditHold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnCreditHold.DataPropertyName = "creditHold";
            this.ColumnCreditHold.HeaderText = "CreditHold";
            this.ColumnCreditHold.Name = "ColumnCreditHold";
            this.ColumnCreditHold.ReadOnly = true;
            this.ColumnCreditHold.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCreditHold.Width = 63;
            // 
            // ColumnNotes
            // 
            this.ColumnNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnNotes.DataPropertyName = "notes";
            this.ColumnNotes.HeaderText = "Notes";
            this.ColumnNotes.Name = "ColumnNotes";
            this.ColumnNotes.ReadOnly = true;
            this.ColumnNotes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnNotes.Width = 37;
            // 
            // buttonEditRecord
            // 
            this.buttonEditRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditRecord.Location = new System.Drawing.Point(762, 349);
            this.buttonEditRecord.Name = "buttonEditRecord";
            this.buttonEditRecord.Size = new System.Drawing.Size(90, 31);
            this.buttonEditRecord.TabIndex = 5;
            this.buttonEditRecord.Text = "&Edit Record";
            this.buttonEditRecord.UseVisualStyleBackColor = true;
            this.buttonEditRecord.Click += new System.EventHandler(this.buttonEditRecord_Click);
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewClient.Location = new System.Drawing.Point(648, 349);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(90, 31);
            this.buttonNewClient.TabIndex = 6;
            this.buttonNewClient.Text = "&New Client";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(534, 349);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 31);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelTotalYTDSales
            // 
            this.labelTotalYTDSales.AutoSize = true;
            this.labelTotalYTDSales.Location = new System.Drawing.Point(13, 349);
            this.labelTotalYTDSales.Name = "labelTotalYTDSales";
            this.labelTotalYTDSales.Size = new System.Drawing.Size(119, 12);
            this.labelTotalYTDSales.TabIndex = 1;
            this.labelTotalYTDSales.Text = "&Total Year-to-date Sales:";
            // 
            // labelTotalYTDSalesResult
            // 
            this.labelTotalYTDSalesResult.AutoSize = true;
            this.labelTotalYTDSalesResult.Location = new System.Drawing.Point(139, 349);
            this.labelTotalYTDSalesResult.Name = "labelTotalYTDSalesResult";
            this.labelTotalYTDSalesResult.Size = new System.Drawing.Size(128, 12);
            this.labelTotalYTDSalesResult.TabIndex = 2;
            this.labelTotalYTDSalesResult.Text = "< Total YTDSales Result >";
            // 
            // labelCreditHoldCount
            // 
            this.labelCreditHoldCount.AutoSize = true;
            this.labelCreditHoldCount.Location = new System.Drawing.Point(13, 368);
            this.labelCreditHoldCount.Name = "labelCreditHoldCount";
            this.labelCreditHoldCount.Size = new System.Drawing.Size(95, 12);
            this.labelCreditHoldCount.TabIndex = 3;
            this.labelCreditHoldCount.Text = "Credit &Hold Count:";
            // 
            // labelCreditHoldCountResult
            // 
            this.labelCreditHoldCountResult.AutoSize = true;
            this.labelCreditHoldCountResult.Location = new System.Drawing.Point(139, 368);
            this.labelCreditHoldCountResult.Name = "labelCreditHoldCountResult";
            this.labelCreditHoldCountResult.Size = new System.Drawing.Size(142, 12);
            this.labelCreditHoldCountResult.TabIndex = 4;
            this.labelCreditHoldCountResult.Text = "< Credit Hold Count Result >";
            // 
            // checkBoxConfirmDeletion
            // 
            this.checkBoxConfirmDeletion.AutoSize = true;
            this.checkBoxConfirmDeletion.Location = new System.Drawing.Point(420, 357);
            this.checkBoxConfirmDeletion.Name = "checkBoxConfirmDeletion";
            this.checkBoxConfirmDeletion.Size = new System.Drawing.Size(106, 16);
            this.checkBoxConfirmDeletion.TabIndex = 8;
            this.checkBoxConfirmDeletion.Text = "&Confirm Deletion";
            this.checkBoxConfirmDeletion.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 392);
            this.Controls.Add(this.checkBoxConfirmDeletion);
            this.Controls.Add(this.labelCreditHoldCountResult);
            this.Controls.Add(this.labelCreditHoldCount);
            this.Controls.Add(this.labelTotalYTDSalesResult);
            this.Controls.Add(this.labelTotalYTDSales);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNewClient);
            this.Controls.Add(this.buttonEditRecord);
            this.Controls.Add(this.dataGridViewClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "COMP2614 Assignment07 A01063367";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button buttonEditRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClientCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnYTDSales;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCreditHold;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNotes;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelTotalYTDSales;
        private System.Windows.Forms.Label labelTotalYTDSalesResult;
        private System.Windows.Forms.Label labelCreditHoldCount;
        private System.Windows.Forms.Label labelCreditHoldCountResult;
        private System.Windows.Forms.CheckBox checkBoxConfirmDeletion;
    }
}


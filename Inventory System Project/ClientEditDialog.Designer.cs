namespace COMP2614Assign07
{
    partial class ClientEditDialog
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
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelNotesPrompt = new System.Windows.Forms.Label();
            this.textBoxYTDSales = new System.Windows.Forms.TextBox();
            this.labelYTDSalesPrompt = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.labelPostalCodePrompt = new System.Windows.Forms.Label();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.labelAddress2Prompt = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxClientCode = new System.Windows.Forms.TextBox();
            this.checkBoxCreditHold = new System.Windows.Forms.CheckBox();
            this.labelProvincePrompt = new System.Windows.Forms.Label();
            this.labelCityPrompt = new System.Windows.Forms.Label();
            this.labelAddress1Prompt = new System.Windows.Forms.Label();
            this.labelCompanyNamePrompt = new System.Windows.Forms.Label();
            this.labelClientCodePrompt = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProviderValidation = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxProvince = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidation)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(81, 306);
            this.textBoxNotes.MaxLength = 100;
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(180, 44);
            this.textBoxNotes.TabIndex = 18;
            // 
            // labelNotesPrompt
            // 
            this.labelNotesPrompt.AutoSize = true;
            this.labelNotesPrompt.Location = new System.Drawing.Point(14, 309);
            this.labelNotesPrompt.Name = "labelNotesPrompt";
            this.labelNotesPrompt.Size = new System.Drawing.Size(34, 12);
            this.labelNotesPrompt.TabIndex = 17;
            this.labelNotesPrompt.Text = "&Notes:";
            // 
            // textBoxYTDSales
            // 
            this.textBoxYTDSales.Location = new System.Drawing.Point(81, 242);
            this.textBoxYTDSales.Name = "textBoxYTDSales";
            this.textBoxYTDSales.Size = new System.Drawing.Size(100, 22);
            this.textBoxYTDSales.TabIndex = 16;
            this.textBoxYTDSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelYTDSalesPrompt
            // 
            this.labelYTDSalesPrompt.AutoSize = true;
            this.labelYTDSalesPrompt.Location = new System.Drawing.Point(14, 245);
            this.labelYTDSalesPrompt.Name = "labelYTDSalesPrompt";
            this.labelYTDSalesPrompt.Size = new System.Drawing.Size(57, 12);
            this.labelYTDSalesPrompt.TabIndex = 15;
            this.labelYTDSalesPrompt.Text = "&YTD Sales:";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(81, 210);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(100, 22);
            this.textBoxPostalCode.TabIndex = 14;
            // 
            // labelPostalCodePrompt
            // 
            this.labelPostalCodePrompt.AutoSize = true;
            this.labelPostalCodePrompt.Location = new System.Drawing.Point(14, 213);
            this.labelPostalCodePrompt.Name = "labelPostalCodePrompt";
            this.labelPostalCodePrompt.Size = new System.Drawing.Size(63, 12);
            this.labelPostalCodePrompt.TabIndex = 13;
            this.labelPostalCodePrompt.Text = "&Postal Code:";
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(81, 114);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(180, 22);
            this.textBoxAddress2.TabIndex = 8;
            // 
            // labelAddress2Prompt
            // 
            this.labelAddress2Prompt.AutoSize = true;
            this.labelAddress2Prompt.Location = new System.Drawing.Point(12, 117);
            this.labelAddress2Prompt.Name = "labelAddress2Prompt";
            this.labelAddress2Prompt.Size = new System.Drawing.Size(51, 12);
            this.labelAddress2Prompt.TabIndex = 7;
            this.labelAddress2Prompt.Text = "Address&2:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(81, 146);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(140, 22);
            this.textBoxCity.TabIndex = 10;
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(81, 82);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(180, 22);
            this.textBoxAddress1.TabIndex = 6;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(81, 50);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(140, 22);
            this.textBoxCompanyName.TabIndex = 4;
            // 
            // textBoxClientCode
            // 
            this.textBoxClientCode.Location = new System.Drawing.Point(81, 18);
            this.textBoxClientCode.Name = "textBoxClientCode";
            this.textBoxClientCode.Size = new System.Drawing.Size(84, 22);
            this.textBoxClientCode.TabIndex = 2;
            // 
            // checkBoxCreditHold
            // 
            this.checkBoxCreditHold.AutoSize = true;
            this.checkBoxCreditHold.Location = new System.Drawing.Point(81, 277);
            this.checkBoxCreditHold.Name = "checkBoxCreditHold";
            this.checkBoxCreditHold.Size = new System.Drawing.Size(79, 16);
            this.checkBoxCreditHold.TabIndex = 19;
            this.checkBoxCreditHold.Text = "Credit &Hold";
            this.checkBoxCreditHold.UseVisualStyleBackColor = true;
            // 
            // labelProvincePrompt
            // 
            this.labelProvincePrompt.AutoSize = true;
            this.labelProvincePrompt.Location = new System.Drawing.Point(14, 181);
            this.labelProvincePrompt.Name = "labelProvincePrompt";
            this.labelProvincePrompt.Size = new System.Drawing.Size(49, 12);
            this.labelProvincePrompt.TabIndex = 11;
            this.labelProvincePrompt.Text = "P&rovince:";
            // 
            // labelCityPrompt
            // 
            this.labelCityPrompt.AutoSize = true;
            this.labelCityPrompt.Location = new System.Drawing.Point(12, 149);
            this.labelCityPrompt.Name = "labelCityPrompt";
            this.labelCityPrompt.Size = new System.Drawing.Size(28, 12);
            this.labelCityPrompt.TabIndex = 9;
            this.labelCityPrompt.Text = "Ci&ty:";
            // 
            // labelAddress1Prompt
            // 
            this.labelAddress1Prompt.AutoSize = true;
            this.labelAddress1Prompt.Location = new System.Drawing.Point(12, 85);
            this.labelAddress1Prompt.Name = "labelAddress1Prompt";
            this.labelAddress1Prompt.Size = new System.Drawing.Size(51, 12);
            this.labelAddress1Prompt.TabIndex = 5;
            this.labelAddress1Prompt.Text = "Address&1:";
            // 
            // labelCompanyNamePrompt
            // 
            this.labelCompanyNamePrompt.AutoSize = true;
            this.labelCompanyNamePrompt.Location = new System.Drawing.Point(12, 53);
            this.labelCompanyNamePrompt.Name = "labelCompanyNamePrompt";
            this.labelCompanyNamePrompt.Size = new System.Drawing.Size(54, 12);
            this.labelCompanyNamePrompt.TabIndex = 3;
            this.labelCompanyNamePrompt.Text = "Com&pany:";
            // 
            // labelClientCodePrompt
            // 
            this.labelClientCodePrompt.AutoSize = true;
            this.labelClientCodePrompt.Location = new System.Drawing.Point(12, 21);
            this.labelClientCodePrompt.Name = "labelClientCodePrompt";
            this.labelClientCodePrompt.Size = new System.Drawing.Size(64, 12);
            this.labelClientCodePrompt.TabIndex = 1;
            this.labelClientCodePrompt.Text = "Client Co&de:";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(96, 377);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(194, 377);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // errorProviderValidation
            // 
            this.errorProviderValidation.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderValidation.ContainerControl = this;
            // 
            // comboBoxProvince
            // 
            this.comboBoxProvince.FormattingEnabled = true;
            this.comboBoxProvince.Location = new System.Drawing.Point(81, 178);
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(50, 20);
            this.comboBoxProvince.TabIndex = 12;
            // 
            // ClientEditDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(284, 412);
            this.Controls.Add(this.comboBoxProvince);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.labelNotesPrompt);
            this.Controls.Add(this.textBoxYTDSales);
            this.Controls.Add(this.labelYTDSalesPrompt);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.labelPostalCodePrompt);
            this.Controls.Add(this.textBoxAddress2);
            this.Controls.Add(this.labelAddress2Prompt);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxAddress1);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.textBoxClientCode);
            this.Controls.Add(this.checkBoxCreditHold);
            this.Controls.Add(this.labelProvincePrompt);
            this.Controls.Add(this.labelCityPrompt);
            this.Controls.Add(this.labelAddress1Prompt);
            this.Controls.Add(this.labelCompanyNamePrompt);
            this.Controls.Add(this.labelClientCodePrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientEditDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client Edit Dialog";
            this.Load += new System.EventHandler(this.ClientEditDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelNotesPrompt;
        private System.Windows.Forms.TextBox textBoxYTDSales;
        private System.Windows.Forms.Label labelYTDSalesPrompt;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Label labelPostalCodePrompt;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.Label labelAddress2Prompt;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxClientCode;
        private System.Windows.Forms.CheckBox checkBoxCreditHold;
        private System.Windows.Forms.Label labelProvincePrompt;
        private System.Windows.Forms.Label labelCityPrompt;
        private System.Windows.Forms.Label labelAddress1Prompt;
        private System.Windows.Forms.Label labelCompanyNamePrompt;
        private System.Windows.Forms.Label labelClientCodePrompt;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProviderValidation;
        private System.Windows.Forms.ComboBox comboBoxProvince;
    }
}
// Assignment 7: COMP2614Assign07 - ClientEditDialog class
// Create a client edit dialog using the controls
// 
// Andrew Wu
// Jul 14, 2019


using BusinesLib.Business;
using BusinesLib.Common;
using BusinesLib.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static COMP2614Assign07.MainForm;

namespace COMP2614Assign07
{
    public partial class ClientEditDialog : Form
    {

        public ClientViewModel ClientVM { get; set; }

        public bool HideClientCode { get; set; }

        /**
         * Enum - EditMode of UpdateClient or AddClient
         */
        public enum EditMode
        {
            AddClient,
            UpdateClient
        }
        
        public EditMode ClientEditMode { get; set; }


        public ClientEditDialog()
        {
            InitializeComponent();
        }

        
        private void ClientEditDialog_Load(object sender, EventArgs e)
        {
            SetBinding();
            comboBoxProvince.DataSource = ClientRepository.GetProvinceAbbrs();
            //comboBoxProvince.DisplayMember = "Abbreviation";

            // clientCode readonly if ClientEditMode == UpdateClient
            this.textBoxClientCode.ReadOnly = ClientEditMode == EditMode.UpdateClient;
        }
        

        // Set DataBindings to the textBoxes
        private void SetBinding()
        {
            textBoxClientCode.DataBindings.Add("Text", ClientVM, "Client.ClientCode",
                                               false, DataSourceUpdateMode.OnValidation, "");

            textBoxCompanyName.DataBindings.Add("Text", ClientVM, "Client.CompanyName",
                                                false, DataSourceUpdateMode.OnValidation, "");

            textBoxAddress1.DataBindings.Add("Text", ClientVM, "Client.Address1");

            textBoxAddress2.DataBindings.Add("Text", ClientVM, "Client.Address2",
                                             false, DataSourceUpdateMode.OnValidation, "NULL");

            textBoxCity.DataBindings.Add("Text", ClientVM, "Client.City",
                                         false, DataSourceUpdateMode.OnValidation, "NULL");

            //textBoxProvince.DataBindings.Add("Text", ClientVM, "Client.Province",
            //                                 false, DataSourceUpdateMode.OnValidation, "");
            comboBoxProvince.DataBindings.Add("Text", ClientVM, "Client.Province",
                                              false, DataSourceUpdateMode.OnValidation, "");

            textBoxPostalCode.DataBindings.Add("Text", ClientVM, "Client.PostalCode",
                                               false, DataSourceUpdateMode.OnValidation, "NULL");

            textBoxYTDSales.DataBindings.Add("Text", ClientVM, "Client.YTDSales",
                                             true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");

            checkBoxCreditHold.DataBindings.Add("Checked", ClientVM, "Client.CreditHold");

            textBoxNotes.DataBindings.Add("Text", ClientVM, "Client.Notes",
                                          false, DataSourceUpdateMode.OnValidation, "NULL");

        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            errorProviderValidation.SetError( buttonOK, string.Empty );
            
            int rowsAffected = 0;

            try
            {
                Client client = ClientVM.GetDisplayClient();

                // UpdateClient()
                if ( ClientEditMode == EditMode.UpdateClient )
                {
                    rowsAffected = Validation.UpdateClient( client );
                }
                // AddClient()
                if ( ClientEditMode == EditMode.AddClient )
                {
                    rowsAffected = Validation.AddClient( client );
                }
                Console.WriteLine(client.ToString());
                if ( rowsAffected > 0 )
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    if ( rowsAffected == -1 )
                    {
                        //MessageBox.Show( Validation.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                        errorProviderValidation.SetError( buttonOK, Validation.ErrorMessage );
                    }
                    else
                    {
                        //MessageBox.Show( "No DB changes were made", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                        errorProviderValidation.SetError( buttonOK, "No DB changes were made" );
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show( ex.Message, "DataBase Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
        

    }
}

// Assignment 7: COMP2614Assign07 - MainForm class
// Create a Windows Forms project using the controls
// 
// Andrew Wu
// Jul 14, 2019


using BusinesLib.Business;
using BusinesLib.Common;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace COMP2614Assign07
{
    public partial class MainForm : Form
    {
        private ClientViewModel clientVM;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                clientVM = new ClientViewModel();
                SetBinding();
                RefreshData();
            }
            catch ( SqlException ex )
            {
                MessageBox.Show( ex.Message, "DataBase Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }


        /**
         * Set DataBindings to dataGrandViewClients
         */
        private void SetBinding()
        {
            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = clientVM.Clients;
        }
        
        
        private void buttonEditRecord_Click(object sender, EventArgs e)
        {
            int index = dataGridViewClients.CurrentRow.Index;      // get current row
            clientVM.SetDisplayClient( clientVM.Clients[index] );  // set display client

            ClientEditDialog dialog = new ClientEditDialog
            {
                ClientVM = clientVM,
                ClientEditMode = ClientEditDialog.EditMode.UpdateClient
            };

            dialog.ShowDialog();
            RefreshData();
        }


        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            clientVM.SetDisplayClient(new Client());  // set display client to empty cliet

            ClientEditDialog dialog = new ClientEditDialog
            {
                ClientVM = clientVM,
                ClientEditMode = ClientEditDialog.EditMode.AddClient
            };

            dialog.ShowDialog();
            RefreshData();
        }
        

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridViewClients.CurrentRow.Index;
            Client client = clientVM.Clients[index];
            
            try
            {
                DialogResult deleteResult;  // MessageBox to confirmation to delete client?

                if ( checkBoxConfirmDeletion.Checked )
                {
                    deleteResult = MessageBox.Show(
                        $"Delete client {client.ClientCode}?", "Delete Client?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if ( deleteResult == DialogResult.Yes )
                    {
                        Validation.DeleteClient( client );
                    }
                }
                else
                {
                    Validation.DeleteClient( client );
                }
            }
            catch ( SqlException ex )
            {
                MessageBox.Show( ex.Message, "DataBase Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            finally
            {
                RefreshData();
            }
        }

        
        /**
         * Refresh the display data after updating database
         */
        private void RefreshData()
        {
            clientVM.Clients = Validation.GetClients();
            dataGridViewClients.DataSource = clientVM.Clients;
            
            labelTotalYTDSalesResult.Text = clientVM.Clients.TotalYTDSales().ToString();
            labelCreditHoldCountResult.Text = clientVM.Clients.CreditHoldCount().ToString();
        }
        

    }
}




//private void buttonEditRecord_Click(object sender, EventArgs e)
//{
//    int rowsAffected;

//    int index = dataGridViewClients.CurrentRow.Index;      // get current row
//    clientVM.SetDisplayClient(clientVM.Clients[index]);  // set the display client

//    ClientEditDialog dialog = new ClientEditDialog();
//    dialog.ClientVM = clientVM;

//    if (dialog.ShowDialog() == DialogResult.OK)  // show dialog and verify dialog result
//    {
//        Client client = clientVM.GetDisplayClient();
//        rowsAffected = Validation.UpdateClient(client);  // execute UpdateClient()

//        if (rowsAffected > 0)
//        {
//            RefreshData();
//        }
//        else
//        {
//            if (rowsAffected == -1)
//            {
//                MessageBox.Show(Validation.ErrorMessage, " Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            else
//            {
//                MessageBox.Show("No DB changes were made", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//        clientVM.Clients.ResetItem(index);  // reset Clients collection
//    }
//    dialog.Dispose();
//}


//private void buttonNewClient_Click(object sender, EventArgs e)
//{
//    ClientEditDialog dialog = new ClientEditDialog();
//    dialog.ClientVM = clientVM;
    
//    if (dialog.ShowDialog() == DialogResult.OK)  // show dialog and verify dialog result
//    {
//        Client client = clientVM.GetDisplayClient();
//        rowsAffected = Validation.AddClient(client);  // execute AddClient()

//        if (rowsAffected > 0)  // client added
//        {
//            RefreshData();
//        }
//        else
//        {
//            if (rowsAffected == -1)  // validation error
//            {
//                MessageBox.Show(Validation.ErrorMessage, " Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//            else
//            {
//                MessageBox.Show("No DB changes were made", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//    }
//    dialog.Dispose();
//}


// SelectionChanged event
// Select and display different client
//private void dataGridViewClients_SelectionChanged(object sender, EventArgs e)
//{
//    int index = dataGridViewClients.CurrentRow.Index;

//    Client client = clientVM.Clients[index];
//    clientVM.SetDisplayClient( client );

//}


// ButtonSave_Click event
// Save and renew client's information
//private void buttonSave_Click(object sender, EventArgs e)
//{
//    int index = dataGridViewClients.CurrentRow.Index;

//    Client client = clientVM.GetDisplayClient();  // get current displayed client info
//    clientVM.Clients[index] = client;  // assign displayed client to update the collection
//    clientVM.Clients.ResetItem(index);  // reread the item and refresh its displayed value

//    string outputLegend = string.Format( "{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n{7}\r\n{8}\r\n{9}\r\n"
//                                       , "ClientCode:"
//                                       , "Company:"
//                                       , "Address1:"
//                                       , "Address2:"
//                                       , "City:"
//                                       , "Province:"
//                                       , "PostalCode:"
//                                       , "YTDSales:"
//                                       , "CreditHold:"
//                                       , "Notes:");

//    string outputData = string.Format( "{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n{7}\r\n{8}\r\n{9}\r\n"
//                                      , client.ClientCode
//                                      , client.CompanyName
//                                      , client.Address1
//                                      , client.Address2
//                                      , client.City
//                                      , client.Province
//                                      , client.PostalCode
//                                      , client.YTDSales
//                                      , client.CreditHold ? "Yes" : "No"
//                                      , client.Notes);

//}


////private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
////{

////}


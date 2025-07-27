// Assignment 7: COMP2614Assign07 - ClientViewModel class
// Create the client view model and implement the PropertyChanged event
// 
// Andrew Wu
// Jun 23 2019



using BusinesLib.Business;
using BusinesLib.Common;
using BusinesLib.Data.Common;

namespace COMP2614Assign07
{
    public class ClientViewModel : ViewModelBase
    {

        //public event PropertyChangedEventHandler PropertyChanged;

        ///** This method is called by the Set accessor of each property.
        //    The CallerMemberName attribute that is applied to the optional propertyName
        //    parameter causes the property name of the caller to be substituted as an argument. */
        //private void OnPropertyChanged( [CallerMemberName] string propertyName = "" )
        //{
        //    PropertyChanged?.Invoke( this, new PropertyChangedEventArgs(propertyName) );  // (sender, changed property name)
        //}

        
        /// <summary>
        /// Constructor
        /// </summary>
        public ClientViewModel()
        {
            //this.Clients = ClientRepository.GetClients();
            this.Clients = Validation.GetClients();
            this.Client = new Client();
        }
        

        private Client client;

        public Client Client
        {
            get { return this.client; }
            set
            {
                this.client = value;
                OnPropertyChanged();
             }
        }

        public ClientCollection Clients { get; set; }


        /// <summary>
        /// Set the client to display
        /// </summary>
        /// <param name="client">The client to display</param>
        public void SetDisplayClient( Client client )
        {
            this.Client = new Client
            {
                ClientCode = client.ClientCode,
                CompanyName = client.CompanyName,
                Address1 = client.Address1,
                Address2 = client.Address2,
                City = client.City,
                Province = client.Province,
                PostalCode = client.PostalCode,
                YTDSales = client.YTDSales,
                CreditHold = client.CreditHold,
                Notes = client.Notes
            };
        }


        /// <summary>
        /// Get the current display client
        /// </summary>
        /// <returns>The displayed client</returns>
        public Client GetDisplayClient()
        {
            OnPropertyChanged( "Client" );
            return this.Client;
        }

    }
}

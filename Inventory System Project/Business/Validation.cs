// Assignment 7: COMP2614Assign07 - Validation class
// Validation of client
// 
// Andrew Wu
// Jul 06 2019


using COMP2614Assign07.Common;
using COMP2614Assign07.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign07.Business
{
    class Validation
    {
        private static List<string> errorsList;  // error messages list

        // Static property to expose ErrorList
        public static string ErrorMessage
        {
            get
            {
                string message = "";
                foreach ( string line in errorsList )
                {
                    message += line + "\r\n";
                }

                return message;
            }
        }


        // Static constructor
        static Validation()
        {
            errorsList = new List<string>();
        }


        /// <summary>
        /// Validate and add client
        /// </summary>
        /// <param name="client">The client to add</param>
        /// <returns>The number of rows affected</returns>
        public static int AddClient( Client client )
        {
            if ( Validate( client ) )
            {
                return ClientRepository.AddClient( client );
            }
            else
            {
                return -1;
            }
        }


        /// <summary>
        /// Validate and update client
        /// </summary>
        /// <param name="client">The client to update</param>
        /// <returns>The number of rows affected</returns>
        public static int UpdateClient( Client client )
        {
            if (Validate( client ))
            {
                return ClientRepository.UpdateClient( client );
            }
            else
            {
                return -1;
            }
        }


        /// <summary>
        /// Validate and delete client
        /// </summary>
        /// <param name="client">The client to delete</param>
        /// <returns>The number of rows affected</returns>
        public static int DeleteClient( Client client )
        {
            return ClientRepository.DeleteClient( client );
        }


        /// <summary>
        /// Validate and get cients
        /// </summary>
        /// <returns>The list of clients</returns>
        public static ClientCollection GetClients()
        {
            return ClientRepository.GetClients();
        }


        /// <summary>
        /// Validation method
        /// </summary>
        /// <param name="client">The client to validate</param>
        /// <returns>True if valid, false elsewhere</returns>
        private static bool Validate( Client client )
        {
            bool valid = true;
            errorsList.Clear();  // clear the old messages

            if ( string.IsNullOrWhiteSpace( client.ClientCode ) )  // ClientCode cannot be empty
            {
                valid = false;
                errorsList.Add("ClientCode cannot be empty");
            }

            if ( client.ClientCode.Length > 5 )  // The length of ClientCode cannot > 5
            {
                valid = false;
                errorsList.Add("The length of ClientCode cannot > 5");
            }

            if ( string.IsNullOrWhiteSpace( client.CompanyName ))  // CompanyName cannot be empty
            {
                valid = false;
                errorsList.Add("CompanyName cannot be empty");
            }

            if ( string.IsNullOrWhiteSpace( client.Address1 ) )  // Address1 cannot be empty
            {
                valid = false;
                errorsList.Add("Address1 cannot be empty");
            }

            if ( string.IsNullOrWhiteSpace( client.Province ) )  // Province cannot be empty
            {
                valid = false;
                errorsList.Add("Province cannot be empty");
            }

            if ( client.YTDSales < 0 )  // YTDSales cannot be negative
            {
                valid = false;
                errorsList.Add("YTDSales cannot be negative");
            }
            
            return valid;
        }

    }
}

// Assignment 7: COMP2614Assign07 - ClientRepository class
// C.R.U.D. Methods for SQL server
// 
// Andrew Wu
// Jul 06 2019


using COMP2614Assign07.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace COMP2614Assign07.Data
{
    class ClientRepository
    {
        public readonly static string tableName = "Client063367";

        public readonly static string  connString = @"Server=tcp:skeena.database.windows.net,1433;
                                                      Initial Catalog=comp2614;
                                                      User ID=student;
                                                      Password=93nu5/nrCKX;
                                                      Encrypt=True;
                                                      TrustServerCertificate=False;
                                                      Connection Timeout=30;";


        /// <summary>
        /// Create client
        /// </summary>
        /// <param name="client">The client to create</param>
        /// <returns>The number of rows affected</returns>
        public static int AddClient( Client client )
        {
            string query = $@"INSERT INTO {tableName}
                              (ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes)
                              VALUES (@clientCode, @companyName, @address1, @address2, @city, @province, @postalCode, @yTDSales, @creditHold, @notes)";
            
            return ProcessQuery( query, client );
        }


        /// <summary>
        /// Update client
        /// </summary>
        /// <param name="client">The client to update</param>
        /// <returns>The number of rows affected</returns>
        public static int UpdateClient( Client client )
        {
            string query = $@"
                              
                              
                              UPDATE {tableName}
                              SET 
                                  CompanyName = @companyName, 
                                  Address1 = @address1, 
                                  Address2 = @address2, 
                                  City = @city,
                                  Province = @province, 
                                  PostalCode = @postalCode, 
                                  YTDSales = @yTDSales, 
                                  CreditHold = @creditHold, 
                                  Notes = @notes
                              WHERE ClientCode = @clientCode";
            //ClientCode = @clientCode,
            //UPDATE {tableName}
            //SET ClientCode = @clientCode
            //WHERE CompanyName = @companyName
            //OR CompanyName = @companyName OR Address1 = @address1 OR Address2 = @address2 OR YTDSales = @yTDSales
            return ProcessQuery(query, client);
        }


        /// <summary>
        /// Process query
        /// </summary>
        /// <param name="query">The query to process</param>
        /// <param name="client">The client to execute the query</param>
        /// <returns>The number of rows affected</returns>
        public static int ProcessQuery( string query, Client client )
        {
            int rowsAffected;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);      // ClientCode
                    //cmd.Parameters.Add("@clientCodeOriginal", client.ClientCode);
                    //cmd.Parameters["@clientCodeOriginal"].SourceVersion = DataRowVersion.Original;
                    cmd.Parameters.AddWithValue("@companyName", client.CompanyName);    // CompanyName
                    cmd.Parameters.AddWithValue("@address1", client.Address1);          // Address1

                    if (client.Address2 != null)                                        // Address2
                    {
                        cmd.Parameters.AddWithValue("@address2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address2", DBNull.Value);
                    }

                    if (client.City != null)                                            // City
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@province", client.Province);          // Province

                    if (client.PostalCode != null)                                      // PostalCode
                    {
                        cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@yTDSales", client.YTDSales);          // YTDSales
                    cmd.Parameters.AddWithValue("@creditHold", client.CreditHold);      // CreditHold

                    if (client.Notes != null)                                           // Notes
                    {
                        cmd.Parameters.AddWithValue("@notes", client.Notes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    }

                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }

            }

            return rowsAffected;
        }
        

        /// <summary>
        /// Read the clients
        /// </summary>
        /// <returns>The list of clients</returns>
        public static ClientCollection GetClients()
        {
            //ClientCollection clients;
            
            using ( SqlConnection conn = new SqlConnection(connString) )
            {
                // Embedded SQL
                string query = $@"SELECT ClientCode, CompanyName, Address1, Address2, City, 
                                         Province, PostalCode, YTDSales, CreditHold, Notes
                                  FROM {tableName}
                                  ORDER BY ClientCode";

                using ( SqlCommand cmd = new SqlCommand() )
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();
                    var clients = new ClientCollection();

                    using ( SqlDataReader reader = cmd.ExecuteReader() )
                    {
                        while ( reader.Read() )
                        {
                            string clientCode;         // PK 
                            string companyName;        // 1
                            string address1;           // 2
                            string address2 = null;    // 3
                            string city = null;        // 4
                            string province;           // 5
                            string postalCode = null;  // 6
                            decimal yTDSales;          // 7
                            bool creditHold;           // 8
                            string notes = null;       // 9

                            clientCode = reader["ClientCode"] as string;
                            companyName = reader["CompanyName"] as string;
                            address1 = reader["Address1"] as string;

                            if ( !reader.IsDBNull(3) )
                            {
                                address2 = reader["Address2"] as string;
                            }
                            else
                            {
                                address2 = null;
                            }

                            if ( !reader.IsDBNull(4) )
                            {
                                city = reader["City"] as string;
                            }
                            else
                            {
                                city = null;
                            }

                            province = reader["Province"] as string;

                            if ( !reader.IsDBNull(6) )
                            {
                                postalCode = reader["PostalCode"] as string;
                            }
                            else
                            {
                                postalCode = null;
                            }

                            yTDSales = (decimal)reader["YTDSales"];

                            creditHold = (bool)reader["CreditHold"];

                            if ( !reader.IsDBNull(9) )
                            {
                                notes = reader["Notes"] as string;
                            }
                            else
                            {
                                notes = null;
                            }

                            clients.Add(new Client
                            {
                                ClientCode = clientCode,
                                CompanyName = companyName,
                                Address1 = address1,
                                Address2 = address2,
                                City = city,
                                Province = province,
                                PostalCode = postalCode,
                                YTDSales = yTDSales,
                                CreditHold = creditHold,
                                Notes = notes
                            });
                            //clients.Add(new Client(clientCode, companyName, address1, address2, city, province, postalCode, yTDSales, creditHold, notes));
                            //Client aClient = new Client(clientCode, companyName, address1, address2, city, province, postalCode, yTDSales, creditHold, notes);
                            //Console.Write( aClient.ToString() );

                            address2 = null;    // 3
                            city = null;        // 4
                            postalCode = null;  // 6
                            notes = null;       // 9
                        }
                    }

                    return clients;
                }
            }
        }


        /// <summary>
        /// Delete client
        /// </summary>
        /// <param name="client">The client to delete</param>
        /// <returns>The number of rows affected</returns>
        public static int DeleteClient( Client client )
        {
            string query = $@"DELETE {tableName}
                              WHERE ClientCode = @clientCode";

            using ( SqlConnection conn = new SqlConnection(connString) )
            {
                using ( SqlCommand cmd = new SqlCommand() )
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue( "@clientCode", client.ClientCode );

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        

    }
}

// Assignment 7: COMP2614Assign07 - Client class
// Attributes and methods of Client
// 
// Andrew Wu
// Jun 22 2019


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace COMP2614Assign07.Common
{
    public class Client
    {
        public string ClientCode { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }    // nullable
        public string City { get; set; }        // nullable
        public string Province { get; set; }
        public string PostalCode { get; set; }  // nullable
        public decimal YTDSales { get; set; }
        public bool CreditHold { get; set; }
        public string Notes { get; set; }       // nullable

        //public Client()
        //{

        //}

        //public Client ( string clientCode, 
        //                string companyName, 
        //                string address1, 
        //                string address2, 
        //                string city, 
        //                string province, 
        //                string postalCode, 
        //                decimal yTDSales, 
        //                bool creditHold, 
        //                string notes )
        //{
        //    this.ClientCode = clientCode;
        //    this.CompanyName = companyName;
        //    this.Address1 = address1;
        //    this.Address2 = address2 ?? "";
        //    this.City = city ?? "";
        //    this.Province = province;
        //    this.PostalCode = postalCode ?? "";
        //    this.YTDSales = yTDSales;
        //    this.CreditHold = creditHold;
        //    this.Notes = notes ?? "";

        //    //this.Address2 = address2 ?? "N/A";
        //    //this.City = city ?? "N/A";
        //    //this.PostalCode = postalCode ?? "N/A";
        //    //this.Notes = notes ?? "N/A";
        //}


        public override string ToString()
        {
            return $"{ClientCode,-10} {CompanyName,-35} {Address1,-30} {Address2,-12} " +
                   $"{City,-10} {Province,-3}  {PostalCode,-7}  {YTDSales,8}   {(CreditHold ? "Y":"N"),-3} " +
                   $"{Notes, -30}\n\n";
        }
    }
}

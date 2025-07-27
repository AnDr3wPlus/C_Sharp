// Assignment 7: COMP2614Assign07 - ClientCollection class
// Derived Class ClientCollection inherits from List<Client>
// 
// Andrew Wu
// Jun 22 2019


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace COMP2614Assign07.Common
{
    public class ClientCollection : BindingList<Client>
    {

        public decimal TotalYTDSales() => this.Sum( x => x.YTDSales );

        public int CreditHoldCount() => this.Count( x => x.CreditHold );

    }
}

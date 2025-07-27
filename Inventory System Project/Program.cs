// Assignment 7: COMP2614Assign07 - Program class
// The main entry point for the application
// 
// Andrew Wu
// Jun 22 2019


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COMP2614Assign07
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //CustomerRepository.GetAllCustomers();
        }
    }
}

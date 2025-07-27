// Assignment 7: COMP2614Assign07 - ViewModelBase class
// View model base class for PropertyChanged event
// 
// Andrew Wu
// Jun 28 2019


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace COMP2614Assign07
{
    public class ViewModelBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        /** This method is called by the Set accessor of each property.
            The CallerMemberName attribute that is applied to the optional propertyName
            parameter causes the property name of the caller to be substituted as an argument. */
        protected void OnPropertyChanged ( [CallerMemberName] string propertyName = null )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs(propertyName) );  // (sender, changed property name)
        }

    }
}

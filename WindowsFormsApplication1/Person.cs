using System;
using System.ComponentModel;

namespace WindowsFormsApplication1
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("FirstName"));
                }
            }
        }

        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} - {2}", FirstName, LastName, Age);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
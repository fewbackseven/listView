using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace listView
{
    public class MainPageViewModel 
    {


        public List<Customer> MyList { get; set; }

        public MainPageViewModel()
        {
            MyList = new List<Customer>
            {
                new Customer { Name = "James", Details = "James Details"},
                new Customer { Name = "Harshith", Details = "Harshith Details"}

            };
        }




        //private ObservableCollection<string> _listOfCustomers;

        //public ObservableCollection<Customer> customers { get; set; }

        ////private ObservableCollection<Customer> _customers;
        ////public ObservableCollection<Customer> ListOfCustomers
        ////{
        ////    get { return _customers; }
        ////    set { _customers = ListOfCustomers;
        ////        OnPropertyChanged("ListOfCustomers");
        ////    }
        ////}

        //public ObservableCollection<string> MyList 
        //{ 
        //    get { return _listOfCustomers; }
        //    set { _listOfCustomers = MyList;
        //        OnPropertyChanged("MyList");
        //    } 
        //}

        //public MainPageViewModel()
        //{
        //    _listOfCustomers = new ObservableCollection<string>()
        //    {
        //        "Hello","Andy","Roul"
        //    };

        //    customers = new ObservableCollection<Customer>
        //    {
        //        new Customer(){Name="pa",Details="Hello1"},
        //        new Customer(){Name="pa1", Details="Hello12"},
        //        new Customer(){Name="pa2", Details="Hello13"}
        //    };
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //void OnPropertyChanged(string name)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}
    }
}
    


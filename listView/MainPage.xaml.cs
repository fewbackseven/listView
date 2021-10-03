using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace listView
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {            
            InitializeComponent();
            //BindingContext = new MainPageViewModel();
        }

        async void OnPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new stringsPage());
        }
    }
}

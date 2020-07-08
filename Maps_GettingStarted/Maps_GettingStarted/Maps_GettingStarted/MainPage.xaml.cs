using Syncfusion.SfMaps.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Maps_GettingStarted
{
    public partial class MainPage : ContentPage
    {
        ViewModel model = new ViewModel();
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = model;
        }
    }
}

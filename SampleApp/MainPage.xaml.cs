using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel mainPageViewModel;
        public MainPage()
        {
            InitializeComponent();
            mainPageViewModel = new MainPageViewModel(this);
            BindingContext = mainPageViewModel;
        }
    }
}

using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainPageViewModel : BaseViewModel
    {
        MainPage mainPage;
        public MainPageViewModel(MainPage mainPageRef)
        {
            mainPage = mainPageRef;
        }

        private Command onTapped;
        private const string OnTappedCommandPropertyName = "OnTapped";

        public Command OnTapped
        {
            get
            {
                return onTapped ?? (onTapped = new Command(ExecuteOnTappedCommand));
            }
        }

        public void ExecuteOnTappedCommand()
        {
            //your code here
            mainPage.DisplayAlert("XamEffects", "Tapped", "OK");
        }
    }
}

using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using FlyoutModalIssue.Views;

namespace FlyoutModalIssue.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            OpenModalCommand = new Command(async () => await Shell.Current.Navigation.PushModalAsync(new PopupPage()));
        }

        public ICommand OpenWebCommand { get; }
        public ICommand OpenModalCommand { get; }
    }
}

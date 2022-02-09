using System;
using FlyoutModalIssue.ViewModels;
using Xamarin.Forms;

namespace FlyoutModalIssue
{
    public class AppShellViewModel : BaseViewModel
    {
        private bool _mySwitch;
        public bool MySwitch
        {
            get { return _mySwitch; }
            set { SetProperty(ref _mySwitch, value); }
        }

        public AppShellViewModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            MySwitch = true;
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                MySwitch = false;
                return false;
            });
        }
    }
}

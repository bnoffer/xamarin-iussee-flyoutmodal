using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FlyoutModalIssue.Views
{
    public partial class PopupPage : ContentPage
    {
        public PopupPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Shell.Current.Navigation.PopModalAsync();
        }
    }
}

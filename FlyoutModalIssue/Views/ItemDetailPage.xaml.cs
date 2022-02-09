using System.ComponentModel;
using Xamarin.Forms;
using FlyoutModalIssue.ViewModels;

namespace FlyoutModalIssue.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}

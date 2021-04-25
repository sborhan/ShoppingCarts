using ShoppingCarts.ViewModels;
using System.Diagnostics.CodeAnalysis;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingCarts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartDetailPage : ContentPage
    {
        public CartDetailPageViewModel _ViewModel;

        public CartDetailPage()
        {
            InitializeComponent();

            BindingContext = _ViewModel = new CartDetailPageViewModel();
        }

        [ExcludeFromCodeCoverage]
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _ViewModel.GetData.Execute(null);
        }

        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
    }
}
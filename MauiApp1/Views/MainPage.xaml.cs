using MauiApp1.Entities;
using MauiApp1.ViewModels;

namespace MauiApp1.Views
{
    public partial class MainPage : ContentPage
    {

        int count = 0;

        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        //private async Task GetCustomers() => CustomerList = _appDbContext.Customers.ToList();

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    //SemanticScreenReader.Announce(CounterBtn.Text);
        //}
    }
}
using MauiApp1.Entities;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        private AppDbContext _appDbContext;
        List<Customer> CustomerList { get; set; } = new List<Customer>();
        int count = 0;

        public MainPage(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

            _appDbContext.Customers.Add(new Entities.Customer
            {
                Name = "d",
                Email = "D",
                Mobile = "Ad"
            });

            _appDbContext.SaveChanges();


            InitializeComponent();

        }

        private async Task GetCustomers() => CustomerList = _appDbContext.Customers.ToList();

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}

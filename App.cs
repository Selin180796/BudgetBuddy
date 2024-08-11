using Xamarin.Forms;

namespace BudgetBuddy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Views.IndexPage());
        }
    }
}

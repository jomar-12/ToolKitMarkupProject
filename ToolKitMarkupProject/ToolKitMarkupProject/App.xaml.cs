using ToolKitMarkupProject.View.Pages;
using ToolKitMarkupProject.ViewModels;
using Xamarin.Forms;

namespace ToolKitMarkupProject
{
    public partial class App : Application
    {
        public static new App Current => (App)Application.Current;
        public LoginViewModel LoginViewModel { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
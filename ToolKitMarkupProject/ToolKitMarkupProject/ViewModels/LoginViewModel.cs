using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ToolKitMarkupProject.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username;
        private string _password;
        private bool _isbusy;

        public LoginViewModel()
        {
            LoginButton = new Command(async () => await LoginValiation());
            ForgotPassword = new Command(async () => await ForgotPasswordAction());
            CreateAccount = new Command(async () => await CreateAccountAction());
        }


        public Command LoginButton { get; set; }
        public Command ForgotPassword { get; set; }
        public Command CreateAccount { get; set; }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;

                OnPropertyChanged();
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;

                OnPropertyChanged();
            }
        }

        public bool IsBusy
        {
            get { return _isbusy; }
            set
            {
                IsBusy = value;

                OnPropertyChanged();
            }
        }

        private async Task CreateAccountAction()
        {
            await Application.Current.MainPage.DisplayAlert("Welcome!", "Account created", "Ok");
        }
        private async Task ForgotPasswordAction()
        {
            await Application.Current.MainPage.DisplayAlert("Don't worry", "Password has been sent to your email", "Ok");
        }

        private async Task LoginValiation()
        {
            IsBusy = true;
            await Task.Delay(3000);
            IsBusy = false;

            bool IsValidated = Username == "fulano14" && Password == "hola123";
            var app = Application.Current.MainPage;

            if (IsValidated) await app.DisplayAlert($"Hi {Username}!", "You are sign in.", "Ok");
            else await app.DisplayAlert("Ups...", "wrong username or password", "Ok");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ToolKitMarkupProject.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username;
        private string _password;

        public string Username { get { return _username; } set { _username = value; RaisePropertyChanged(nameof(Username)); } }
        public string Password { get { return _password; } set { _username = value; RaisePropertyChanged(nameof(Password)); } }
    }
}
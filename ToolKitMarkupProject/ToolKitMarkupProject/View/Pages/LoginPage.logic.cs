using System;
using System.Collections.Generic;
using System.Text;
using ToolKitMarkupProject.ViewModels;

namespace ToolKitMarkupProject.View.Pages
{
    public partial class LoginPage
    {
        public LoginPage() => Initialize();

        public void Initialize()
        {
            BindingContext = new LoginViewModel();

            Build();
        }
    }
}
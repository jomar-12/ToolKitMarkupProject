using System;
using System.Collections.Generic;
using System.Text;

using ToolKitMarkupProject.CustomControl;
using ToolKitMarkupProject.ViewModels;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Forms;

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage(null, "ENC1003")]

namespace ToolKitMarkupProject.View.Pages
{
    public partial class LoginPage : BaseContentPage<LoginViewModel>
    {
        private void Build()
        {
            var app = App.Current;
            var vm = ViewModel = app.LoginViewModel;

            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundImageSource = "bgXamarin.png";

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,

                Children =
                {
                    new Image{ Source="Logo.png"} .Margins(100,120,100,70),

                    new RoundedEntry{ Placeholder = "usrname",HorizontalTextAlignment= TextAlignment.Start, Opacity=0.3, TextColor = Color.White, PlaceholderColor= Color.White}.Bind(nameof(vm.Username)).Margin(60, 0),

                    new RoundedEntry{ Placeholder = "Password", Opacity=0.3, HorizontalTextAlignment= TextAlignment.Start, IsPassword = true, TextColor = Color.White, PlaceholderColor=Color.White}.Bind(nameof(vm.Password)).Margin(60, 0),

                    new Label{ Text="Forgot your Password?", HorizontalTextAlignment = TextAlignment.Center, TextColor=Color.White}.Paddings(0, 10, 0, 50),

                    new LoginButton{ Text="Sign in", CharacterSpacing=1 ,CornerRadius = 30, BackgroundColor= Color.Transparent,TextColor=Color.White ,BorderColor=Color.White}.Margin(90,0).Height(60).FontSize(23).Font(bold: true),
                }
            };
        }
    }
}
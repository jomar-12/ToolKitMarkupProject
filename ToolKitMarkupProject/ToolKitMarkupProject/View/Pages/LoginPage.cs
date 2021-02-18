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
    public partial class LoginPage : ContentPage
    {
        private void Build()
        {
            var app = App.Current;
            var vm = app.LoginViewModel;

            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundImageSource = "bgXamarin.png";

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                
                Children =
                {
                    new Image{ Source="Logo.png"} .Margins(105,120,105,95),

                    new RoundedEntry{ Placeholder = "Email",HorizontalTextAlignment= TextAlignment.Start,TextColor = Color.White, PlaceholderColor= Color.White}
                    .Bind(nameof(vm.Username)).Margin(60, 5),

                    new RoundedEntry{ Placeholder = "Password", HorizontalTextAlignment= TextAlignment.Start, IsPassword = true, TextColor = Color.White, PlaceholderColor=Color.White}
                    .Bind(nameof(vm.Password)).Margin(60, 5),

                    new Label{ Text="Forgot your Password?", HorizontalTextAlignment = TextAlignment.Center, TextColor=Color.White}
                    .Paddings(0, 10, 0, 50).BindTapGesture(nameof(vm.ForgotPassword)),

                    new LoginButton{ Text="Sign in", CharacterSpacing=1 ,CornerRadius = 30, BackgroundColor= Color.Transparent,TextColor=Color.White ,BorderColor=Color.White}
                    .Margin(90,0).Height(60).FontSize(23).Font(bold: true).Bind(nameof(vm.LoginButton)),

                    new Frame {
                        BackgroundColor = Color.FromRgba(0,0,0,0.4),
                        HeightRequest = 6,
                        VerticalOptions = LayoutOptions.EndAndExpand,
                        Content = new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            HorizontalOptions = LayoutOptions.Center,

                            Children =
                            {
                                new Label
                                {
                                    Text = "Do not have an account?",
                                    TextColor = Color.White,
                                    VerticalTextAlignment = TextAlignment.Center,
                                    HorizontalTextAlignment = TextAlignment.Center,
                                    Padding = -5
                                },
                                new Label
                                {
                                    Text = "Create Acount.",
                                    TextColor = Color.White,
                                    VerticalTextAlignment = TextAlignment.Center,
                                    HorizontalTextAlignment = TextAlignment.Center,
                                    Padding = -5
                                }
                                .Margin(10,0)
                                .Font(bold: true)
                                .FontSize(14)
                                .BindTapGesture(nameof(vm.CreateAccount))
                            }
                        }
                    }

                }
            };

        }
    }
}
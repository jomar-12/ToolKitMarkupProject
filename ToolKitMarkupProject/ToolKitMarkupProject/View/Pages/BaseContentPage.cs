﻿using System;
using System.Collections.Generic;
using System.Text;
using ToolKitMarkupProject.Helpers;
using ToolKitMarkupProject.ViewModels;
using Xamarin.Forms;

namespace ToolKitMarkupProject.View.Pages
{
    public class BaseContentPage : ContentPage
    {
        protected static double PageMarginSize = 12, HeaderHeight = 26, CellHorizontalMarginSize = 16, CellVerticalMarginSize = 12;
    }

    public class BaseContentPage<ViewModelType> : BaseContentPage where ViewModelType : BaseViewModel
    {
        protected ViewModelType ViewModel { get { return (ViewModelType)BindingContext; } set { BindingContext = value; } }

        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                ViewModel?.OnShow();
            }
            catch (Exception ex) { XLog.Trace(ex); }
        }

        protected override void OnDisappearing()
        {
            try
            {
                ViewModel?.OnHide();
                base.OnDisappearing();
            }
            catch (Exception ex) { XLog.Trace(ex); }
        }
    }
}
using CoreGraphics;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolKitMarkupProject.CustomControl;
using ToolKitMarkupProject.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedEntry), typeof(RoundedEntryRendererIOS))]

namespace ToolKitMarkupProject.iOS
{
    public class RoundedEntryRendererIOS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.Layer.CornerRadius = 20;
                Control.Layer.BorderWidth = 3;
                Control.Layer.BorderColor = Color.White.ToCGColor();
                Control.Layer.BackgroundColor = Color.Transparent.ToCGColor();

                Control.LeftView = new UIView(new CGRect(0, 0, 10, 0));
                Control.LeftViewMode = UITextFieldViewMode.Always;
            }
        }
    }
}
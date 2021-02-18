using Android.Graphics.Drawables;
using System;
using ToolKitMarkupProject.CustomControl;
using ToolKitMarkupProject.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

#pragma warning disable CS0612 // Type or member is obsolete
[assembly: ExportRenderer(typeof(LoginButton), typeof(LoginButtonRendererAndroid))]
#pragma warning restore CS0612 // Type or member is obsolete

namespace ToolKitMarkupProject.Droid
{
    [Obsolete]
    public class LoginButtonRendererAndroid : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(80f);
                gradientDrawable.SetStroke(5, Android.Graphics.Color.White);
                gradientDrawable.SetColor(Android.Graphics.Color.Transparent);
                Control.SetBackground(gradientDrawable);
            }
        }
    }
}
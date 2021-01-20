using Android.App;
using Android.Content;

using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MeetAndPlayMobileApp.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using MeetAndPlayMobileApp.CustomRenderers;
using Android.Graphics;
using Android.Content.Res;

[assembly: ExportRenderer(typeof(EnumBindablePicker<>), typeof(CustomPickerRenderer))]
namespace MeetAndPlayMobileApp.Droid
{
    public class CustomPickerRenderer
        : Xamarin.Forms.Platform.Android.AppCompat.PickerRenderer
    {
        public CustomPickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.Gravity = GravityFlags.CenterHorizontal;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text.Method;
using Android.Views;
using Android.Widget;
using EntryLanguage;
using EntryLanguage.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace EntryLanguage.Droid
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null && e.NewElement is EntryLanguage.CustomEntry customEntry)
            {
                //this.Control.InputType = Android.Text.InputTypes.ClassNumber | Android.Text.InputTypes.NumberFlagDecimal;
                

                var decimalSign = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                var digits = $"0123456789{decimalSign}";
                Control.KeyListener = DigitsKeyListener.GetInstance(digits);
            }
        }
    }
}
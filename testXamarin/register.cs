using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace testXamarin
{
    [Activity(Label = "Activity1")]
    public class register : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            TextView txt;

            SetContentView(Resource.Layout.register);
            FindViewById<Button>(Resource.Id.register).Click += (e, o) =>
            {
               // txt = FindViewById<TextView>(Resource.Id.)
            };
        }
    }
}
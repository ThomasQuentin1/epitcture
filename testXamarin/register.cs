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
            SetContentView(Resource.Layout.register);


            EditText tmp;
            string password;
            string userName;
            FindViewById<Button>(Resource.Id.registerBtn).Click += (e, o) =>
            {
                tmp = FindViewById<EditText>(Resource.Id.TxtPassword);
                password = tmp.Text;
                tmp = FindViewById<EditText>(Resource.Id.TxtUserName);
                userName = tmp.Text;
                if (password != null && userName != null) {
                    Console.WriteLine(password);
                    Console.WriteLine(userName);

                    //todo REGISTER API IMGUR 
                }
            };
        }
    }
}
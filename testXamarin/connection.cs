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
    [Activity(Label = "connection")]
    public class connection : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.connection);
            EditText tmp;
            string password;
            string userName;
            FindViewById<Button>(Resource.Id.connectionBtn).Click += (e, o) =>
            {
                tmp = FindViewById<EditText>(Resource.Id.connectionPassword);
                password = tmp.Text;
                tmp = FindViewById<EditText>(Resource.Id.connectionUsername);
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
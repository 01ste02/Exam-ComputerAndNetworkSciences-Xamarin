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

namespace Prov
{
    [Activity(Label = "ResultScreenActivity")]
    public class ResultScreenActivity : Activity
    {
        TextView txtResult;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.resultScreen);

            ActionBar.Hide();

            txtResult = FindViewById<TextView>(Resource.Id.txtResult);

            txtResult.Text = Intent.GetDoubleExtra("resultNumber", 0.0).ToString();
        }
    }
}
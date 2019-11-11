using Android.App;
using Android.Widget;
using Android.OS;
using static Android.Views.View;
using Android.Views;
using Java.Lang;
using Android.Content;

namespace Prov
{
    [Activity(Label = "Prov", MainLauncher = true)]
    public class MainActivity : Activity, IOnClickListener
    {
        Button btnSin;
        Button btnCos;
        Button btnTan;
        Button btnCTan;

        EditText txtInput;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);
            
            btnSin = FindViewById<Button>(Resource.Id.btnSin);
            btnCos = FindViewById<Button>(Resource.Id.btnCos);
            btnTan = FindViewById<Button>(Resource.Id.btnTan);
            btnCTan = FindViewById<Button>(Resource.Id.btnCTan);

            btnSin.SetOnClickListener(this);
            btnCos.SetOnClickListener(this);
            btnTan.SetOnClickListener(this);
            btnCTan.SetOnClickListener(this);

            txtInput = FindViewById<EditText>(Resource.Id.txtInput);
        }

        public void OnClick(View v)
        {
            if (v.Id == btnSin.Id)
            {
                if (!txtInput.Text.ToString().Equals("") && txtInput.Text != null)
                {
                    double num = Double.ParseDouble(txtInput.Text.ToString());
                    num = num * Math.Pi / 180;
                    num = Math.Sin(num);

                    StartResult(num);
                }
                else
                {
                    Toast.MakeText(this, "Enter operand", ToastLength.Long).Show();
                }
            }
            else if (v.Id == btnCos.Id)
            {
                if (!txtInput.Text.ToString().Equals("") && txtInput.Text != null)
                {
                    double num = Double.ParseDouble(txtInput.Text.ToString());
                    num = num * Math.Pi / 180;
                    num = Math.Cos(num);

                    StartResult(num);
                }
                else
                {
                    Toast.MakeText(this, "Enter operand", ToastLength.Long).Show();
                }
            }
            else if (v.Id == btnTan.Id)
            {
                if (!txtInput.Text.ToString().Equals("") && txtInput.Text != null)
                {
                    double num = Double.ParseDouble(txtInput.Text.ToString());
                    num = num * Math.Pi / 180;
                    num = Math.Tan(num);

                    StartResult(num);
                }
                else
                {
                    Toast.MakeText(this, "Enter operand", ToastLength.Long).Show();
                }
            }
            else if (v.Id == btnCTan.Id)
            {
                if (!txtInput.Text.ToString().Equals("") && txtInput.Text != null)
                {
                    double num = Double.ParseDouble(txtInput.Text.ToString());

                    if (num != 0 && num != 0.0)
                    {
                        num = num * Math.Pi / 180;
                        num = 1 / Math.Tan(num);

                        StartResult(num);
                    }
                    else
                    {
                        Toast.MakeText(this, "Not ctan with 0", ToastLength.Long).Show();
                    }
                }
                else
                {
                    Toast.MakeText(this, "Enter operand", ToastLength.Long).Show();
                }
            }
        }

        public void StartResult(double resultNum)
        {
            Intent intent = new Intent(this, typeof(ResultScreenActivity));
            intent.PutExtra("resultNumber", resultNum);

            StartActivity(intent);
        }
    }
}


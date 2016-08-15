using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace SIT313Proj1
{
    [Activity(Label = "Cipher Slayer", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        static readonly List<string> messages = new List<string>();
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "Main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our UI controls from the loaded layout:
            EditText cipherText = FindViewById<EditText>(Resource.Id.cipherText);
            Button decipherButton = FindViewById<Button>(Resource.Id.decipherButton);
            Spinner spinner = FindViewById<Spinner>(Resource.Id.spinner);
            Button cipherHistoryButton = FindViewById<Button>(Resource.Id.cipherHistoryButton);

            cipherHistoryButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MessageHistory));
                intent.PutStringArrayListExtra("messages", messages);
                StartActivity(intent);
            };

            string decipheredMessage = string.Empty;

            decipherButton.Click += (object sender, EventArgs e) =>
            {
                decipheredMessage = Core.Caesar.Decipher(cipherText.Text);

                    // enable the Call History button
                    cipherHistoryButton.Enabled = true;
            };

            //Create and Fill Spinner with Array in Strings.xml
            spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.cipher_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;
        }

        //Tell spinner how to behave when each option is selected
        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;

            string toast = string.Format("Will attempt to decode the message as a {0} cipher", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();

            String spinnerText = (String)spinner.GetItemAtPosition(e.Position);
            
                if (spinnerText == "Caesar")
                {
                    return;
                }

                else if (spinnerText == "Transpostition(backwards)")
                {
                    return;
                }

                else if (spinnerText == "Transpostition(pair switch)")
                {
                    return;
                }

                else if (spinnerText == "Monoalphabetic Substitution")
                {
                    return;
                }
        }
    }
}


using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
namespace SIT313Proj1
{
    [Activity(Label = "@string/cipherHistory")]
    public class MessageHistory : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Create your application here
            var message = Intent.Extras.GetStringArrayList("messages") ?? new string[0];
            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, message);
        }
    }
}
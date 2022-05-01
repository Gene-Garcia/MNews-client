using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MalayanNews
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class AdminPostAnnouncement : AppCompatActivity
    {
        // components
        Button uploadPostBtn;
        TextView dateTextView;
        EditText subjectEditText;
        EditText contentEditText;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_admin_post_announcement);

            // initialization
            this.uploadPostBtn = FindViewById<Button>(Resource.Id.uploadPostBtn);
            this.dateTextView = FindViewById<TextView>(Resource.Id.dateTextView);
            this.subjectEditText = FindViewById<EditText>(Resource.Id.subjectEditText);
            this.contentEditText = FindViewById<EditText>(Resource.Id.contentEditText);

            this.dateTextView.Text = DateTime.Now.ToString();

            // event assignment
            this.uploadPostBtn.Click += this.UploadPost_Click;
        }

        private void UploadPost_Click(object sender, EventArgs e)
        {
            Intent homeAdminActivity = new Intent(this, typeof(AdminHomeActivity));
            StartActivity(homeAdminActivity);
        
        }
    }
}
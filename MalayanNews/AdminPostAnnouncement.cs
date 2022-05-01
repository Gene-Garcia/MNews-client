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

        private Boolean Validate()
        {
            if (string.IsNullOrEmpty(this.subjectEditText.Text) || string.IsNullOrEmpty(this.contentEditText.Text)) return false;
            else return true;
        }

        private string SoapServiceUpload()
        {
            mnews.MalayanNewsService service = new mnews.MalayanNewsService();

            mnews.AnnouncementObject newAnn = new mnews.AnnouncementObject();

            newAnn.subject = this.subjectEditText.Text;
            newAnn.uploadDate = DateTime.Now.ToString();
            newAnn.content = this.contentEditText.Text;

            return service.PostAnnouncement(newAnn);
        }

        // event
        private void UploadPost_Click(object sender, EventArgs e)
        {
            if (!this.Validate())
            {
                Toast.MakeText(this, "Subject and content data fields are required", ToastLength.Short).Show();
            } 
            else
            {
                string message = this.SoapServiceUpload();
                Toast.MakeText(this, message, ToastLength.Short).Show();

                Intent homeAdminActivity = new Intent(this, typeof(AdminHomeActivity));
                StartActivity(homeAdminActivity);
            }
        }
    }
}
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
    public class AdminEditAnnouncement : AppCompatActivity
    {
        // components
        Button saveEditBtn;
        TextView dateTextView;
        EditText subjectEditText;
        EditText contentEditText;

        mnews.AnnouncementObject announcement;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_admin_edit_announcement);

            // initialization
            this.saveEditBtn = FindViewById<Button>(Resource.Id.saveEditBtn);
            this.dateTextView = FindViewById<TextView>(Resource.Id.dateTextView);
            this.subjectEditText = FindViewById<EditText>(Resource.Id.subjectEditText);
            this.contentEditText = FindViewById<EditText>(Resource.Id.contentEditText);

            // get intent data ~ data of announcement to be edited
            int idx = Intent.GetIntExtra("announcementId", 0);

            this.SoapServiceCall(idx);

            // display data in fields
            this.subjectEditText.Text = this.announcement.subject;
            this.dateTextView.Text = this.announcement.uploadDate;
            this.contentEditText.Text = this.announcement.content;

            // event assignment
            this.saveEditBtn.Click += this.SaveEdit_Click;
        }

        private void SoapServiceCall(int idx)
        {
            mnews.MalayanNewsService service = new mnews.MalayanNewsService();

            this.announcement = service.Announcement(idx);
        }

        // events
        private void SaveEdit_Click(object sender, EventArgs e)
        {
            Intent homeAdminActivity = new Intent(this, typeof(AdminHomeActivity));
            StartActivity(homeAdminActivity);

        }
    }

}
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
        Button deleteBtn;
        TextView dateTextView;
        EditText subjectEditText;
        EditText contentEditText;

        int idx;
        mnews.AnnouncementObject announcement;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_admin_edit_announcement);

            // initialization
            this.saveEditBtn = FindViewById<Button>(Resource.Id.saveEditBtn);
            this.deleteBtn = FindViewById<Button>(Resource.Id.deleteBtn);
            this.dateTextView = FindViewById<TextView>(Resource.Id.dateTextView);
            this.subjectEditText = FindViewById<EditText>(Resource.Id.subjectEditText);
            this.contentEditText = FindViewById<EditText>(Resource.Id.contentEditText);

            // get intent data ~ data of announcement to be edited
            this.idx = Intent.GetIntExtra("announcementId", 0);

            this.SoapServiceGet();

            // display data in fields
            this.subjectEditText.Text = this.announcement.subject;
            this.dateTextView.Text = this.announcement.uploadDate;
            this.contentEditText.Text = this.announcement.content;

            // event assignment
            this.saveEditBtn.Click += this.SaveEdit_Click;
            this.deleteBtn.Click += this.Delete_Click;
        }

        private void SoapServiceGet()
        {
            mnews.MalayanNewsService service = new mnews.MalayanNewsService();

            this.announcement = service.Announcement(this.idx);
        }

        private Boolean Validate()
        {
            if (string.IsNullOrEmpty(this.subjectEditText.Text) || string.IsNullOrEmpty(this.contentEditText.Text)) return false;
            else return true;
        }

        private string SoapServiceUpload()
        {
            mnews.MalayanNewsService service = new mnews.MalayanNewsService();

            this.announcement.subject = this.subjectEditText.Text;
            //this.announcement.uploadDate = DateTime.Now.ToString();
            this.announcement.content = this.contentEditText.Text;

            return service.EditAnnouncement(announcement);
        }

        private string SoapServiceDelete()
        {
            mnews.MalayanNewsService service = new mnews.MalayanNewsService();

            return service.DeleteAnnouncement(this.idx);
        }

        // events
        private void SaveEdit_Click(object sender, EventArgs e)
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

        private void Delete_Click(object sender, EventArgs e)
        {
            // confirmation alert
            Android.App.AlertDialog.Builder dialog = new Android.App.AlertDialog.Builder(this);
            Android.App.AlertDialog alert = dialog.Create();
            alert.SetTitle("Announcement Deletion");
            alert.SetMessage("Confirm the deletion of this announcement");

            alert.SetButton("OK", (c, ev) =>
            {
                string message = this.SoapServiceDelete();
                Toast.MakeText(this, message, ToastLength.Short).Show();

                Intent homeAdminActivity = new Intent(this, typeof(AdminHomeActivity));
                StartActivity(homeAdminActivity);

            });

            alert.SetButton2("CANCEL", (c, ev) => { });

            alert.Show();
        }

    }

}
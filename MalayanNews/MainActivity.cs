using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace MalayanNews
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        // components
        Button studentBtn;
        Button adminBtn;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // Initialize components
            this.studentBtn = FindViewById<Button>(Resource.Id.studentBtn);
            this.adminBtn = FindViewById<Button>(Resource.Id.adminBtn);

            // onclick assignment
            this.adminBtn.Click += AdminBtn_Click;
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            Intent adminActivity = new Intent(this, typeof(AdminHomeActivity));
            StartActivity(adminActivity);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void TestAnnouncements()
        {
            //mnews.MalayanNewsService ms = new mnews.MalayanNewsService();

            //get all
            //mnews.AnnouncementObject[] announcements = ms.Announcements();

            //add one
            //mnews.AnnouncementObject newAnn = new mnews.AnnouncementObject();
            //newAnn.id = "1234";
            //newAnn.subject = "New subject 1234";
            //newAnn.uploadDate = "New upload date 1235";
            //newAnn.content = "New content 1235";
            //var upload = ms.PostAnnouncement(newAnn);

            //get all
            //mnews.AnnouncementObject[] announcements3 = ms.Announcements();

            //get one
            //mnews.AnnouncementObject search = ms.Announcement("1234");

            //update one
            //search.subject = "New subject 1234 UPDATED";
            //search.content = "New content 1235 UPDATED";
            //string updated = ms.EditAnnouncement(search);

            //get one
            //mnews.AnnouncementObject newSearch = ms.Announcement("1234");

            //delete
            //string deleted = ms.DeleteAnnouncement("1234");

            //get all
            //mnews.AnnouncementObject[] announcements2 = ms.Announcements();

        }

    }
}
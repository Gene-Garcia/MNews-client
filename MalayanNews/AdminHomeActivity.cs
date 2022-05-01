using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using MalayanNews.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MalayanNews
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class AdminHomeActivity : AppCompatActivity
    {
        // components
        Button addRedirectBtn;
        ListView announcementsListView;

        List<mnews.AnnouncementObject> announcements;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_admin_home);

            // initialization
            this.addRedirectBtn = FindViewById<Button>(Resource.Id.addRedirectBtn);
            this.announcementsListView = FindViewById<ListView>(Resource.Id.announcementsForEditListView);

            // onclick assignment
            this.addRedirectBtn.Click += this.RedirectBtn_Click;

            this.SoapServiceCall();

            // assignment of adapter to list view and configurations
            ClickableAnnouncementAdapter adapter = new ClickableAnnouncementAdapter(this, announcements);
            announcementsListView.Adapter = adapter;

            this.announcementsListView.ItemClick += this.AnnouncementList_Click;
        }

        private void SoapServiceCall()
        {
            mnews.MalayanNewsService service = new mnews.MalayanNewsService();

            this.announcements = service.Announcements().ToList();
        }

        // events
        private void RedirectBtn_Click(object sender, EventArgs e)
        {
            Intent postAnnouncementActivity = new Intent(this, typeof(AdminPostAnnouncement));
            StartActivity(postAnnouncementActivity);
        }

        private void AnnouncementList_Click(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, this.announcements[e.Position].subject, ToastLength.Short).Show();

            Intent editPostActivity = new Intent(this, typeof(AdminEditAnnouncement));
            StartActivity(editPostActivity);
        }
    }
}
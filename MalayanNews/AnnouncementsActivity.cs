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
    public class AnnouncementsActivity : AppCompatActivity
    {
        // components
        ListView announcementsListView;

        List<mnews.AnnouncementObject> announcements;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_announcements);

            // initiation
            this.announcementsListView = FindViewById<ListView>(Resource.Id.announcementstListView);

            // populate announcements
            this.SoapServiceCall();

            // adapter configurations
            ClickableAnnouncementAdapter adapter = new ClickableAnnouncementAdapter(this, this.announcements);
            this.announcementsListView.Adapter = adapter;
        }

        private void SoapServiceCall()
        {
            mnews.MalayanNewsService service = new mnews.MalayanNewsService();

            this.announcements = service.Announcements().ToList();
        }
    }
}
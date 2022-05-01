using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MalayanNews.Resources
{
    internal class ClickableAnnouncementAdapterViewHolder : Java.Lang.Object
    {
        public int Id { get; set; }
        public TextView subjectTextView { get; set; }
        public TextView uploadDateTextView { get; set; }
        public TextView contentTextView { get; set; }
    }

    internal class ClickableAnnouncementAdapter : BaseAdapter
    {
        private Activity activity;
        private List<mnews.AnnouncementObject> announcements;

        public ClickableAnnouncementAdapter(Activity activity, List<mnews.AnnouncementObject> announcements)
        {
            this.activity = activity;
            this.announcements = announcements;
        }

        //Fill in cound here, currently 0
        public override int Count
        {
            get
            {
                return this.announcements.Count();
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return this.announcements[position].id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? this.activity.LayoutInflater.Inflate(Resource.Layout._clickable_announcement_card_template, parent, false);

            // initiate components
            TextView subjectTextView = view.FindViewById<TextView>(Resource.Id.subjecTextView);
            TextView dateTextView = view.FindViewById<TextView>(Resource.Id.dateTextView);
            TextView contentTextView = view.FindViewById<TextView>(Resource.Id.contentTextView);

            //fill in your items
            subjectTextView.Text = this.announcements[position].subject;
            dateTextView.Text = this.announcements[position].uploadDate;
            contentTextView.Text = this.announcements[position].content;

            return view;
        }



    }

}
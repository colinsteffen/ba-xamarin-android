using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Shared.Model;
using static Android.Support.V7.Widget.RecyclerView;

namespace bm_ui_xam_platform.View
{
    public class InformationAdapter : BaseAdapter
    {
        List<Information> InformationList { get; set; }

        public InformationAdapter(List<Information> informationList)
        {
            this.InformationList = informationList;
        }

        public override int Count => InformationList.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position) => 0;

        public override Android.Views.View GetView(int position, Android.Views.View convertView, ViewGroup parent)
        {
            var view = convertView;

            if(view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.listview_item, parent, false);

                var start = view.FindViewById<TextView>(Resource.Id.starttext);
                var end = view.FindViewById<TextView>(Resource.Id.endTextView);

                start.Text = InformationList[position].Start;
                end.Text = InformationList[position].End;
            }

            return view;
        }
    }
}
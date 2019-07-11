using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;

namespace Grafuri
{
    [Activity(Label = "ShowItemList")]
    public class ShowItemList : Activity
    {
        private Android.Support.V7.Widget.Toolbar toolbar;
        private RecyclerView recyclerView;
        private List<String> itemList;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_show_item_list);
            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            recyclerView = FindViewById<RecyclerView>(Resource.Id.recycler_view);
            SetList(Intent.GetStringExtra(Utils.chapterExtra));            

        }

        private void SetList(String chapterType)
        {
            itemList = new List<String>();
            switch (chapterType)
            {
                case Utils.theoreme:
                    itemList.Add("T1");
                    itemList.Add("T2");
                    itemList.Add("T3");
                    break;

                case Utils.sentence:
                    itemList.Add("S1");
                    itemList.Add("S2");
                    itemList.Add("S3");
                    break;
            }
        }

    }
}
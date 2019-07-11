using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace Grafuri
{
    class ChapterAdapter : RecyclerView.Adapter<ChapterAdapter.ChapterHolder>()
    {
        private List<String> itemList;

        public ChapterAdapter(List<String> itemList)
        {
            this.itemList = itemList;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {

        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return new ChapterHolder(LayoutInflater.From(parent.Context).Inflate(Resource.Layout.)));
        }

        internal class ChapterHolder : RecyclerView.ViewHolder
        {
            public ChapterHolder(View itemView) : base(itemView)
            {
               
            }
        }
    }
}
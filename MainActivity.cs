using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Grafuri
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, View.IOnClickListener
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            FindViewById<Button>(Resource.Id.button_theoremes).SetOnClickListener(this);
            FindViewById<Button>(Resource.Id.button_sentences).SetOnClickListener(this);

        }

        public void OnClick(View v)
        {
            switch (v.Id)
            {
                case Resource.Id.button_theoremes:
                    StartActivity(new Android.Content.Intent(this, typeof(ShowItemList)).PutExtra(Utils.chapterExtra, Utils.theoreme));
                    break;

                case Resource.Id.button_sentences:
                    StartActivity(new Android.Content.Intent(this, typeof(ShowItemList)).PutExtra(Utils.chapterExtra, Utils.sentence));
                    break;
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

    }
}


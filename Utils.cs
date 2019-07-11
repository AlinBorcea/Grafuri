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

namespace Grafuri
{
    class Utils
    {
        public const String chapterExtra = "ChapterExtra";

        public const String theoreme = "Theoreme";
        public const String sentence = "Sentence";

        public static void ShowMessage(Context context, String message, bool isLong)
        {
            Toast.MakeText(context, message, (isLong ? ToastLength.Long : ToastLength.Short)).Show();
        }
    }
}
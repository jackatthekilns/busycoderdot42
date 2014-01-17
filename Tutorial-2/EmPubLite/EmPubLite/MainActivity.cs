using System;
using Android.App;
using Android.Os;
using Android.Widget;
using Dot42;
using Dot42.Manifest;

[assembly: Application("EmPubLite", Icon="@drawable/ic_launcher", Label="@string/app_name", Theme="@style/AppTheme")]
//I couldn't find info on the allowBackup property
[assembly: SupportsScreens(LargeScreens=true, NormalScreens=true, SmallScreens=false, XLargeScreens=true)]
[assembly: Package(VersionCode=1, VersionName="1.0")]
//The uses-sdk tag should be taken care of in the project properties


namespace EmPubLite
{
    [Activity(Label="@string/app_name")]
    //can't find info on the name property
    [IntentFilter(Actions=new[]{"android.intent.action.MAIN"}, Categories=new[]{"android.intent.category.LAUNCHER"})]

    public class EmPubLiteActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstance)
        {
            base.OnCreate(savedInstance);
            SetContentView(R.Layouts.Main);
        }

        public override bool OnCreateOptionsMenu(Android.View.IMenu menu)
        {
            // Inflate the menu; this adds items to the action bar
            // if it is present.
            MenuInflater.Inflate(R.Menus.Activity_Menu, menu);
            return true;
        }
    }
}

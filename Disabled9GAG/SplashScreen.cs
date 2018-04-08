using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Disabled9GAG
{
    [Activity(
        Label = "Disabled9GAG"
        , MainLauncher = true
        , Icon = "@drawable/Icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}

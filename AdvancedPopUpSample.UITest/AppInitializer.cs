using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace AdvancedPopUpSample.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                // return ConfigureApp.Android.StartApp();
                // String apkpath = "C:\\Users\\Administrator\\AppData\\Local\\Xamarin\\Mono for Android\\Archives\\2020-12-02\\AdvancedPopUpSample.Android 12-02-20 4.08 PM.apkarchive\\com.askxammy.AdvancedPopUpSample.AdvancedPopUpSample.apk";
                return ConfigureApp.Android.InstalledApp("com.askxammy.AdvancedPopUpSample.AdvancedPopUpSample").Debug().StartApp();
                // String apkpath = "C:\\Users\\Administrator\\source\\repos\\AdvancedPopUpSample\\AdvancedPopUpSample.Android\\bin\\Debug\\com.askxammy.AdvancedPopUpSample.AdvancedPopUpSample.apk";
                // return ConfigureApp.Android.ApkFile(apkpath).StartApp();
                // return ConfigureApp.Android.ApkFile(apkpath).Debug().EnableLocalScreenshots().StartApp();
;
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}
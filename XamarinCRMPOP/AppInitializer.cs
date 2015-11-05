using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public static class AppInitializer
    {
        const string apkPath = "../../../com.xamarin.xamarincrm-Signed.apk";

        public static AndroidApp StartApp()
        {
            return ConfigureApp
                .Android
                .ApkFile(apkPath)
                .StartApp();
        }
    }
}
using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class SplashScreenPage : BasePage
    {
        readonly string EnterSignInButton = "SKIP SIGN IN (demo)";

        public SplashScreenPage(AndroidApp app)
            : base(app, "SIGN IN")
        {
        }

        public void ExitSplashScreen()
        {
            app.Tap(EnterSignInButton);
        }
    }
}


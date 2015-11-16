using System;
using Xamarin.UITest;
using NUnit.Framework;
using Xamarin.UITest.Android;

namespace Best.Practices
{
    public class Test
    {
        public AndroidApp app;

        public void Setup(bool clear)
        { 
            var appConfig = ConfigureApp
                .Android
                .ApkFile("../../../com.xamarin.xamarincrm-Signed.apk");
            
            if (clear)
                app = appConfig.StartApp();
            else
                app = appConfig.StartApp(Xamarin.UITest.Configuration.AppDataMode.DoNotClear);
            
        }

        public void SignIn()
        {
            app.Tap(x => x.Class("FormsTextView").Text("SIGN IN"));
            app.Screenshot("Tapped on view FormsTextView with Text: 'SIGN IN'");

            app.Tap(x => x.Class("WebView").Id("agentWebView").Css("#cred_userid_inputtext"));
            app.EnterText(x => x.Class("WebView").Id("agentWebView").Css("#cred_userid_inputtext"), "sally@xamcrm.onmicrosoft.com");
            app.Tap(x => x.Class("WebView").Id("agentWebView").Css("#cred_password_inputtext"));
            app.EnterText(x => x.Class("WebView").Id("agentWebView").Css("#cred_password_inputtext"), "P@ssword");
            app.Screenshot("Username and password entered");

            app.Tap(x => x.Class("WebView").Id("agentWebView").Css("#cred_sign_in_button"));
            app.Screenshot("Tapped on sign in button");
        }

        [Test]
        public void TryCatchTest()
        {
            Setup(false);
            SignIn();

            try
            {
            }
            catch
            {
            }
        }

        [Test]
        public void LoopTest()
        {
            Setup(true);

            app.Tap("SKIP SIGN IN (demo)");
            app.WaitForElement("6-Week Sales");

            CustomScrollDownTo("Rockridge Hotel", 4);
        }

        private void CustomScrollDownTo(string marked, int maxTries)
        {

            for (int i = 0; i < maxTries; i++)
            {
                // TODO: Scroll down until the "marked" element is visible or maxTries have been met
            }

            // TimeoutException is thrown if the element isn't found before maxTries is reached
            throw new TimeoutException("Unable to find element marked: '" + marked + "'");
        }
    }
}


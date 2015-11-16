using System;
using Xamarin.UITest;
using NUnit.Framework;
using Xamarin.UITest.Android;

namespace Best.Practices
{
    public class Test
    {
        public AndroidApp app;

        public void Setup()
        { 
            app = ConfigureApp
                .Android
                .ApkFile("../../../com.xamarin.xamarincrm-Signed.apk")
//                .StartApp();
                .StartApp(Xamarin.UITest.Configuration.AppDataMode.DoNotClear);
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
            Setup();
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
        }
    }
}


using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace XamarinCRM
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            app = ConfigureApp
				.Android
                .ApkFile ("../../../com.xamarin.xamarincrm-Signed.apk")
				.StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }
    }
}


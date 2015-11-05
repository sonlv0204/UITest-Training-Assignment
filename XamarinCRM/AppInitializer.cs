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
    public abstract class BaseTest
    {
        protected AndroidApp app;

        protected BaseTest()
        {
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = ConfigureApp
				.Android
                .ApkFile ("../../../com.xamarin.xamarincrm-Signed.apk")
				.StartApp();
        }

    }
}


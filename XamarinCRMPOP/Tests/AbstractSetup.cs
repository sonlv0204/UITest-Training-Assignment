using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    [TestFixture]
    public abstract class AbstractSetup
    {
        protected AndroidApp app;

        protected AbstractSetup()
        {
        }

        [SetUp]
        public virtual void BeforeEachTest()
        {
            app = AppInitializer.StartApp();

            Thread.Sleep(TimeSpan.FromSeconds(5));

            if (app.Query("SIGN IN").Any())
            {
                new SplashScreenPage(app)
                    .ExitSplashScreen();
            }

            //waiting for next screen to load
            Thread.Sleep(TimeSpan.FromSeconds(5));

            app.Screenshot("On Home Page");
        }
    }
}

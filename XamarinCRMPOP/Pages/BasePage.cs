using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class BasePage
    {
        protected readonly AndroidApp app;

        protected BasePage(AndroidApp app)
        {
            this.app = app;
        }

        protected BasePage(AndroidApp app, Func<AppQuery, AppQuery> androidTrait)
            : this(app)
        {
            Assert.DoesNotThrow(() => app.WaitForElement(androidTrait), "Unable to verify on page: " + this.GetType().Name);

            app.Screenshot("On " + this.GetType().Name);
        }

        protected BasePage(AndroidApp app, string androidTrait)
            : this(app, x => x.Marked(androidTrait))
        {
        }
    }
}


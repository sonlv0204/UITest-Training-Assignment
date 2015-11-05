using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class ABSFilamentPage : BasePage
    {
        public ABSFilamentPage(AndroidApp app)
            : base(app, "FIL-ABS-VLT")
        {
        }

        public void SelectColor(string color)
        {
            var colorChosen = string.Format("FIL-ABS-{0}", color);
            app.ScrollDownTo(colorChosen);
            app.Tap(colorChosen);
        }
    }
}


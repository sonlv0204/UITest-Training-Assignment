using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class ThreeDFilamentPage : BasePage
    {
        public ThreeDFilamentPage(AndroidApp app)
            : base(app, "PLA Filament")
        {
        }

        public void SelectPart(string partName)
        {
            app.Tap(partName);
        }
    }
}


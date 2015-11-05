using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class PartsPage : BasePage
    {
        public PartsPage(AndroidApp app)
            : base(app, "Build Plates")
        {
        }

        public void SelectPart(string partName)
        {
            app.Tap(partName);
        }
    }
}


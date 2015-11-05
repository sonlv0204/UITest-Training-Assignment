using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class ThreeDPrinterKitsPage : BasePage
    {
        public ThreeDPrinterKitsPage(AndroidApp app)
            : base(app, "ABS 3D Printer Kits")
        {
        }

        public void SelectPart(string partName)
        {
            app.Tap(partName);
        }
    }
}


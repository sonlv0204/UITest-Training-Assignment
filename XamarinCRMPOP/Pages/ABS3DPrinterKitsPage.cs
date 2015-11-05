using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class ABS3DPrinterKitsPage : BasePage
    {
        public ABS3DPrinterKitsPage(AndroidApp app)
            : base(app, "ABS-CELL")
        {
        }

        public void SelectItem(string itemName)
        {
            var itemChosen = string.Format("ABS-{0}", itemName);
            app.ScrollTo(itemChosen);
            app.Tap(itemChosen);
        }
    }
}


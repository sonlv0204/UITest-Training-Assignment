using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class CoolingFansPage : BasePage
    {
        public CoolingFansPage(AndroidApp app)
            : base(app, "FAN-003")
        {
        }

        public void SelectItem(int itemNumber)
        {
            var itemChosen = string.Format("FAN-00{0}", itemNumber);
            app.ScrollTo(itemChosen);
            app.Tap(itemChosen);
        }
    }
}


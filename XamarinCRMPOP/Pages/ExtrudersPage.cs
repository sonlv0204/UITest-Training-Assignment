using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class ExtruderPage : BasePage
    {
        public ExtruderPage(AndroidApp app)
            : base(app, "EXTR-001")
        {
        }

        public void SelectItem(int itemNumber)
        {
            var itemChosen = string.Format("EXTR-00{0}", itemNumber);
            app.ScrollDownTo(itemChosen);
            app.Tap(itemChosen);
        }
    }
}


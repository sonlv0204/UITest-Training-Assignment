using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class BuildPlatesPage : BasePage
    {
        public BuildPlatesPage(AndroidApp app)
            : base(app, "BLD-PLT-PLA")
        {
        }

        public void SelectItem(string itemName)
        {
            app.Tap(itemName);
        }
    }
}


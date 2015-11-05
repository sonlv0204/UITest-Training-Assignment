using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class PLA3DPrinterKitsPage : BasePage
    {
        public PLA3DPrinterKitsPage(AndroidApp app)
            : base(app, "PLA-JEWEL")
        {
        }

        public void SelectItem(string itemName)
        {
            var itemChosen = string.Format("PLA-{0}", itemName);
            app.ScrollDownTo(itemChosen);
            app.Tap(itemChosen);
        }
    }
}


using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class StepperMotorsPage : BasePage
    {
        public StepperMotorsPage(AndroidApp app)
            : base(app, "MOT-12V")
        {
        }

        public void SelectItem(int itemNumber)
        {
            var itemChosen = string.Format("MOT-{0}-V", itemNumber);
            app.ScrollTo(itemChosen);
            app.Tap(itemChosen);
        }
    }
}


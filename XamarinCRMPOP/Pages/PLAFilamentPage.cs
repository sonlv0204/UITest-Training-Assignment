using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class PLAFilamentPage : BasePage
    {
        public PLAFilamentPage(AndroidApp app)
            : base(app, "FIL-PLA-VLT")
        {
        }

        public void SelectColor(string color)
        {
            var colorChosen = string.Format("FIL-PLA-{0}", color);
            app.ScrollDownTo(colorChosen);
            app.Tap(colorChosen);
        }
    }
}


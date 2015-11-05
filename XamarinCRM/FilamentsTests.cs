using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace XamarinCRM
{
    public class FilamentsTests : BaseTest
    {
        public FilamentsTests()
        {
        }

        [Test]
        public void SelectingFilamentColor ()
        {
            app.Tap(x => x.Class("FormsTextView").Text("SKIP SIGN IN (demo)"));
            app.Screenshot("Tapped: 'SKIP SIGN IN (demo)'");

            app.WaitForElement(x => x.Marked("6-Week Sales"));

            app.Tap(x => x.Class("TextView").Text("Products"));
            app.Screenshot("Tapped on: 'Products'");

            app.Tap(x => x.Class("FormsTextView").Text("3D Filament"));
            app.Screenshot("Tapped on: '3D Filament'");

            app.Tap(x => x.Class("TextField").Text("PLA Filament"));
            app.Screenshot("Tapped on: 'PLA Filament'");

            app.Tap(x => x.Class("FormsTextView").Text("FIL-PLA-YLW"));
            app.Screenshot("Tapped on: 'FIL-PLA-YLW'");

            app.WaitForElement(x => x.Class("FormsTextView").Text("Yellow PLA filament, yellow 500 grams"));
            app.Screenshot("Waited for element: 'Yellow PLA filament, yellow, 500 grams'");

            app.Back();
            app.Back();

            app.WaitForElement(x => x.Marked("3D Filament"));
            app.Screenshot("Should be on the 3D Filament page now");

            app.Tap(x => x.Class("FormTextView").Text("ASB Filament"));
            app.Screenshot("Tapped on: 'ABS Filament'");

            app.Tap(x => x.Class("FormsTextView").Text("FIL-ABS-YLW"));
            app.Screenshot("Tapped on: 'FIL-ABS-YLW'");

            app.WaitForElement(x => x.Class("FormsTextView").Text("Yellow PLA filament, yellow, 500 grams"));
            app.Screenshot("Waited for element: 'Yellow ABS filament, yellow, 500 grams'");
        }
    }
}


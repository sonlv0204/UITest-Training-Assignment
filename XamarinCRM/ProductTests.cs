using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace XamarinCRM
{
    public class ProductTests :BaseTest
    {
        public ProductTests()
        {
        }

        [Test]
        public void PartsLoadCheck ()
        {
            app.Tap(x => x.Class("FormsTextView").Text("SKIP SIGN IN (demo)"));
            app.Screenshot("Tapping on SKIP SIGN IN (demo) button");

            app.WaitForElement(x => x.Marked("LEADS"));
            app.Screenshot("Should be on Main Page");

            app.Tap(x => x.Class("TextView").Text("Products"));
            app.Screenshot("Tapping on 'Products' Tab");

            app.WaitForElement(x => x.Marked("3D Printer Kits"));
            app.Screenshot("Should be on Products Page");

            app.Tap(x => x.Class("Parts"));
            app.Screenshot("Tap on Parts Option");

            app.WaitForElement(x => x.Marked("Extruders"));
            app.Screenshot("Should be on Parts Option Page");

            app.Tap(x => x.Class("FormsTextView").Text("The flat surface upon which 3D objects are printed."));
            app.Screenshot("Tapping on Build Plates");

            app.WaitForElement(x => x.Marked("BLD-PLT-PLA"));
            app.Screenshot("Should be on Build Plates Page");

            app.Tap(x => x.Class("FormsTextView").Text("A heated build plate for ABS filament projects."));
            app.Screenshot("Tapping on BOLD-PLT-ABS ");

            app.WaitForElement(x => x.Marked("BLD-PLT-ABS"));
            app.Screenshot("Verfied on BLD-PLT-ABS Build Plates Page");

            app.Back();
            app.Back();
            app.Back();
            app.WaitForElement(x => x.Marked("3D Printer Kits"));
            app.Screenshot("Back to Products Page");
        }
    }
}


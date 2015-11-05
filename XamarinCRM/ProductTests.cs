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
            app.Screenshot("Tapped on view FormsTextView with Text: 'SKIP SIGN IN (demo)'");

            app.WaitForElement(x => x.Marked("LEADS"));
            app.Screenshot("On Main Page");

            app.Tap(x => x.Class("TextView").Text("Products"));
            app.Screenshot("Tapped on view TextView with Text: 'Products'");

            app.Tap(x => x.Class("FormsTextView").Text("The flat surface upon which 3D objects are printed."));
            app.Screenshot("Tapped on Build Plates");

            app.WaitForElement(x => x.Marked("BLD-PLT-PLA"));
            app.Screenshot("On Build Plates Page");

            app.Tap(x => x.Class("FormsTextView").Text("A heated build plate for ABS filament projects."));
            app.Screenshot("Tapped on BOLD-PLT-ABS ");

            app.WaitForElement(x => x.Marked("BLD-PLT-ABS"));
            app.Screenshot("On BLD-PLT-ABS Build Plates Page");

            app.Back();

            app.Back();

            app.Back();
            app.WaitForElement(x => x.Marked("3D Printer Kits"));
            app.Screenshot("Back to Products Page");
        }
    }
}


using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace XamarinCRM
{
    public class CustomerTests : BaseTest
    {
        public CustomerTests()
        {
        }

        [Test]
        public void CheckCustomerDetails()
        {
            app.Tap(x => x.Class("FormsTextView").Text("SKIP SIGN IN (demo)"));
            app.Screenshot("Tapped on view FormsTextView with Text: 'SKIP SIGN IN (demo)'");

            app.Tap(x => x.Class("TextView").Text("Customers"));
            app.Screenshot("Tapped on view TextView with Text: 'Customers'");

            app.Tap((x => x.Class("ViewCellRenderer_ViewCellContainer").Index(0)));
            app.Screenshot("Selected first customer present");

            app.WaitForElement(x => x.Class("FormsTextView").Text("Contact"));
            app.WaitForElement(x => x.Class("FormsTextView").Text("Phone"));
            app.WaitForElement(x => x.Class("FormsTextView").Text("Address"));
            app.Screenshot("Contact info verified as present");
        }
    }
}


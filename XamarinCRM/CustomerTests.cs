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
            //Test should click into the customers tab, select the first customer present 
            //and verify the name, phone and address fields are present

            app.Tap(x => x.Class("FormsTextView").Text("SKIP SIGN IN (demo)"));
            app.Screenshot("Tapped on: 'SKIP SIGN IN (demo)'");

            app.Tap(x => x.Class("TextFieldView").Text("Customers"));
            app.Screenshot("Tapped on: 'Customers'");

            app.Tap((x => x.Class("ViewCellRenderer_ViewCellContainer").Index(0)));
            app.Screenshot("Selected first customer present");

            app.WaitForElement(x => x.Class("FormsTxtView").Text("Contact"));
            app.WaitForElement(x => x.Class("FormsTxtView").Text("Phone"));
            app.WaitForElement(x => x.Class("FormsTxtView").Text("Addres"));
            app.Screenshot("Contact info verified as present");
        }
    }
}


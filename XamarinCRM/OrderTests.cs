using System;
using Xamarin.UITest;
using NUnit.Framework;

namespace XamarinCRM
{
    public class OrderTests : BaseTest
    {
        public OrderTests()
        {
        }

        [Test]
        public void AddNewOrderTest ()
        {
            app.Tap(x => x.Class("FormsTextView").Text("SKIP SIGN IN (demo)"));
            app.Screenshot("Tapped on 'SKIP SIGN IN (demo)' button");

            app.WaitForElement(x => x.Marked("LEADS"));
            app.Screenshot("Should be on Main Page");

            app.Tap(x => x.ClassFull("com.android.internal.widget.ScrollingTabContainerView$TabView").Index(1));
            app.Screenshot("Tapping on Customers Tab");

            app.WaitForElement(x => x.Marked("Bay Unified School District"));
            app.Screenshot("Should be on Customers Page");

            app.Tap(x => x.Class("FormsTextView").Text("Bay Unified School District"));
            app.Screenshot("Tap on first Customer in List");

            app.WaitForElement(x => x.Marked("Bay Unified School District"));
            app.Screenshot("On the Bay Unified School District Details Page");

            app.Tap(x => x.Class("TextView").Text("Orders"));
            app.Screenshot("Tapped on view TextView with Text: 'Orders'");

            app.WaitForElement(x => x.Marked("Open Orders"));
            app.Screenshot("On the Customer Orders Page");

            app.Tap(x => x.Id("AddButton"));
            app.Screenshot("Clicked on Add New Order Button");

            app.WaitForElement(x => x.Marked("PRODUCT"));
            app.Screenshot("On the Add New Order Form");

            app.Tap(x => x.Class("EntryEditText"));
            app.Screenshot("Tapped on Product Field");


            app.Tap(x => x.Text("FormsTextView"));
            app.Screenshot("Selecting 3D Printer Product");

            app.Tap(x => x.Class("FormsTextView").Text("Printer kits that are pre-configured for ABS filament."));
            app.Screenshot("Tapped on ABS 3D Printer Kit");

            app.Tap(x => x.Class("FormsTextView").Text("ABS-3DSGNR"));
            app.Screenshot("Tapped on ABS-3DSGNR");

            app.EnterText(x => x.Class("EntryEditText"), "A9");
            app.Screenshot("Product added to form");

            app.Tap(x => x.Class("FormsTextView").Text("ADD TO ORDER"));
            app.Screenshot("Tapped on view FormsTextView with Text: 'ADD TO ORDER'");

            app.Tap(x => x.Class("ActionMenuItemView").Text("Save"));
            app.Screenshot("Tapped on view ActionMenuItemView with Text: 'Save'");

            app.Screenshot("Save Confirmation Dialog Appears");
            app.Tap(x => x.Class("Button").Id("button1").Text("Save"));
            app.Screenshot("Tapped on view Button with ID: 'button1' with Text: 'Save'");
        }
    }
}


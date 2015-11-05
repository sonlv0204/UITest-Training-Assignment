using System;
using NUnit.Framework;

namespace XamarinCRM
{
    public class ExamineLead : BaseTest
    {
        public ExamineLead()
        {
        }

        [Test]
        public void ExamineALead ()
        {
            app.WaitForElement("SKIP SIGN IN (demo)");
            app.Screenshot("On sign in page.");

            app.Tap(x => x.Class("FormsTextView").Text("SKIP SIGN IN (demo)"));
            app.WaitForElement("LEADS");
            app.Screenshot("Skipping sign in, on home page");

            app.Tap(x => x.Class("FormsTextView").Text("Bay Tech Credit Union"));
            app.WaitForElement("Opportunity");
            app.Screenshot("Tapping on company Bay Tech Credit Union");

            app.Tap(x => x.ClassFull("com.android.internal.widget.ScrollingTabContainerView$TabView"));
            app.WaitForElement("Role");
            app.Screenshot("Tap to view Contact info");

            app.Tap(x => x.ClassFull("com.android.internal.widget.ScrollingTabContainerView$TabView"));
            app.WaitForElement("Opportunity");
            app.Screenshot("Tap to view Details again");

            app.Tap(x => x.Class("ActionMenuItemView").Text("Exit"));
            app.Screenshot("Exiting the lead");

            app.Tap(x => x.Class("Button").Id("button1").Text("Exit and Discard"));
            app.Screenshot("Decline to save");
        }
    }
}


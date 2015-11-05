using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class CustomersPage : BasePage
    {
        readonly Query FirstContact;

        public CustomersPage(AndroidApp app)
            : base(app, "Customers")
        {
            FirstContact = x => x.Class("LabelRenderer").Index(0).Child(0);
        }

        public void ClickFirstContact()
        {
            app.Tap(FirstContact);
        }

        public void ClickContact(string contact)
        {
            app.Tap(contact);
        }

    }
}


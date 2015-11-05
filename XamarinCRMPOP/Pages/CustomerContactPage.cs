using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using System.Threading;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class CustomerContactPage : BasePage
    {
        protected string CustomerOrders = "Orders";
        protected string CustomerSales = "Sales";
        protected string DialCancelButton = "No";

        protected Query PhoneButton;
        protected Query MapButton;
        protected Query HeaderImage;

        public CustomerContactPage(AndroidApp app)
            : base(app, "Address")
        {

            PhoneButton = x => x.Class("FormsImageView").Index(2);
            MapButton = x => x.Class("FormsImageView").Index(3);
            HeaderImage = x => x.Class("ImageRenderer").Index(0);
        }

        public CustomerContactPage VerifyContactInfoPresent()
        {
            app.WaitForElement("Contact", timeoutMessage: "Contact info not present");
            app.WaitForElement("Phone", timeoutMessage: "Phone info not present");
            app.WaitForElement("Adress", timeoutMessage: "Address info not present");

            return this;
        }

        public void NavigateToCustomerOrders()
        {
            app.WaitForElement(HeaderImage);
            Thread.Sleep(3000);
            app.Tap(CustomerOrders);
        }

        public void NavigateToCustomerSales()
        {
            app.Tap(CustomerSales);
        }

        public void CheckPhone()
        {
            app.Tap(PhoneButton);
            app.Screenshot("Open phone");
            app.Tap(DialCancelButton);
            app.Screenshot("Cancel call");
            app.Tap(PhoneButton);
            app.Screenshot("Open phone again");
        }

        public void CheckNavigation()
        {
            app.Tap(MapButton);
            app.Screenshot("Open maps");
        }
    }
}


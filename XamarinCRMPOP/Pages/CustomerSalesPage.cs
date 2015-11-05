using System;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class CustomerSalesPage : BasePage
    {
        readonly Query CustomerOrders = x => x.Marked("Orders");
        readonly Query CustomerContact = x => x.Marked("Customer");

        public CustomerSalesPage(AndroidApp app)
            : base(app)
        {
            app.WaitForElement("WEEKLY AVERAGE", timeout: TimeSpan.FromMinutes(2));

            app.Screenshot("On " + this.GetType().Name);
        }


        public void NavigateToCustomerOrders()
        {
            app.Tap(CustomerOrders);
        }

        public void NavigateToCustomerContact()
        {
            app.Tap(CustomerContact);
        }
    }
}


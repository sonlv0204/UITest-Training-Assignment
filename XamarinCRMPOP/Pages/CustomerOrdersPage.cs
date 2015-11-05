using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class CustomerOrdersPage : BasePage
    {
        readonly Query CustomerContact = x => x.Marked("Customer");
        readonly Query CustomerSales = x => x.Marked("Sales");
        readonly Query NewOrderButton;
        readonly Query SecondOrder;

        public CustomerOrdersPage(AndroidApp app)
            : base(app, "Open Orders")
        {
            SecondOrder = x => x.Class("LabelRenderer").Child(20);
            NewOrderButton = x => x.Class("FormsImageView");
        }

        public void NavigateToCustomerContact()
        {
            app.Tap(CustomerContact);
        }

        public void NavigateToCustomerSales()
        {
            app.Tap(CustomerSales);
        }

        public void SelectFirstOrder()
        {
            app.Tap(SecondOrder);
        }

        public void AddNewOrder()
        {
            app.Tap(NewOrderButton);
        }
    }
}


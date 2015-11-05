using System;
using System.Threading;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class GlobalPage : BasePage
    {
        readonly string BackButton;
        readonly string SalesTab;
        readonly string CustomersTab;
        readonly string ProductsTab;

        public GlobalPage(AndroidApp app)
            : base(app)
        {
            SalesTab = "Sales";
            CustomersTab = "Customers";
            ProductsTab = "Products";
        }

        public void GoBack()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));

            app.Back();

            Thread.Sleep(TimeSpan.FromSeconds(1));
        }

        public void NavigateToSales()
        {
            app.Tap(SalesTab);
        }

        public void NavigateToCustomers()
        {
            app.Tap(CustomersTab);
        }

        public void NavigateToProducts()
        {
            app.Tap(ProductsTab);
        }
    }
}


using NUnit.Framework;
using Xamarin.UITest;

namespace XamarinCRMPOP
{
    public class OrderTests : AbstractSetup
    {
        public OrderTests()
            : base()
        {
        }

        [Test]
        public void AddNewOrder()
        {
            new GlobalPage(app)
                .NavigateToCustomers();

            new CustomersPage(app)
                .ClickFirstContact();

            new CustomerContactPage(app)
                .NavigateToCustomerOrders();

            new CustomerOrdersPage(app) 
                .AddNewOrder();

            new CustomerOrderDetailsPage(app)
                .ChangeProduct();

            new ProductsPage(app)
                .SelectProduct("3D Printer Kits");

            new ThreeDPrinterKitsPage(app)
                .SelectPart("PLA 3D Printer Kits");

            new PLA3DPrinterKitsPage(app)
                .SelectItem("DELIKT");

            new ProductDetailsPage(app)
                .AddToOrder();

            new CustomerOrderDetailsPage(app)
                .SaveAndExit();

        }
    }
}

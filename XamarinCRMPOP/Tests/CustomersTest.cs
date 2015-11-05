using NUnit.Framework;
using Xamarin.UITest;

namespace XamarinCRMPOP
{
    public class CustomersTest : AbstractSetup
    {
        public CustomersTest()
        {
        }

        [Test]
        public void CheckCustomerDetails()
        {
            new GlobalPage(app)
                .NavigateToCustomers();

            new CustomersPage(app)
                .ClickFirstContact();

            new CustomerContactPage(app)
                .VerifyContactInfoPresent();
        }
    }
}


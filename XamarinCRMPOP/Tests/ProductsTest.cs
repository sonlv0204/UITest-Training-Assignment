using NUnit.Framework;
using Xamarin.UITest;

namespace XamarinCRMPOP
{
    public class ProductTests : AbstractSetup
    {
        public ProductTests()
            : base()
        {
        }

        [Test]
        public void PartsLoadCheck()
        {
            new GlobalPage(app)
                .NavigateToProducts();

            new ProductsPage(app)
                .SelectProduct("Parts");

            new PartsPage(app)
                .SelectPart("Build Plates");

            new BuildPlatesPage(app)
                .SelectItem("BLD-PLT-ABS");

            new ProductDetailsPage(app)
                .VerifyProduct();

            new GlobalPage(app)
                .GoBack();

            new GlobalPage(app)
                .GoBack();

            new GlobalPage(app)
                .GoBack();

            new ProductsPage(app);
        }
    }
}

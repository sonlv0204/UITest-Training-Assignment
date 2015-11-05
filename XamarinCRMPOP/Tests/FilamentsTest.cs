using NUnit.Framework;
using Xamarin.UITest;

namespace XamarinCRMPOP
{
    public class FilamentsTest : AbstractSetup
    {
        public FilamentsTest()
            : base()
        {
        }

        [Test]
        public void SelectingFilamentColor()
        {
            string color = "YWL";

            new GlobalPage(app)
                .NavigateToProducts();

            new ProductsPage(app)
                .SelectProduct("3D Filament");

            new ThreeDFilamentPage(app)
                .SelectPart("PLA Filament");

            new PLAFilamentPage(app)
                .SelectColor(color);

            new GlobalPage(app)
                .GoBack();

            new GlobalPage(app)
                .GoBack();

            new ThreeDFilamentPage(app)
                .SelectPart("PLA Filament");

            new ABSFilamentPage(app)
                .SelectColor(color);
        }
    }
}


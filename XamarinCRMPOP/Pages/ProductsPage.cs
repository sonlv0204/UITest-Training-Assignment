using Xamarin.UITest;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class ProductsPage : BasePage
    {
        public ProductsPage(AndroidApp app)
            : base(app, "Products")
        {
        }

        public void SelectProduct(string productName)
        {
            app.PressEnter();

        }
    }
}


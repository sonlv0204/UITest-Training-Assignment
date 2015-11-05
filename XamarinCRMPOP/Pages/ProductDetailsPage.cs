using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class ProductDetailsPage : BasePage
    {
        readonly Query AddToOrderButton = x => x.Marked("ADD TO ORDER");

        public ProductDetailsPage(AndroidApp app)
            : base(app, "action_bar_container")
        {
        }

        public void VerifyProduct()
        {
            //TODO Add logic
            app.Screenshot("Product Details Page");
        }

        public void AddToOrder()
        {
            app.Tap(AddToOrderButton);
        }
    }
}


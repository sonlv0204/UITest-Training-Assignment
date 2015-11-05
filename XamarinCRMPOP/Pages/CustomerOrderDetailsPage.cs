using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class CustomerOrderDetailsPage : BasePage
    {
        readonly Query SaveButton = x => x.Marked("Save");
        readonly Query ExitButton = x => x.Marked("Exit");
        readonly Query DeliverOrderButton = x => x.Marked("Deliver Order");
        readonly Query ConfirmDeliveryButton = x => x.Marked("Yes, Deliver");
        readonly Query ProductField;
        readonly Query PriceField;
        readonly Query DateField;

        public CustomerOrderDetailsPage(AndroidApp app)
            : base(app, "Company")
        {
            ProductField = x => x.Class("EntryEditText").Descendant(0);
            PriceField = x => x.Class("EntryEditText").Descendant(1);
            DateField = x => x.Class("EditText").Index(0);
        }

        public CustomerOrderDetailsPage ChangeProduct()
        {
            app.Tap(ProductField);
            return this;
        }

        public CustomerOrderDetailsPage ChangePrice(int amount)
        {
            app.Tap(PriceField);
            app.ClearText();
            app.EnterText(amount.ToString());
            app.PressEnter();

            return this;
        }

//        public CustomerOrderDetailsPage ChangeDate()
//        {
//            //TODO: Need to Add Logic
//
//
//            return this;
//        }
//
        public void SaveAndExit()
        {
            app.Tap(SaveButton);
            app.Screenshot("Dialog Appears");
            app.Tap(SaveButton);
        }

        public void DeliverOrder()
        {
            app.Tap(DeliverOrderButton);
            app.Screenshot("Dialog Appears");
            app.Tap(ConfirmDeliveryButton);

        }
    }
}


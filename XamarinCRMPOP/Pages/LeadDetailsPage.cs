using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest.Android;

namespace XamarinCRMPOP
{
    public class LeadDetailsPage : BasePage
    {
        readonly Query ContactTab;
        readonly Query EditCompany;
        readonly Query EditIndustry;
        readonly Query EditSize;
        readonly Query EditStage;
        readonly Query Done;
        readonly Query Save;
        readonly Query ScrollPanel;
        readonly Query OkButton;
        readonly Query DismissSelection;

        public LeadDetailsPage(AndroidApp app)
            : base(app, "Opportunity")
        {
                ContactTab = x => x.Descendant("Contact");
                EditCompany = x => x.Marked("Company").Sibling();
                EditIndustry = x => x.Class("android.widget.EditText").Index(1);
                EditSize = x => x.Marked("Size").Sibling();
                EditStage = x => x.Class("android.widget.EditText").Index(3);
                Done = x => x.Marked("Save");
                Save = x => x.Marked("Save");
                ScrollPanel = x => x.Marked("customPanel");
                OkButton = x => x.Marked("button1");
        }

        public void GoToLeadContact()
        {
            app.Tap(ContactTab);
        }

        public LeadDetailsPage EnterLeadDetails(
            string company,
            string industry,
            string size,
            string stage)
        {
            app.Tap(EditCompany);
            app.ClearText();
            app.ClearText();
            app.EnterText(company);
            app.DismissKeyboard();

            SelectNewIndustry(industry);

            app.ClearText(EditSize);
            app.EnterText(EditSize, size);
            app.DismissKeyboard();

            SelectNewStage(stage);

            return this;
        }

        public void SaveLead()
        {
            app.Tap(Save);
            app.Tap(Save);
        }

        public LeadDetailsPage SelectNewIndustry(string industry)
        {
            app.Tap(EditIndustry);
            app.ScrollDown(ScrollPanel);
            app.Tap(OkButton);

            return this;
        }

        public LeadDetailsPage SelectNewStage(string stage)
        {
            app.Tap(EditStage);
            app.ScrollDown(ScrollPanel);
            app.Tap(OkButton);

            return this;
        }
    }
}


using NUnit.Framework;
using Xamarin.UITest;

namespace XamarinCRMPOP
{
    public class ExamineLeadTests : AbstractSetup
    {
        public ExamineLeadTests()
            : base()
        {
        }

        [Test]
        public void ExamineLead()
        {
            new SalesHomePage(app)
                .ClickOnFirstLead();
            
            new LeadDetailsPage(app)
                .GoToLeadContact();

            new LeadContactPage(app)
               .GoToLeadDetails();
        }
    }
}


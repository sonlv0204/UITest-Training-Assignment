using System;
using NUnit.Framework;
using Xamarin.UITest;

namespace XamarinCRM
{
    public class CustomerTests : BaseTest
    {
        public CustomerTests()
        {
        }

        [Test]
        public void CheckCustomerDetails()
        {
            app.Repl();
        }
    }
}


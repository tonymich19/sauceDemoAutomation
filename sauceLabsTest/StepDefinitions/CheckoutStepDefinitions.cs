using NUnit.Framework;
using sauceDemoTest.PageObjects;


namespace sauceDemoTest.StepDefinitions
{
    [Binding]
    public class CheckoutStepDefinitions
    {
        private readonly BasePageObject _loginPageObject;
        private readonly CheckoutPageObject _checkoutPageObject;

        public CheckoutStepDefinitions(BasePageObject loginPageObject, CheckoutPageObject checkoutPageObject)
        {
            _loginPageObject = loginPageObject;
            _checkoutPageObject = checkoutPageObject;
        }

        [Given(@"I proceed to the checkout")]
        public void GivenIProceedToTheCheckout()
        {
            _checkoutPageObject.clickShoppingCartLink();
            _checkoutPageObject.clickCheckoutButton();
        }

        [Given(@"I enter my details")]
        public void GivenIEnterTheFollowingDetails()
        {
            _checkoutPageObject.enterFirstName("John");
            _checkoutPageObject.enterLastName("Doe");
            _checkoutPageObject.enterZipCode("12345");
        }

        [When(@"I finish the checkout")]
        public void WhenIFinishTheCheckout()
        {
            _checkoutPageObject.clickContinueButton();
            _checkoutPageObject.clickFinishButton();
        }

        // This step definition is used to verify that the order is complete
        // by checking the URL of the page
        // and asserting that it matches the expected URL
        // The element on the page is asserted in the Page Object
        [Then(@"the order should be complete")]
        public void ThenTheOrderShouldBeComplete()
        {
            _checkoutPageObject.confirmOrderIsComplete();
            string expectedUrl = "https://www.saucedemo.com/checkout-complete.html";
            string actualUrl = _loginPageObject.currentUrl();

            Assert.AreEqual(expectedUrl, actualUrl, "The page URL does not match the expected URL.");
        }
    }
}

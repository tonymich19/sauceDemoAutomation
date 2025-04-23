using sauceDemoTest.PageObjects;

namespace sauceDemoTest.StepDefinitions
{
    [Binding]
    public class addToCartStepDefinitions
    {
        private readonly InventoryPageObject _productPageObject;
        private readonly BasePageObject _loginPageObject;

        public addToCartStepDefinitions(InventoryPageObject productPageObject, BasePageObject loginPageObject)
        {
            _productPageObject = productPageObject;
            _loginPageObject = loginPageObject;
        }

        [Given(@"I add (.*) to the cart")]
        [When(@"I add (.*) to the cart")]
        public void WhenIAddItemToTheCart(String item)
        {
            _productPageObject.clickAddToCartButton(item);
        }

        // This step definition is used to verify that the item was added to the cart
        // Assertion is on the product page object
        [Then(@"the cart is updated with the (.*)")]
        public void ThenTheCartIsUpdatedWithTheItem(String item)
        {
            _productPageObject.confirmItemCanBeRemoved(item);
        }

        // After the scenario, the cart is reset
        [AfterScenario("cart")]
        public void AfterFeature()
        {
            _loginPageObject.clickSelectSideBar();
            _loginPageObject.resetAppState();
        }
    }
}

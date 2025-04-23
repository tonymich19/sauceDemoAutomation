using sauceDemoTest.PageObjects;

namespace sauceDemoTest.StepDefinitions
{
    [Binding]
    public class ProductListStepDefinitions
    {
        private readonly BasePageObject _loginPageObject;
        private readonly InventoryPageObject _productPageObject;

        public ProductListStepDefinitions(BasePageObject loginPageObject, InventoryPageObject productPageObject)
        {
            _loginPageObject = loginPageObject;
            _productPageObject = productPageObject;
        }

        // Product list steps
        // The firsy step is to log in, this step is reused in other scenarios
        // I am asserting that the product list contains the products I expect
        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            _loginPageObject.GoToLoginPage();
            _loginPageObject.enterCredentials("standard_user", "secret_sauce");
            _loginPageObject.clickLoginButton();
        }

        [Then(@"the product list should contain the following products")]
        public void ThenTheProductListShouldContainTheFollowingProducts(Table table)
        {
            foreach (var row in table.Rows)
            {
                _productPageObject.inventoryContains(row["Product Name"]);
            }
        }
    }
}

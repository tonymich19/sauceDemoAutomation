using sauceDemoTest.PageObjects;
using sauceDemoTest.Drivers;
using NUnit.Framework;

namespace sauceDemoTest.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly BasePageObject _loginPageObject;
        private const string _username = "standard_user";
        private const string _password = "secret_sauce";

        //constructor for the login step definitions page and creates a new instance of the login page object
        public LoginStepDefinitions(Browser browser)
        {
            _loginPageObject = new BasePageObject(browser);
        }

        // Step definitions for the login page
        // I am asserting the page title, entering valid and invalid credentials, clicking the login button, and asserting the error message
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            _loginPageObject.GoToLoginPage();
            string expectedTitle = "Swag Labs";
            string actualTitle = _loginPageObject.returnTitle();

            Assert.AreEqual(expectedTitle, actualTitle, "The page title does not match the expected title.");
        }

        [When(@"I enter valid username and password")]
        public void WhenIEnterValidUsernameAndPassword()
        {
            _loginPageObject.enterCredentials(_username, _password);
        }

        [When(@"I enter invalid username and password")]
        public void WhenIEnterInvalidUsernameAndPassword()
        {
            _loginPageObject.enterCredentials("invalid_user", "invalid_password");
        }

        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            _loginPageObject.clickLoginButton();
        }

        [Then(@"Error message should contain (.*)")]
        public void ThenErrorMessageShouldContain(string errorMessage)
        {
            string expectedError = "Epic sadface: Username and password do not match any user in this service";
            string actualError = _loginPageObject.returnErrorMessage();

            Assert.AreEqual(expectedError, expectedError, "The page Error does match.");

        }

        [Then(@"I am on the Inventory page")]
        [Given(@"I am on the Inventory page")]
        public void ThenIAmOntheInventoryPage()
        {
            string expectedUrl = "https://www.saucedemo.com/inventory.html";
            string actualUrl = _loginPageObject.currentUrl();

            Assert.AreEqual(expectedUrl, actualUrl, "The page URL does not match the expected URL.");
        }


    }
}

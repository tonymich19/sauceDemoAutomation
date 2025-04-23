using NUnit.Framework;
using sauceDemoTest.PageObjects;

namespace sauceDemoTest.StepDefinitions
{
    [Binding]
    public class LogoutStepDefinitions
    {
        private readonly BasePageObject _loginPageObject;

        public LogoutStepDefinitions(BasePageObject loginPageObject)
        {
            _loginPageObject = loginPageObject;
        }

        // Logout steps
        // I am asserting that the user is logged out by checking the URL of the page
        [When(@"I click the logout button")]
        public void WhenIClickTheLogoutButton()
        {
            _loginPageObject.clickSelectSideBar();
            _loginPageObject.confirmLogout();
        }

        [Then(@"I should be logged out")]
        public void ThenIShouldBeLoggedOut()
        {
            string expectedUrl = "https://www.saucedemo.com/";
            string actualUrl = _loginPageObject.currentUrl();

            Assert.AreEqual(expectedUrl, actualUrl, "The page URL does not match the expected URL.");
        }
    }
}

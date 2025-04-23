using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using sauceDemoTest.Drivers;

namespace sauceDemoTest.PageObjects
{
    public class BasePageObject
    {
        private const string _url = "https://www.saucedemo.com/";
       
        private readonly Browser _browser;

        //constructor for the page object
        public BasePageObject(Browser browser)
        {
            _browser = browser;
        }

        //navigates to the login page
        public void GoToLoginPage()
        {
            _browser.Driver.Navigate().GoToUrl(_url);
        }

        //enters the username and password
        public void enterCredentials(string username, string password)
        {
            _browser.Driver.FindElement(By.Id("user-name")).SendKeys(username);
            _browser.Driver.FindElement(By.Id("password")).SendKeys(password);
            
        }

        //clicks the login button
        public void clickLoginButton()
        {
            _browser.Driver.FindElement(By.Id("login-button")).Click();
        }

        //selects the sidebar
        public void clickSelectSideBar() 
        {
            _browser.Driver.FindElement(By.Id("react-burger-menu-btn")).Click();
        }

        //waits for logout to be displayed and then clicks it
        public void confirmLogout() {           
            IWebElement revealed = _browser.Driver.FindElement(By.CssSelector("[data-test=\"logout-sidebar-link\"]"));
            WebDriverWait wait = new WebDriverWait(_browser.Driver, TimeSpan.FromSeconds(2));
            wait.Until(d => revealed.Displayed);
            revealed.Click();
        }

        //returns the title of the page
        public string returnTitle() {

            string title = _browser.Driver.Title;
            return title;
        }

        //returns the error message
        public string returnErrorMessage() {
            return _browser.Driver.FindElement(By.CssSelector("[data-test='error']")).Text;
        }

        //returns the current URL
        public string currentUrl() {
            return _browser.Driver.Url;
        }

        //resets the app state
        public void resetAppState() 
        {
            IWebElement revealed = _browser.Driver.FindElement(By.CssSelector("[data-test=\"reset-sidebar-link\"]"));
            WebDriverWait wait = new WebDriverWait(_browser.Driver, TimeSpan.FromSeconds(2));
            wait.Until(d => revealed.Displayed);
            revealed.Click();
        }
    }
}

using sauceDemoTest.Drivers;
using OpenQA.Selenium;
using NUnit.Framework;

namespace sauceDemoTest.PageObjects
{
    public class CheckoutPageObject : BasePageObject
    {
        private readonly Browser _browser;

        public CheckoutPageObject(Browser browser) : base(browser)
        {
            _browser = browser;
        }

        //find shopping cart link and click
        public void clickShoppingCartLink()
        {
            _browser.Driver.FindElement(By.CssSelector("[data-test='shopping-cart-link']")).Click();
        }

        //find checkout button and click
        public void clickCheckoutButton()
        {
            _browser.Driver.FindElement(By.CssSelector("[data-test='checkout']")).Click();
        }

        //find first name field and enter first name
        public void enterFirstName(string firstName)
        {
            _browser.Driver.FindElement(By.CssSelector("[data-test='firstName']")).SendKeys(firstName);
        }

        //find last name field and enter last name
        public void enterLastName(string lastName) 
        {
            _browser.Driver.FindElement(By.CssSelector("[data-test='lastName']")).SendKeys(lastName);
        }

        //find zip code field and enter zip code
        public void enterZipCode(string zipCode)
        {
            _browser.Driver.FindElement(By.CssSelector("[data-test='postalCode']")).SendKeys(zipCode);
        }

        //find continue button and click
        public void clickContinueButton()
        {
            _browser.Driver.FindElement(By.CssSelector("[data-test='continue']")).Click();
        }

        //find finish button and click
        public void clickFinishButton()
        {
            _browser.Driver.FindElement(By.CssSelector("[data-test='finish']")).Click();
        }

        //confirm order is complete
        public void confirmOrderIsComplete()
        {
            var element = _browser.Driver.FindElement(By.CssSelector("[data-test='complete-header']"));
            Assert.IsTrue(element.Displayed);
        }
    }
}

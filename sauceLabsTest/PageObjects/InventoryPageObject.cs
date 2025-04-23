using sauceDemoTest.Drivers;
using OpenQA.Selenium;
using NUnit.Framework;

namespace sauceDemoTest.PageObjects
{
    public class InventoryPageObject : BasePageObject
    {
        private readonly Browser _browser;

        public InventoryPageObject(Browser browser) : base(browser)
        {
            _browser = browser;
        }

        //find item add to cart button and click
        public void clickAddToCartButton(String item)
        {
            _browser.Driver.FindElement(By.CssSelector($"[data-test='add-to-cart-{item}']")).Click();
        }

        //find item remove from cart button and click
        public void clickRemoveFromCartButton(String item)
        {
            _browser.Driver.FindElement(By.CssSelector($"[data-test='remove-{item}']")).Click();
        }

        //find cart button and click
        public void clickCartButton()
        {
            _browser.Driver.FindElement(By.CssSelector("[data-test='shopping-cart']")).Click();
        }

        //find inventory item and click
        public void inventoryContains(String item)
        {
            var element = _browser.Driver.FindElement(By.XPath($"//*[contains(@id,'{item}')]"));
            Assert.IsTrue(element.Displayed);
        }

        //confirm item can be removed
        public void confirmItemCanBeRemoved(String item)
        {
            var element = _browser.Driver.FindElement(By.CssSelector($"[data-test='remove-{item}']"));
            Assert.IsTrue(element.Displayed);
        }


    }
}

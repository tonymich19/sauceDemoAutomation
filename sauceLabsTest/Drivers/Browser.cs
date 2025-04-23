using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace sauceDemoTest.Drivers
{
    public class Browser : IDisposable 
    {
        //instantiates a new instance of the lazy webdriver to be used for all the tests
        private readonly Lazy<IWebDriver> _driverLazy;
        private bool _disposed;

        public Browser()
        {
            _driverLazy = new Lazy<IWebDriver>(WebDriver);
        }

        public IWebDriver Driver => _driverLazy.Value;

        //creates a new instance of the chrome driver
        private IWebDriver WebDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--guest");
            options.AddArgument("--incognito");
            return new ChromeDriver(options);
        }

        //disposes of the driver
        public void Dispose()
        {
            if (_disposed) return;
            if (_driverLazy.IsValueCreated)
            {
                Driver.Quit();
            }
            _disposed = true;
        }

    }
    
}

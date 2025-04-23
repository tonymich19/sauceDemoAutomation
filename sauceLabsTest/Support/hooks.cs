using BoDi;
using sauceDemoTest.Drivers;
using sauceDemoTest.PageObjects;

namespace sauceDemoTest.Support
{
    [Binding]
    public class hooks
    {
        
        [BeforeTestRun]
        //instantiates the browser before the test run
        public static void BeforeTestRun(ObjectContainer testThreadContainer)
        {
            testThreadContainer.BaseContainer.Resolve<Browser>();
        }

    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationBrowser
{
    [SetUpFixture]
    public class WebDriverFactory : IDisposable
    {
        public static IWebDriver Driver { get; private set; }

        [OneTimeSetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless=new");

            Driver = new ChromeDriver(options);
        }

        [OneTimeTearDown]
        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
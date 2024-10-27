using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace AutomationBrowser.UserTest
{
    [TestFixture]
    public class UserValidationRegister
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetupTest()
        {
            _driver = WebDriverFactory.Driver;
            _driver.Navigate().GoToUrl("https://demo.automationtesting.in");
        }

        [Test]
        public void RegisterUserSuccess()
        {

            string gender = "Male";
            string country = "India";
            string phone = "1111111111";
            string address = "Rua tal";
            string lastName = "Pai de Familia";
            string firstName = "Filho de Familia";
            string mail = "dat@gmail.com";

            _driver.FindElement(By.Id("enterimg")).Click();
            _driver.FindElement(By.XPath("//input[@placeholder='First Name']")).SendKeys(firstName);
            _driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).SendKeys(lastName);
            _driver.FindElement(By.XPath("//textarea[@ng-model='Adress']")).SendKeys(address);
            _driver.FindElement(By.XPath("//input[@type='email']")).SendKeys(mail);
            _driver.FindElement(By.XPath("//input[@type='tel']")).SendKeys(phone);
            _driver.FindElement(By.XPath($"//input[@value='{gender}']")).Click();
            _driver.FindElement(By.XPath("//span[@aria-labelledby='select2-country-container']")).Click();
            _driver.FindElement(By.XPath($"//li[contains(text(), '{country}')]")).Click();

            //Somente para Testes
            Assert.DoesNotThrow(() => _driver.FindElement(By.Id("enterimg")));
        }

        [TearDown]
        public void TeadDownTest()
        {
  
        }
    }
}

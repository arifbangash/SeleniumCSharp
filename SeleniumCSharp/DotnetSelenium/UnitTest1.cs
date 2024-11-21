using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotnetSelenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            var options = new ChromeOptions();

            options.AddUserProfilePreference("profile.default_content_setting_values.cookies", 2);
            options.AddUserProfilePreference("profile.cookie_controls_mode", 1);
            options.AddExcludedArgument("enable-automation");
            options.AddAdditionalOption("useAutomationExtension", false);

            IWebDriver _driver = new ChromeDriver(options);
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.google.com");

            IWebElement _element = _driver.FindElement(By.Name("q"));
            _element.SendKeys("Selenium");
            _element.SendKeys(Keys.Enter);
            _driver.Close();
        }

        [Test]
        public void EAWebsiteTest()
        {
            var options = new ChromeOptions();

            options.AddUserProfilePreference("profile.default_content_setting_values.cookies", 2);
            options.AddUserProfilePreference("profile.cookie_controls_mode", 1);
            options.AddExcludedArgument("enable-automation");
            options.AddAdditionalOption("useAutomationExtension", false);

            IWebDriver _driver = new ChromeDriver(options);
            _driver.Manage().Window.Maximize();

            _driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            var loginLink = _driver.FindElement(By.LinkText("Login"));

            loginLink.Click();
        }
    }
}
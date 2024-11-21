using OpenQA.Selenium;

namespace DotnetSelenium.Utilities
{
    public class SharedUtilities
    {
        public void ClickOnElement(IWebElement element)
        {
            element.Click();
        }

        public void EnterTextInTextBox(IWebElement element, string text)
        {
            element.SendKeys(text);
        }
    }
}

using OpenQA.Selenium;

namespace GenericAutoFramework.Base
{
    public class Browser
    {
        private readonly IWebDriver _driver;
        public Browser(IWebDriver driver)
        {
            _driver = driver;
        }

        public BrowserType Type { get; set; }

        public void GoToUrl(string url)
        {
            DriverContext.Driver.Url = url;
        }
    }
    /// <summary>
    /// BrowserType declaration
    /// </summary>
    public enum BrowserType
    {
        InternetExplorer,
        FireFox,
        Chrome

    }
}

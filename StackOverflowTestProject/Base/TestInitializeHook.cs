using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using StackOverflowAutoFramework.Config;
using StackOverflowAutoFramework.Helpers;

namespace StackOverflowAutoFramework.Base
{
   public abstract class TestInitializeHook : Base
    {
        public readonly BrowserType Browser;

        public TestInitializeHook(BrowserType browser)
        {
            Browser = browser;
        }

        public void InitializeSettings()
        {
            //Set all the settings for the framework
            ConfigReader.SetFrameworkSettings();

            //Set Log helpers

            LogHelpers.CreateLogFile();

            //Open Browser

            OpenBrowser(Browser);

            LogHelpers.WriteLog("Initialized framework !!!");

        }

        private void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;

            }
        }

        public virtual void LaunchSite()
        {
            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Browser.GoToUrl(Settings.stackOverflowUrl);
            
            LogHelpers.WriteLog("Opened the browser !!!");
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using GenericAutoFramework.Base;
using System.Threading;

namespace StackOverflowTest.Pages
{
    class HomePage : BasePage
    {
        /// <summary>
        /// Object for the HomePage
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = ".left-sidebar-toggle > .ps-relative")]
        public IWebElement lnkMenu { get; set; }
        public void ClickNavigation()
        {
            Thread.Sleep(3000);
            lnkMenu.Click();
           
        }

    }
}

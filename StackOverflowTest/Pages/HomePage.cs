using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using StackOverflowAutoFramework.Base;

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
           lnkMenu.Click();
           
        }

    }
}

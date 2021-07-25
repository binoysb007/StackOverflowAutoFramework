using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using GenericAutoFramework.Base;
using System.Threading;

namespace StackOverflowTest.Pages
{
    class TagSearchPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#nav-tags .flex--item")]
        public IWebElement navTag { get; set; }

        [FindsBy(How = How.Id, Using = "tagfilter")]
        public IWebElement txtSearchTag { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/div/div[3]/div[1]/div[1]/div[1]/div/a")]
        public IWebElement lnkbtnCSharp { get; set; }


        public void SearchText(string searchText)
        {
            navTag.Click();
            Thread.Sleep(1000);
            txtSearchTag.SendKeys(searchText);
        }

        public void ClickCSharp()
        {
            Thread.Sleep(1000);
            lnkbtnCSharp.Click();

        }
    }
}

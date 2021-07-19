using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using StackOverflowAutoFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StackOverflowTest.Pages
{
    class TagSearchPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#nav-tags .flex--item")]
        public IWebElement navTag { get; set; }

        [FindsBy(How = How.Id, Using = "tagfilter")]
        public IWebElement txtSearchTag { get; set; }

        [FindsBy(How = How.LinkText, Using = "c#")]
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

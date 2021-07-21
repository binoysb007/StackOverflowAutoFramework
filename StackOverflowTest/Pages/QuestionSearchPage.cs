using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using StackOverflowAutoFramework.Base;
using System.Threading;

namespace StackOverflowTest.Pages
{
    class QuestionSearchPage :BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#nav-questions > .-link--channel-name")]
        public IWebElement navQuestion { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".s-btn__icon")]
        public IWebElement btnFilter { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/div[1]/div[2]/form/div/div/div[1]/div/div[1]/fieldset/div[2]/div/div/input")]
        public IWebElement chkFilterBy { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/div[1]/div[2]/form/div/div/div[1]/div/div[2]/fieldset/div[2]/div/div/input")]
        public IWebElement rdbtnSortBy { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".js-tageditor-replacing")]
        public IWebElement selectSearchTextbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".js-tageditor-replacing")]
        public IWebElement txtSearchTag { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".d-flex > .s-btn")]
        public IWebElement btnApplyFilter { get; set; }

     

        public void ClickFilter()
        {
            navQuestion.Click();
            btnFilter.Click();
            chkFilterBy.Click();
            rdbtnSortBy.Click();
            selectSearchTextbox.Click();
        }

        public void SearchText(string searchText)
        {
            txtSearchTag.SendKeys(searchText);
        }

        public void ApplyFilter()
        {
            Thread.Sleep(1000);
            btnApplyFilter.Submit();

        }

    }
}

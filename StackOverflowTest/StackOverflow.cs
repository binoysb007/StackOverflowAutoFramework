using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using StackOverflowAutoFramework.Base;
using StackOverflowAutoFramework.Helpers;
using StackOverflowTest.Pages;

namespace StackOverflowTest
{
    [TestClass]
    public class StackOverflow : HookInitialize
    {
        /// <summary>
        /// Test method for navigate to Question menu and apply "Javascript" filter
        /// </summary>
        [TestMethod, Category(Constants.functionalTesting)]
        public void TestMethodQuestion()
        {
            try
            {
                Navigation();
                LogHelpers.WriteLog(Constants.initialMessage);
                Filter();
                NUnit.Framework.Assert.AreEqual(DriverContext.Driver.Title, Constants.expectedQuestionTitle);
                DriverContext.Driver.Quit();
                LogHelpers.WriteLog(Constants.finalMessage);
            }
            catch (Exception e)
            {
               NUnit.Framework.Assert.Fail(Constants.testFailed);
               Console.WriteLine(e.StackTrace);
            }

            finally
            {
                if(DriverContext.Driver!=null)
                {
                   DriverContext.Driver.Quit();
                }
            }
            
        }
        /// <summary>
        ///  Test method for navigate to Tag menu and apply "C#" filter
        /// </summary>
        [TestMethod,Category(Constants.functionalTesting)]
        public void TestMethodTag()
        {
            try
            {
                Navigation();
                LogHelpers.WriteLog(Constants.initialMessage);
                TagName();
                NUnit.Framework.Assert.AreEqual(DriverContext.Driver.Title, Constants.expectedTagTitle);
                DriverContext.Driver.Quit();
                LogHelpers.WriteLog(Constants.finalMessage);
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(Constants.testFailed);
                Console.WriteLine(e.StackTrace);
            }

            finally
            {
                if (DriverContext.Driver != null)
                {
                    DriverContext.Driver.Quit();
                }
            } 
        }
        /// <summary>
        /// Page Navigation method 
        /// </summary>
        public void Navigation()
        {
            HomePage page = new HomePage();
            page.ClickNavigation();
        }

        /// <summary>
        /// Filter field selection
        /// </summary>
        public void Filter()
        {
            QuestionSearchPage questionpage = new QuestionSearchPage();
            questionpage.ClickFilter();
            LogHelpers.WriteLog(Constants.filterClicked);
            questionpage.SearchText(Constants.searchText);
            LogHelpers.WriteLog(Constants.filterTextInserted);
            questionpage.ApplyFilter();
            LogHelpers.WriteLog(Constants.applyFilter);
            
        }

        /// <summary>
        /// Tag search field entry.
        /// </summary>
        public void TagName()
        {
            TagSearchPage tagpage = new TagSearchPage();
            tagpage.SearchText(Constants.tagSearchText);
            LogHelpers.WriteLog(Constants.filterTextInserted);
            tagpage.ClickCSharp();
            LogHelpers.WriteLog(Constants.linkClicked);
        }

    }
}

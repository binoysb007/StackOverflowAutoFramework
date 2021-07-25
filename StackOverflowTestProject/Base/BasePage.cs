using OpenQA.Selenium.Support.PageObjects;
namespace GenericAutoFramework.Base
{
    public abstract class BasePage :Base
    {
        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }

      
    }
}

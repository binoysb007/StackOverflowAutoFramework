
using StackOverflowAutoFramework.Base;
using TechTalk.SpecFlow;
namespace StackOverflowTest
{
    [Binding]
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize() :base(BrowserType.Chrome)
        {
            InitializeSettings();
            NaviateSite();
        }
    }
}

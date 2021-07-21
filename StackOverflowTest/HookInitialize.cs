
using StackOverflowAutoFramework.Base;
namespace StackOverflowTest
{
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize() :base(BrowserType.Chrome)
        {
            InitializeSettings();
            NaviateSite();
        }
    }
}

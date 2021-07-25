using GenericAutoFramework.Base;
namespace StackOverflowTest
{
    public class HookInitialize : TestInitializeHook
    {
        public HookInitialize() :base(BrowserType.Chrome)
        {
            InitializeSettings();
            LaunchSite();
        }
    }
}

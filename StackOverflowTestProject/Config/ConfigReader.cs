using System;
using System.Xml.XPath;
using System.IO;


namespace GenericAutoFramework.Config
{
   public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            XPathItem stackOverflowUrl;
            XPathItem testType;
            XPathItem isLog;
            XPathItem isReport;
            XPathItem buildName;
            XPathItem logPath;

            string strFilename = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            FileStream stream = new FileStream(strFilename, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            //Get XML Details and pass it in XPathItem type variables
            stackOverflowUrl = navigator.SelectSingleNode("GenericAutoFramework/RunSettings/stackOverflowUrl");
            buildName = navigator.SelectSingleNode("GenericAutoFramework/RunSettings/buildName");
            testType = navigator.SelectSingleNode("GenericAutoFramework/RunSettings/testType");
            isLog = navigator.SelectSingleNode("GenericAutoFramework/RunSettings/isLog");
            isReport = navigator.SelectSingleNode("GenericAutoFramework/RunSettings/isReport");
            logPath = navigator.SelectSingleNode("GenericAutoFramework/RunSettings/logPath");

            //Set XML Details in the property to be used accross framework
            Settings.stackOverflowUrl = stackOverflowUrl.Value.ToString();
            Settings.buildName = buildName.Value.ToString();
            Settings.testType = testType.Value.ToString();
            Settings.isLog = isLog.Value.ToString();
            Settings.isReporting = isReport.Value.ToString();
            Settings.logPath = logPath.Value.ToString();
        }
    }
}

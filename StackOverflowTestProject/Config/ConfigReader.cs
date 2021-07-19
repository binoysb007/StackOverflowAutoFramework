using System;
using System.Xml.XPath;
using System.IO;


namespace StackOverflowAutoFramework.Config
{
   public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {
            XPathItem sit;
            XPathItem testtype;
            XPathItem islog;
            XPathItem isreport;
            XPathItem buildname;
            XPathItem logPath;

            string strFilename = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            FileStream stream = new FileStream(strFilename, FileMode.Open);
            XPathDocument document = new XPathDocument(stream);
            XPathNavigator navigator = document.CreateNavigator();

            //Get XML Details and pass it in XPathItem type variables
            sit = navigator.SelectSingleNode("StackOverflowAutoFramework/RunSettings/SIT");
            buildname = navigator.SelectSingleNode("StackOverflowAutoFramework/RunSettings/BuildName");
            testtype = navigator.SelectSingleNode("StackOverflowAutoFramework/RunSettings/TestType");
            islog = navigator.SelectSingleNode("StackOverflowAutoFramework/RunSettings/IsLog");
            isreport = navigator.SelectSingleNode("StackOverflowAutoFramework/RunSettings/IsReport");
            logPath = navigator.SelectSingleNode("StackOverflowAutoFramework/RunSettings/LogPath");

            //Set XML Details in the property to be used accross framework
            Settings.SIT = sit.Value.ToString();
            Settings.BuildName = buildname.Value.ToString();
            Settings.TestType = testtype.Value.ToString();
            Settings.IsLog = islog.Value.ToString();
            Settings.IsReporting = isreport.Value.ToString();
            Settings.LogPath = logPath.Value.ToString();
        }
    }
}

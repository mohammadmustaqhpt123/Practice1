using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace AsianPaint
{
    public class ConfigClass : Property
    {

        public static IWebDriver driver;
        public static string chromeDriverPath = @"C:\Users\mohammad mustaq\source\repos\AsianPaint\AsianPaint\Drivers\";
		
		
        public static string url = "https://www.asianpaints.com/";

        public static string filePath = @"C:\Users\mohammad mustaq\source\repos\AsianPaint\AsianPaint\screenshot\";

        public static string report = @"C:\Users\mohammad mustaq\source\repos\AsianPaint\AsianPaint\report\";

        public static int PAGE_LOAD_TIMEOUT = 10;
        public static int IMPLICIT_WAIT = 10;

        public static Actions action;
        public static ChromeOptions notification;

        public static AventStack.ExtentReports.ExtentReports extent;
        public static AventStack.ExtentReports.ExtentTest logger;
        public static ExtentHtmlReporter htmlReport;

    }
}

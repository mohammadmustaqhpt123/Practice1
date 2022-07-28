
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AsianPaint
{
    

    [Binding]
    public class InteriorTexturesStepDefinitions : UtilityClass
    {
        public FindAContractorPage fc;
        public HomePage hp;
        

        //[OneTimeSetUp]
        //public void OneTimeSetUP()
        //{
        //    ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(report);

        //    extent = new AventStack.ExtentReports.ExtentReports();

        //    extent.AttachReporter(htmlReport);
        //}

        [BeforeScenario]
        public void BeforeScenario()
        {
            htmlReport = new ExtentHtmlReporter(report);

            extent = new AventStack.ExtentReports.ExtentReports();

             extent.AttachReporter(htmlReport);
            logger = extent.CreateTest("Given").Info("Test started");
            Console.WriteLine("start");
            DisableNotification();
            LaunchBrowser(notification);
            LaunchApp(url);
           logger.Log(Status.Info, "App is Lanched");
            BrowserMaximize();
            ImplicitWait();
            Thread.Sleep(1000);

        }

        public void ObjectMethod()
        {
            fc = new FindAContractorPage(driver);
            hp = new HomePage(driver);
            
        }


        //-------------------------------------------------------------------------------




        [Given(@"Launch the browser and Application")]
        public void GivenLaunchTheBrowserAndApplication()
        {
           
            ObjectMethod();
            string expectedResult = "Trusted Wall Painting, Home Painting & Waterproofing in India - Asian Paints";
            string actualResult = ValidatePageTitle();
            try
            {
                Assert.That(expectedResult, Is.EqualTo(actualResult));
                Console.WriteLine(actualResult);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                logger.Log(Status.Fail, "Application not Lanched");
                throw new Exception();
            }
        }

        [When(@"User mouse hover on ""([^""]*)""")]
        public void WhenUserMouseHoverOn(string hover)
        {

            ObjectMethod();
            Thread.Sleep(3000);
            IWebElement element = hp.GetHomePageElement(hover);
            Hover(element);
            //logger.Log(Status.Info, "Mouse is Hovered");
            Thread.Sleep(2000);
        }

        [When(@"User click on ""([^""]*)""")]
        public void WhenUserClickOn(string elementName)
        {
            ObjectMethod();
            Thread.Sleep(2000);
            hp.ClickHomePageElement(elementName);
            //logger.Log(Status.Info, "clicked on " + elementName);
        }

        [Then(@"User Verify the title of ""([^""]*)"" page and Take screenshot")]
        public void ThenUserVerifyTheTitleOfPageAndTakeScreenshot(string pageName)
        {
            ObjectMethod();
            string expectedResult = ExpectedTitle(pageName);
            string actualResult = ValidatePageTitle();
            Assert.That(expectedResult, Is.EqualTo(actualResult));
            Console.WriteLine(actualResult);
            try
            {
                Assert.That(expectedResult, Is.EqualTo(actualResult));
                Console.WriteLine(actualResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                //logger.Log(Status.Fail, "Test is Failed");
                throw new Exception();
            }
            CaptureScreenshot();
        }



        [AfterScenario]
        public void AfterScenario()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            CloseBrowser();
            extent.Flush();
        }



    }




}

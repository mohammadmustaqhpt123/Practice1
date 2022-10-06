
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AsianPaint
{
    

    [Binding]
    public class InteriorTexturesStepDefinitions : ApplicationHooks
    {

        
        /// <summary>
        /// here we are Lanching the browser, Application, Maximizing browser and applianing implicit wait 
        /// This is the pre launcing  condition
        /// </summary>
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
            ClickHomePageButton("I understand");


        }
        /// <summary>
        /// Hooks is Launching mutiple browser so We give alternate way
        /// </summary>
        public void ObjectMethod()
        {
            fc = new FindAContractorPage(driver);
            hp = new HomePage(driver);
            
        }


        //-------------------------------------------------------------------------------
        /// <summary>
        /// Here we are validating browser is launched or not and application is Launched or not 
        /// </summary>
        /// <exception cref="Exception">if Assertion is fail it will Throw the exception And We are handling And after
        /// calling the exception for Report</exception>

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



        /// <summary>
        /// This is mouse hovering action
        /// </summary>
        /// <param name="hover"></param>
        [When(@"User mouse hover on ""([^""]*)""")]
        public void WhenUserMouseHoverOn(string hover)
        {

            ObjectMethod();
            Thread.Sleep(2000);
            IWebElement element = hp.GetHomePageElement(hover);
            Hover(element);
            logger.Log(Status.Info, "Mouse is Hovered");
            Thread.Sleep(1000);
        }


        /// <summary>
        ///  here we are forforming 
        /// </summary>
        /// <param name="elementName"> passing the name of element after it will click</param>
        [When(@"User click on ""([^""]*)""")]
        public void WhenUserClickOn(string elementName)
        {
            ObjectMethod();
            Thread.Sleep(2000);
            hp.ClickHomePageElement(elementName);
            logger.Log(Status.Info, "clicked on " + elementName);
        }



        /// <summary>
        /// validating the test and taking screen shot of page
        /// </summary>
        /// <param name="pageName">this is element name</param>
        /// <exception cref="Exception">for Report We Are calling exception</exception>
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
                Assert.That(actualResult, Is.EqualTo(expectedResult));
                Console.WriteLine(actualResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                logger.Log(Status.Fail, "Test is Failed");
                throw new Exception();
            }
            CaptureScreenshot(pageName);
        }


        /// <summary>
        /// This is post condion of scenarios
        /// </summary>
        [AfterScenario]
        public void AfterScenario()
        {
            ObjectMethod();
            Thread.Sleep(1000);
            CloseBrowser();
            extent.Flush();

        }

        


    }




}

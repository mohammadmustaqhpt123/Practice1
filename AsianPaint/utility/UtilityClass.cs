using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace AsianPaint
{
    public class UtilityClass : ConfigClass
    {

        public void LaunchBrowser(string browser)
        {
            switch (browser)
            {

                case "CHROME":
                    driver = new ChromeDriver();
                    break;



                default: throw new ArgumentException("Error");



            }
        }

        public void LaunchBrowser(ChromeOptions notification)
        {
            driver = new ChromeDriver(notification);

        }

        public void BrowserMaximize()
        {
            driver.Manage().Window.Maximize();
        }

        public void PageLoad()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(PAGE_LOAD_TIMEOUT);
        }

        public void ImplicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(IMPLICIT_WAIT);
        }

        public void LaunchApp(string url)
        {
            driver.Url = url;
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }

        public string ValidatePageTitle()
        {
            return driver.Title;
        }

        public void CaptureScreenshot()
        {

            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;

            Screenshot screenshot = screenshotDriver.GetScreenshot();

            screenshot.SaveAsFile(filePath + "/screenshot.png", ScreenshotImageFormat.Png);


        }


        public void Hover(IWebElement element)
        {
            action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }


        public Dictionary<string, string> ToDictionary(Table table)
        {
            var dictionary = new Dictionary<string, string>();

            foreach(var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }

            return dictionary;
        }

        public void DisableNotification()
        {
            notification = new ChromeOptions();
            notification.AddArguments("--disable-notifications");

        }



        public string ExpectedTitle(string title)
        {
            Dictionary<string, string> titles = new Dictionary<string, string>();
            titles.Add("2200 Colours", colours2200);
            titles.Add("Wall Paints", wallPaints);
            titles.Add("Terrace & Tanks", terraceAndTanks);
            titles.Add("Wood Paints", woodPaints);
            titles.Add("Interior Textures", interiorTextures);
            titles.Add("Wall Textures", wallTextures);
            titles.Add("Textured Finishes", texturedFinishes);
            titles.Add("Bathrooms", bathrooms);
            titles.Add("Metal Paints", metalPaints);
            titles.Add("Exterior Textures", exteriorTextures);
            titles.Add("Kid's World", kidWorld);
            titles.Add("Tile Guard", tileGuard);
            titles.Add("Interiors", interiors);
            titles.Add("Paint Budget Calculator", paintBudgetCalculator);
            titles.Add("Stencils", stencils);
            titles.Add("Floor Guard", floorGuard);
            titles.Add("View All", viewAll);
            titles.Add("Find a Contractor", findAContractor);
            
            return titles[title];
        }



        







    }
}

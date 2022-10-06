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


        /// <summary>
        /// Here we are taking screenshot and storing in sreenshot folder
        /// </summary>
        /// <param name="screenName">this for file name</param>
        public void CaptureScreenshot(string screenName)
        {

            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;

            Screenshot screenshot = screenshotDriver.GetScreenshot();

            screenshot.SaveAsFile(filePath + "/"+ screenName  + ".png", ScreenshotImageFormat.Png);


        }

        /// <summary>
        /// mouse hovering action
        /// </summary>
        /// <param name="element">if we pass element and it will hover on this element </param>
        public void Hover(IWebElement element)
        {
            action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        /// <summary>
        ///  This method for convert table to dictionary
        /// </summary>
        /// <param name="table"></param>
        /// <returns>dictionary key=string and value = string</returns>
        public Dictionary<string, string> ToDictionary(Table table)
        {
            var dictionary = new Dictionary<string, string>();

            foreach(var row in table.Rows)
            {
                dictionary.Add(row[0], row[1]);
            }

            return dictionary;
        }

        /// <summary>
        /// notification disable
        /// </summary>
        public void DisableNotification()
        {
            notification = new ChromeOptions();
            notification.AddArguments("--disable-notifications");

        }


        /// <summary>
        /// creating dictionary object and storing all the page title
        /// </summary>
        /// <param name="title">passing page name as title</param>
        /// <returns>it will return page title</returns>
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
            titles.Add("Colours & Textures", coloursAndTextures);
            
            return titles[title];
        }


        public void ClickHomePageButton(string buttonName)
        {
            driver.FindElement(By.XPath("//button[text()='" + buttonName + "']")).Click();
        }







    }
}

using OpenQA.Selenium;
using System;


namespace AsianPaint
{
    public class InteriorTexturePage
    {
        private IWebDriver driver;

        public InteriorTexturePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string Title()
        {
            return driver.Title;
        }
    }
}

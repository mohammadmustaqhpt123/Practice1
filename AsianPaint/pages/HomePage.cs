using OpenQA.Selenium;
using System;


namespace AsianPaint
{
    public class HomePage
    {
       


        public IWebDriver driver;

        private By homePageElements = By.XPath("//span[normalize-space()='Waterproofing']");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickHomePageElement(string elementName)
        {
            
            if(elementName == "PAINTS & TEXTURES"  || elementName == "Stencils")
            {
                driver.FindElement(By.XPath("((//a[normalize-space()='" + elementName + "']))[2]")).Click();
                
                return;
            }
           
            driver.FindElement(By.XPath("(//a[normalize-space()='" + elementName + "'])[1]")).Click();
        }

        public IWebElement GetHomePageElement(string elementName)
        {
            if (elementName == "PAINTS & TEXTURES")
            {
                return driver.FindElement(By.XPath("(//span[normalize-space()='PAINTS & TEXTURES'])[2]"));

            }
            return driver.FindElement(By.XPath("//a[normalize-space()='" + elementName + "']"));
        }




































        private By findAContractor = By.XPath("//span[normalize-space()='Find a Contractor']/..");
        private By paintAndTextures = By.XPath("(//span[normalize-space()='PAINTS & TEXTURES']/..)[2]");

        private By paintBudgetCalculator = By.XPath("(//a[contains(text(),'Paint Budget Calculator')])[1]");
        private By interiorTexture = By.XPath("(//a[contains(text(),'Interior Textures')])[1]");
        private By exteriorTexture = By.XPath("//a[normalize-space()='Exterior Textures']");
        private By kidsWorld = By.XPath("//a[@href='https://www.asianpaints.com/products/paints-and-textures/interior-walls/kids-world.html']");
        private By stencils = By.XPath("//a[contains(text(),'Stencils')]");
        private By colours = By.XPath("//a[normalize-space()='2200 Colours']");
        private By coloursAndTextures = By.XPath("//span[normalize-space()='Colours & Textures']/..");




        public string Title()
        {
            return driver.Title;
        }

        public void ClickOnFindAContractor()
        {
            driver.FindElement(findAContractor).Click();
        }

        public IWebElement PaintAndTextures()
        {
            return driver.FindElement(paintAndTextures);
        }

        public void ClickInteriorTexture()
        {
            driver.FindElement(interiorTexture).Click();
        }

        public void ClickExteriorTexture()
        {
            driver.FindElement(exteriorTexture).Click();
        }

        public void ClickKidsWorld()
        {
            driver.FindElement(kidsWorld).Click();
        }

        public void ClickStencils()
        {
            driver.FindElement(stencils).Click();
        }

        public void ClickColours()
        {
            driver.FindElement(colours).Click();
        }

        public void ClickColoursAndTextures()
        {
            driver.FindElement(coloursAndTextures).Click();
        }
        public void ClickPaintBudgetCalculator()
        {
            driver.FindElement(paintBudgetCalculator).Click();
        }





    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsianPaint
{
    internal class Class1
    {
        public static IWebDriver driver;
        public static void ClickElement(string elementName)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("(//span[normalize-space()='PAINTS & TEXTURES'])[2]"))).Perform();
            

        }

        public static void Main()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.asianpaints.com/";
            Thread.Sleep(10000);
            string elementName = "Find a Contractor";
            string textboxName = "Pincode/Area";
            string sendkeys = "583201";
            string buttonName = "SEARCH";
            driver.FindElement(By.XPath("//a[normalize-space()='" + elementName + "']")).Click();
            driver.FindElement(By.XPath("(//input[@placeholder='" + textboxName + "'])[1]")).SendKeys(sendkeys);
            driver.FindElement(By.XPath("(//button[text()='" + buttonName + "'])[1]")).Click();

        }
    }
}

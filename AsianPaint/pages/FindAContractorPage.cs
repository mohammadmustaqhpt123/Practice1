using OpenQA.Selenium;
using System;


namespace AsianPaint
{
    public  class FindAContractorPage
    {
        private IWebDriver driver;

        private By submitButton = By.XPath("(//button[text()='SEARCH'])[1]");
        private By textBox = By.XPath("(//input[@placeholder='Pincode/Area'])[1]");

        private By contractorName = By.XPath("(//div[@class='cl--infoCard--desc']/h3)[1]");
        private By error = By.XPath("//div[normalize-space()='Enter a valid 6 digit Zip Code']");

        public FindAContractorPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        /// <summary>
        /// one arument for textbox name and another one is for test data
        /// </summary>
        /// <param name="data"></param>
        /// <param name="textboxName"></param>
        public void FindACalculatorTextBox(string data, string textboxName)
        {
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("(//input[@placeholder='" + textboxName + "'])[1]")).SendKeys(data);
            Thread.Sleep(2000);
        }


        /// <summary>
        ///  this is  for cliking all button
        /// </summary>
        /// <param name="buttonName"></param>
        public void FindACalculatorButton(string buttonName)
        {
            Thread.Sleep(2000);
             driver.FindElement(By.XPath("(//button[text()='" + buttonName + "'])[1]")).Click();
            Thread.Sleep(2000);
        }

        public bool VerifyContractorsProfile()
        {
            string name = driver.FindElement(contractorName).Text;
            return name.Length > 0;
        }

        public int VerifyNoOfProfile()
        {
            IList<IWebElement> ele = driver.FindElements(By.XPath("(//div[@class='cl--infoCard--desc']/h3)"));
            return ele.Count;
        }
        
        public string ShowErrorMessage()
        {
            IWebElement error = driver.FindElement(this.error);
            return error.Text;
        }


        public string GetContractorName(int index)
        {
            return driver.FindElement(By.XPath("(//div[@class='cl--infoCard--desc']/p)[" + index + "]")).Text;
        }

     


























        private By pincodeTextbox = By.XPath("//input[@placeholder='Pincode/Area']");
        private By searchButton = By.XPath("(//button[@type='submit' and text() = 'SEARCH'])[1]");

        private By contractorImg = By.XPath("//div[@class='cl--infoCard--image']/img");
        private By contractorDetails = By.XPath("//div[@class='view-details-wp']/a");

        
        private By ContractorName = By.XPath("//div[@class='cl--infoCard--desc']/h3");    


       
        public string Title()
        {
            return driver.Title;
        }

        public void PincodeTextbox(string pincode)
        {
            driver.FindElement(pincodeTextbox).SendKeys(pincode);
        }

        public void ClickSubmitButton()
        {
            driver.FindElement(searchButton).Click();
        }

        public bool IsContractorDisplayed()
        {
            IList<IWebElement> imgs = driver.FindElements(contractorImg);
           
            return imgs[1].Displayed;
        }

        public void ClickViewDetail()
        {
           IList<IWebElement> contractorDetail = driver.FindElements(contractorDetails);
            contractorDetail[1].Click();
            //driver.SwitchTo().Window
        }

       

        public string ShowContractorName(int index)
        {
            IList<IWebElement> names = driver.FindElements(ContractorName);
            return names[index].Text;
        }

    }
}

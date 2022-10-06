using OpenQA.Selenium;
using System;


namespace AsianPaint
{
    public class PaintCalculatorPage
    {

        //---------------------------------------------------------------------------------------------------------------------------------------------------

        private By quickCalculatatorError = By.XPath("(//div[@class='form-global__field-message form-text-input__field-message' and @role='status'])[1]");
        private By calculatedResult = By.XPath("(//h2[@class='mt-2 track_recommended_product'])[1]");



        // Quick Calculator

        private IWebDriver driver;
        private By quickCalculatorValidation = By.XPath("//h2[contains(text(),'Recommended Product')]");
        public PaintCalculatorPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement GetQuickRadioBtnElement(string radioButtonName)
        {
            return driver.FindElement(By.XPath("//span[@class='form-global__custom-label-text align-middle d-inline-block'][normalize-space()='" + radioButtonName + "']/../input"));
        }

        public bool IsQuickRadioBtnSelected(string radioButtonName)
        {
            return driver.FindElement(By.XPath("//span[@class='form-global__custom-label-text align-middle d-inline-block'][normalize-space()='" + radioButtonName + "']/../input")).Selected;
        }

        public void QuickTextBox(string data, string placeholder)
        {
            driver.FindElement(By.XPath("//input[@placeholder='" + placeholder + "']")).SendKeys(data);
        }
        public void ClickQuickButtons(string button)
        {
            driver.FindElement(By.XPath("//a[text()='CALCULATE NOW']/..")).Click();
        }
        public void ClickQuickRadioButtons(string radioButton)
        {
            driver.FindElement(By.XPath("//span[@class='form-global__custom-label-text align-middle d-inline-block'][normalize-space()='Exterior']")).Click();
        }

        public string QuickCalculatorValidation()
        {
            return driver.FindElement(quickCalculatorValidation).Text;
        }


        public string QuickCalculatorInvalidVAlidation()
        {
            return driver.FindElement(quickCalculatatorError).Text;
        }


        public string QuickCalculatorResult()
        {
            return driver.FindElement(calculatedResult).GetAttribute("data-attr-lower");
        }



        //----------------------------------------
        // Advance Calculator
        public void ClickAdvanceCalculator()
        {
            driver.FindElement(By.XPath("//a[text()='Advanced calculator']")).Click();
        }
        public bool IsAdvanceRadioSelected(string radioName)
        {
            return driver.FindElement(By.XPath("//span[@class='form-global__custom-label-text '][normalize-space()='" + radioName + "']/../input")).Selected;
        }

        public void SelectAdvanceRadio(string radioName)
        {
            driver.FindElement(By.XPath("//span[@class='form-global__custom-label-text '][normalize-space()='" + radioName + "']")).Click();
        }

        public void AdvanceCalculatorTextBox(string TextBoxName, string data)
        {
            driver.FindElement(By.XPath("//input[@name='" + TextBoxName + "']")).SendKeys(data);

        }


        public void SelectWallDropDown(string wallName, string option)
        {
            int i = 0;
            if (wallName == "WALLA") i = 1;
            if (wallName == "WALLB") i = 2;
            if (wallName == "WALLC") i = 3;
            if (wallName == "WALLD") i = 4;

            driver.FindElement(By.XPath("(//div[@class='form-dropdown__custom-variant--target'])[" + i + "]/ul/li/a[text()='" + option + "']")).Click();


        }



        public void ClickWalls(string wallName)
        {
            driver.FindElement(By.XPath("//input[@name='" + wallName + "']")).Click();
        }

        public string VerifyAdvanceCalculatedResult()
        {
            return driver.FindElement(By.XPath("//h5[contains(text(),'Total budget estimate:')]/..//span")).Text;
        }


    }

}


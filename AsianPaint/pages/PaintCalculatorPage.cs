using OpenQA.Selenium;
using System;


namespace AsianPaint
{ 
    public class PaintCalculatorPage
    {

        //---------------------------------------------------------------------------------------------------------------------------------------------------

        private By quickCalculatatorError = By.XPath("(//div[@class='form-global__field-message form-text-input__field-message' and @role='status'])[1]");


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










        //---------------------------------------------------------------------------------------------------------------------------------------------------

        //    Finding locators of Quick calculatore


        private By quickFreshPaintingRadioBtn = By.CssSelector("input[value='freshPainting']");
        private By quickRePaintingRadioBtn = By.CssSelector("input[value='repainting']");

        private By quickInteriorRadioBtn = By.XPath("//input[@value='Interior']");
        private By quickExteriorRadioBtn = By.XPath("//label[@onclick='showHidePBCRoomOption(true)']//span[@class='form-global__custom-element form-radio-input__custom-element align-middle']");

        private By quickSizeOfHome = By.Name("CUSTOM_RADIO_ROOM_TYPE");

        private By quickCarpetAreaTextbox = By.Name("SQ_FT_VALUE");
        private By quickCalculatorBtn = By.ClassName("js-calculate-now-ladingpage-btn");

        

        

//---------------------------------------------------------------------------------------------------------------------------------------------------
        
        
        

        public bool IsFreshPaintRadioBtnSelected()
        {
            return driver.FindElement(quickFreshPaintingRadioBtn).Selected;
        }

        public void ClickRePaintRadioButton()
        {
            driver.FindElement(quickRePaintingRadioBtn).Click();
        }

        public bool IsInteriorRadioBtnSelected()
        {
            return driver.FindElement(quickInteriorRadioBtn).Selected;
        }

        public void ClickExteriorRadioButton()
        {
            driver.FindElement(quickExteriorRadioBtn).Click();
        }

        public void QuickCarpetArea(string carpetArea)
        {
            driver.FindElement(quickCarpetAreaTextbox).SendKeys(carpetArea);
        }


        public void SelectSizeOfHome(int bhk)
        {
            IList<IWebElement> sizeOfHome = driver.FindElements(quickSizeOfHome);
            sizeOfHome[bhk-1].Click();
        }
        
        public bool Is1BHKRadioBtnSelected()
        {
            IList<IWebElement> sizeOfHome = driver.FindElements(quickSizeOfHome);
            
            return sizeOfHome[0].Selected;
        }
        public void ClickQuickCalculateNowBtn()
        {
            driver.FindElement(quickCalculatorBtn).Click();
        }


        

        

//-------------------------------------------------------------------------------------------------------------------------------------------------


        // Advanced Calculator



        //  Finding locators of Advance calculatore

        private By advancedCalculator = By.LinkText("Advanced calculator");
        private By advanceFreshPaintingRadioBtn = By.XPath("//input[@value='fresh-painting']");
        private By advanceRePaintingRadioBtn = By.XPath("//input[@value='re-painting']");
        private By advanceInteriorRadioBtn = By.XPath("//input[@value='interior']");
        private By advanceExteriorRadioBtn = By.XPath("//input[@value='Exterior']");
        private By advanceAddRoom = By.XPath("//a[@href='javascript:;']");
        private By advanceWidth = By.Id("Width");
        private By advanceLength = By.Id("Length");
        private By advanceHeight = By.Id("Height");
        private By advanceWindow = By.Id("window");
        private By advanceDoor = By.Id("door");


    //   Four Walls
        private By advanceWallA = By.XPath("(//div[@class='form-dropdown__custom-variant--target'])[1]/ul/li/a");
        private By advanceWallB = By.XPath("(//div[@class='form-dropdown__custom-variant--target'])[2]/ul/li/a");
        private By advanceWallC = By.XPath("(//div[@class='form-dropdown__custom-variant--target'])[3]/ul/li/a");
        private By advanceWallD = By.XPath("(//div[@class='form-dropdown__custom-variant--target'])[4]/ul/li/a");


  //   include ceiling
        private By advanceIncludeCeilingBtn = By.XPath("//input[@name='CUSTOM_CHECKBOX']");

   //  Choose products Drop Down

        private By advancePaintDropDown = By.XPath("(//div[@class='form-dropdown__custom-variant--target'])[5]/ul/li/a");
        private By advanceTextureDropDown = By.XPath("(//div[@class='form-dropdown__custom-variant--target'])[6]/ul/li/a");
        private By advanceWallpaperDropDown = By.XPath("(//div[@class='form-dropdown__custom-variant--target'])[7]/ul/li/a");


  //   Choose products Paint

        private By advanceRoyaleRadioBtn = By.XPath("//input[@value='royale']");
        private By advanceApocoliteRadioBtn = By.XPath("//input[@value='apcolite']");
        private By advanceTractorRadioBtn = By.XPath("//input[@value='tractor']");

  //   Choose products Texture
        private By advanceEconomyTextureRadioBtn = By.XPath("(//input[@value='economy'])[1]");
        private By advancePremiumTextureRadioBtn = By.XPath("(//input[@value='premium'])[1]");
        private By advanceLuxuryTextureRadioBtn = By.XPath("(//input[@value='luxury'])[1]");

 //   Choose products Wallpaper
        private By advanceEconomyWallpaperRadioBtn = By.XPath("(//input[@value='economy'])[2]");
        private By advancePremiumWallpaperRadioBtn = By.XPath("(//input[@value='premium'])[2]");
        private By advanceLuxuryWallpaperRadioBtn = By.XPath("(//input[@value='luxury'])[2]");

 //-------------------------------------------------------------------------------------------------------------------------------------------------


        public void ClickAdvanceCalculator()
        {
            driver.FindElement(advancedCalculator).Click();
        }
        
        public void ClickAdvanceFreshPaintRadio()
        {
            driver.FindElement(advanceFreshPaintingRadioBtn).Click();
        }

        public void ClickAdvanceRePaintRadio()
        {
            driver.FindElement(advanceRePaintingRadioBtn).Click();
        }

        public void ClickAdvanceInteriorRadio()
        {
            driver.FindElement(advanceInteriorRadioBtn).Click();
        }

        public void ClickAdvanceExteriorRadio()
        {
            driver.FindElement(advanceExteriorRadioBtn).Click();
        }

        public void ClickAdvanceAddRoom()
        {
            driver.FindElement(advanceAddRoom).Click();
        }

        public void ClickAdvanceWidth()
        {
            driver.FindElement(advanceWidth).Click();
        }

        public void ClickAdvanceLength()
        {
            driver.FindElement(advanceLength).Click();
        }

        public void ClickAdvanceHeight()
        {
            driver.FindElement(advanceHeight).Click();
        }
        public void ClickAdvanceWindow()
        {
            driver.FindElement(advanceWindow).Click();
        }

        public void ClickAdvanceDoor()
        {
            driver.FindElement(advanceDoor).Click();
        }



        // WallA drop down
        public void SelectAdvanceWallADropDown(string wallType)
        {
           IList<IWebElement>  wallAElement = driver.FindElements(advanceWallA);
            wallType = wallType.ToLower();
           foreach(var ele in wallAElement)
            {
                string elementText = ele.Text.ToLower();

                if (wallType.Equals(elementText))
                {
                    ele.Click();
                }
            }

        }



        // WallB drop down
        public void SelectAdvanceWallBDropDown(string wallType)
        {
            IList<IWebElement> wallAElement = driver.FindElements(advanceWallB);
            wallType = wallType.ToLower();
            foreach (var ele in wallAElement)
            {
                string elementText = ele.Text.ToLower();

                if (wallType.Equals(elementText))
                {
                    ele.Click();
                }
            }

        }

        // Wallc drop down
        public void SelectAdvanceWallCDropDown(string wallType)
        {
            IList<IWebElement> wallAElement = driver.FindElements(advanceWallC);
            wallType = wallType.ToLower();
            foreach (var ele in wallAElement)
            {
                string elementText = ele.Text.ToLower();

                if (wallType.Equals(elementText))
                {
                    ele.Click();
                }
            }

        }


        // WallD drop down
        public void SelectAdvanceWallDDropDown(string wallType)
        {
            IList<IWebElement> wallAElement = driver.FindElements(advanceWallD);
            wallType = wallType.ToLower();
            foreach (var ele in wallAElement)
            {
                string elementText = ele.Text.ToLower();

                if (wallType.Equals(elementText))
                {
                    ele.Click();
                }
            }

        }

        // include ceiling

        public void ClickAdvanceIncludeCeiling()
        {
            driver.FindElement(advanceIncludeCeilingBtn).Click();
        }



//--------------------------------------------------------------------------------------------------------
     
        
        
        //  Choose products Paint radio button
        
        public void ClickAdvanceRoyalPaintRadio()
        {
            driver.FindElement(advanceRoyaleRadioBtn).Click();
        }

        public void ClickAdvanceApocolitePaintRadio()
        {
            driver.FindElement(advanceApocoliteRadioBtn).Click();
        }

        public void ClickAdvanceTractorPaintRadio()
        {
            driver.FindElement(advanceTractorRadioBtn).Click();
        }


        //  Choose products Texture radio button

        public void ClickAdvanceEconomyTextureRadio()
        {
            driver.FindElement(advanceEconomyTextureRadioBtn).Click();
        }
        public void ClickAdvancePremiumTextureRadio()
        {
            driver.FindElement(advancePremiumTextureRadioBtn).Click();
        }

        public void ClickAdvanceLuxuryTextureRadio()
        {
            driver.FindElement(advanceLuxuryTextureRadioBtn).Click();
        }

        //  Choose products Wallpaper radio button

        public void ClickAdvanceEconomyWallpaperRadio()
        {
            driver.FindElement(advanceEconomyWallpaperRadioBtn).Click();
        }
        public void ClickAdvancePremiumWallpaperRadio()
        {
            driver.FindElement(advancePremiumWallpaperRadioBtn).Click();
        }

        public void ClickAdvanceLuxuryWallpaperRadio()
        {
            driver.FindElement(advanceLuxuryWallpaperRadioBtn).Click();
        }



        //--------------------------------------------------------------------------------------------------------

        // Choose products Drop down


        // Advance Paint drop down 
        public void SelectAdvancePaintQualityDropDown(int value)
        {
            IList<IWebElement> ele = driver.FindElements(advancePaintDropDown);
            
            for(int i=1; i<=ele.Count; i++)
            {
                if(value == i)
                {
                    ele[i].Click();
                }
            }

        }


        // Advance Texture drop down 
        public void SelectAdvanceTextureQualityDropDown(int value)
        {
            IList<IWebElement> ele = driver.FindElements(advanceTextureDropDown);

            for (int i = 1; i <= ele.Count; i++)
            {
                if (value == i)
                {
                    ele[i].Click();
                }
            }

        }


        // Advance Wallpaper drop down 
        public void SelectAdvanceWallpaperQualityDropDown(int value)
        {
            IList<IWebElement> ele = driver.FindElements(advanceWallpaperDropDown);

            for (int i = 1; i <= ele.Count; i++)
            {
                if (value == i)
                {
                    ele[i].Click();
                }
            }

        }

    }
}

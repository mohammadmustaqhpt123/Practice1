using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace AsianPaint
{
    [Binding]
    public class QuickCalculatorStepDefinitions : UtilityClass
    {
        public FindAContractorPage fc;
        public HomePage hp;
        public PaintCalculatorPage pc;
      

        public void ObjectMethod()
        {
            fc = new FindAContractorPage(driver);
            hp = new HomePage(driver);
            pc = new PaintCalculatorPage(driver);
            
        }

        [Then(@"User Verity Is selected ""([^""]*)"" radio button")]
        public void ThenUserVerityIsSelectedRadioButton(string radio)
        {
            ObjectMethod();
            pc.IsQuickRadioBtnSelected(radio);

        }

        [When(@"User Enter valid ""([^""]*)"",""([^""]*)"" Text box")]
        public void WhenUserEnterValidTextBox(string placeholder, string data)
        {
            ObjectMethod();
            pc.QuickTextBox(placeholder, data);
        }

        [When(@"User Click on ""([^""]*)"" button of Quick Calculator")]
        public void WhenUserClickOnButtonOfQuickCalculator(string button)
        {
            ObjectMethod();
            pc.ClickQuickButtons(button);
        }

       
        [Then(@"User Verify Quick calcualtor with valid data")]
        public void ThenUserVerifyQuickCalcualtorWithValidData()
        {
            ObjectMethod();
            string actual = pc.QuickCalculatorValidation();
            string expected = "Recommended Product";
            Assert.That(actual, Is.EqualTo(expected));
            Console.WriteLine(actual);
        }
        //------------------------------------------------------------
        // invalid data
        [When(@"User Enter invalid ""([^""]*)"",""([^""]*)"" Text box")]
        public void WhenUserEnterInvalidTextBox(string placeholder, string data)
        {
            ObjectMethod();
            pc.QuickTextBox(placeholder, data);
        }


        

        [Then(@"User Verify Quick calcualtor with invalid")]
        public void ThenUserVerifyQuickCalcualtorWithInvalid()
        {
            ObjectMethod();
            string actual = pc.QuickCalculatorInvalidVAlidation();
            string expected = "Field should contain non-decimal value greater than 0";
            Assert.That(actual, Is.EqualTo(expected));
            Console.WriteLine(actual);
        }


        //------------------------------------------------------------
        // valid data
        //Exterior radio button
        [Then(@"User Click on ""([^""]*)"" radio button")]
        public void ThenUserClickOnRadioButton(string radio)
        {
            ObjectMethod();
            pc.ClickQuickRadioButtons(radio);
        }














        //[When(@"hover on paint and texture")]
        //public void WhenHoverOnPaintAndTextures()
        //{
        //    ObjectMethod();
        //    IWebElement paintAndTextures = hp.PaintAndTextures();
        //    Thread.Sleep(2000);
        //    Hover(paintAndTextures);
        //    Thread.Sleep(3000);
        //}

        //[When(@"click on paint budget calculator")]
        //public void WhenClickOnPaintBudgetCalculator()
        //{
        //    ObjectMethod();
        //    hp.ClickPaintBudgetCalculator();

        //}

        //[Then(@"Verify the page title")]
        //public void ThenVerifyThePageTitle()
        //{
        //    ObjectMethod();
        //    string actualResult = ValidatePageTitle();
        //    string expectedResult = "Paint Calculator: Quick & Advanced Paint Cost Calculator - Asian Paints";
        //    Assert.That(actualResult, Is.EqualTo(expectedResult));
        //    Console.WriteLine(actualResult);
        //}

        ////--------------------------------------------------------------------------------------------------------


        //// Verify  quick Calculator with valid data and Select interior space radio button

        //[Then(@"Verify fresh painting radio button is selected")]
        //public void ThenVerifyFreshPaintingRadioButtonIsSelected()
        //{
        //    ObjectMethod();
        //    bool actualResult = pc.IsFreshPaintRadioBtnSelected();
        //    Assert.That(actualResult, Is.True);
        //    Console.WriteLine(actualResult);

        //}

        //[Then(@"Verify interior space radio button is selected")]
        //public void ThenVerifyInteriorSpaceRadioButtonIsSelected()
        //{
        //    ObjectMethod();
        //    bool actualResult = pc.IsInteriorRadioBtnSelected();
        //    Assert.That(actualResult, Is.True);
        //    Console.WriteLine(actualResult);
        //}

        //[Then(@"Verify (.*)BHK radio button is selected")]
        //public void ThenVerifyBHKRadioButtonIsSelected(int p0)
        //{
        //    ObjectMethod();
        //    bool actualResult = pc.Is1BHKRadioBtnSelected();
        //    Assert.That(actualResult, Is.True);
        //    Console.WriteLine(actualResult);
        //}

        //[Then(@"enter valid carpetArea ""([^""]*)""")]
        //public void ThenEnterValidCarpetArea(string carpetArea)
        //{
        //    ObjectMethod();
        //    pc.QuickCarpetArea(carpetArea);
        //}




        //[Then(@"Click on calculate now button of quick calculator")]
        //public void ThenClickOnCalculateNowButtonOfQuickCalculator()
        //{
        //    ObjectMethod();
        //    pc.ClickQuickCalculateNowBtn();
        //}


        //[Then(@"calculated result is displayed of quick calculator")]
        //public void ThenCalculatedResultIsDisplayedOfQuickCalculator()
        //{
        //    ObjectMethod();
        //    string expectedResult = "Recommended Product";
        //    Thread.Sleep(10000);
        //    string actualResult = pc.QuickCalculatorValidation();
        //    Assert.That(actualResult, Is.EqualTo(expectedResult));
        //    Console.WriteLine(actualResult);

        //}

        //[Then(@"select exterior space radio button")]
        //public void ThenSelectExteriorSpaceRadioButton()
        //{
        //    ObjectMethod();
        //    Thread.Sleep(2000);
        //    pc.ClickExteriorRadioButton();

        //}


        ////____________________________________________________________________________________

        //[Then(@"enter invalid carpetArea ""([^""]*)""")]
        //public void ThenEnterInvalidCarpetArea(string carpetArea)
        //{
        //    ObjectMethod();
        //    pc.QuickCarpetArea(carpetArea);
        //}

        //[Then(@"error message is displayed")]
        //public void ThenErrorMessageIsDisplayed()
        //{
        //    ObjectMethod();
        //    string pat = "^[a-zA-Z]";
        //    Regex pattern = new Regex(pat);
        //    string message = pc.ShowErrorMessage();
        //    bool actualResult = pattern.IsMatch(message);
        //    Assert.That(actualResult, Is.True);
        //    Console.WriteLine(message);
        //}
    }
}

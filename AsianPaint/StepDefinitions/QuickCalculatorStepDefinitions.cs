using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace AsianPaint
{
    [Binding]
    public class QuickCalculatorStepDefinitions : ApplicationHooks
    {
       
      

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
            bool actual = pc.IsQuickRadioBtnSelected(radio);
            Assert.That(actual, Is.True);
            Console.WriteLine(actual);

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


        [Then(@"User Verify Quick calcualtor Calculated Result ""([^""]*)""")]
        public void ThenUserVerifyQuickCalcualtorCalculatedResult(string expectedResult)
        {
            ObjectMethod();
            string actual = pc.QuickCalculatorResult();
            string expected = expectedResult;
            Assert.That(actual, Is.EqualTo(expected));
            Console.WriteLine(actual);
        }



    }
}

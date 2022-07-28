using NUnit.Framework;
using System;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;

namespace AsianPaint
{
    [Binding]
    public class FindAContractorStepDefinitions : UtilityClass
    {
        public FindAContractorPage fc;
        public HomePage hp;
        

        public void ObjectMethod()
        {
            fc = new FindAContractorPage(driver);
            hp = new HomePage(driver);
           
        }
//-------------------------------------------------------------
     // verify the pincode text box with valid data
        /// <summary>
        /// This method for enter valid data
        /// </summary>
        /// <param name="data"> it is valid data for pincode text box</param>
        /// <param name="textBox">this is name of pincode text box</param>

        [When(@"User enter the valid ""([^""]*)"" in ""([^""]*)"" text box")]
        public void WhenUserEnterTheValidInTextBox(string data, string textBox)
        {
            ObjectMethod();
            fc.FindACalculatorTextBox(data,textBox);
        }


        

        [When(@"User Click on ""([^""]*)"" button")]
        public void WhenUserClickOnButton(string button)
        {
            ObjectMethod();
            fc.FindACalculatorButton(button);
        }

        [Then(@"Contractors profile display")]
        public void ThenContractorsProfileDisplay()
        {
            ObjectMethod();
            bool actual = fc.VerifyContractorsProfile();
            Assert.That(actual, Is.True);
            Console.WriteLine(actual);
        }
//-----------------------------------------------------------------------------------------
        /// <summary>
        /// This method for enter Invalid data
        /// </summary>
        /// <param name="data"> it is valid data for pincode text box</param>
        /// <param name="textBox">this is name of pincode text box</param>

        [When(@"User enter the invalid ""([^""]*)"" in ""([^""]*)"" text box")]
        public void WhenUserEnterTheInvalidInTextBox(string data, string textBox)
        {
            ObjectMethod();
            fc.FindACalculatorTextBox(data, textBox);
        }


        /// <summary>
        /// This method for error message validation 
        /// </summary>
        [Then(@"Error message display")]
        public void ThenErrorMessageDisplay()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            string expected = "Enter a valid 6 digit Zip Code";
            string actualResult = fc.ShowErrorMessage();
            Assert.That(actualResult, Is.EqualTo(expected));
            Console.WriteLine(actualResult);
        }



// No of Contractor
        [Then(@"Verify No of Contractor Profile")]
        public void ThenVerifyNoOfContractorProfile()
        {
            ObjectMethod();
            int actual = fc.VerifyNoOfProfile();
            int expected = 35;
            Assert.That(actual, Is.EqualTo(expected));
            Console.WriteLine(actual);
        }

 // Verify Name of Contractor
        [Then(@"Verify Contractor name")]
        public void ThenVerifyContractorName()
        {
            ObjectMethod();
            string actual = fc.GetContractorName(1);
            string  expected = "Shivakumar K";
            Assert.That(actual, Is.EqualTo(expected));
            Console.WriteLine(actual);
        }










    }
}

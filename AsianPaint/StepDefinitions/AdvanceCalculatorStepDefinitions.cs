using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AsianPaint
{
    [Binding]
    public class AdvanceCalculatorStepDefinitions : ApplicationHooks
    {
        public void ObjectMethod()
        {
            fc = new FindAContractorPage(driver);
            hp = new HomePage(driver);
            pc = new PaintCalculatorPage(driver);

        }

        [When(@"User Click on Advance Calculator")]
        public void WhenUserClickOnAdvanceCalculator()
        {
            ObjectMethod();
            pc.ClickAdvanceCalculator();
            

        }

        [Then(@"User Verity Is selected ""([^""]*)"" radio button of Advance Calculator")]
        public void ThenUserVerityIsSelectedRadioButtonOfAdvanceCalculator(string radio)
        {
            ObjectMethod();
            bool actual = pc.IsAdvanceRadioSelected(radio);
            Assert.That(actual, Is.True);
            Console.WriteLine(actual);
        }

        [When(@"Enter the data in Room TextBox")]
        public void WhenEnterTheDataInRoomTextBox(Table table)
        {
            ObjectMethod();
            var dictionary = ToDictionary(table);
            foreach(string key in dictionary.Keys)
            {
                var value = dictionary[key];
                pc.AdvanceCalculatorTextBox(key, value);
            }
        }

        [When(@"User Select Walls of room")]
        public void WhenUserSelectWallsOfRoom(Table table)
        {
            ObjectMethod();
        }



        [When(@"User Click on ""([^""]*)""")]
        public void WhenUserClickOn(string wall)
        {
            ObjectMethod();
            pc.ClickWalls(wall);
        }

       

        [When(@"User Click on Option ""([^""]*)"" of ""([^""]*)""")]
        public void WhenUserClickOnOptionOf(string option, string wall)
        {
            pc.SelectWallDropDown(wall, option);
        }


        [Then(@"User Verify the Caculated Result of Advance Calculator ""([^""]*)""")]
        public void ThenUserVerifyTheCaculatedResultOfAdvanceCalculator(string expected)
        {
            ObjectMethod();
            string actual = pc.VerifyAdvanceCalculatedResult();
            Assert.That(actual, Is.EqualTo(expected));
            Console.WriteLine(actual);
        }


    }
}

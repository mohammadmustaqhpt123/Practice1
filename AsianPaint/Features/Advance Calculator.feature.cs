// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AsianPaint.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Advance Calculator")]
    public partial class AdvanceCalculatorFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Advance Calculator.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Advance Calculator", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
#line 4
testRunner.Given("Launch the browser and Application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 5
testRunner.When("User mouse hover on \"PAINTS & TEXTURES\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 6
testRunner.And("User click on \"Paint Budget Calculator\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 7
testRunner.And("User Click on Advance Calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify the Advance Calculator with valid data and Select Interior radio button")]
        public virtual void VerifyTheAdvanceCalculatorWithValidDataAndSelectInteriorRadioButton()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify the Advance Calculator with valid data and Select Interior radio button", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 10
testRunner.Then("User Verity Is selected \"Fresh Painting\" radio button of Advance Calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
testRunner.Then("User Verity Is selected \"Interior\" radio button of Advance Calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table1.AddRow(new string[] {
                            "Width",
                            "12"});
                table1.AddRow(new string[] {
                            "Length",
                            "12"});
                table1.AddRow(new string[] {
                            "Height",
                            "12"});
                table1.AddRow(new string[] {
                            "window",
                            "6"});
                table1.AddRow(new string[] {
                            "door",
                            "8"});
#line 12
testRunner.When("Enter the data in Room TextBox", ((string)(null)), table1, "When ");
#line hidden
#line 20
testRunner.And("User Click on \"WALLA\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
testRunner.And("User Click on Option \"Texture\" of \"WALLA\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
testRunner.And("User Click on \"WALLB\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
testRunner.And("User Click on Option \"Paint\" of \"WALLB\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
testRunner.And("User Click on \"WALLC\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
testRunner.And("User Click on Option \"Paint\" of \"WALLC\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
testRunner.And("User Click on \"WALLD\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
testRunner.And("User Click on Option \"Paint\" of \"WALLD\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
testRunner.And("User Click on \"CALCULATE NOW\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
testRunner.Then("User Verify the Caculated Result of Advance Calculator \"₹ 10,575\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify the Advance Calculator with invalid data and Select Interior radio button")]
        public virtual void VerifyTheAdvanceCalculatorWithInvalidDataAndSelectInteriorRadioButton()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify the Advance Calculator with invalid data and Select Interior radio button", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 32
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 33
testRunner.Then("User Verity Is selected \"Fresh Painting\" radio button of Advance Calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
testRunner.Then("User Verity Is selected \"Interior\" radio button of Advance Calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table2.AddRow(new string[] {
                            "Width",
                            "9999999"});
                table2.AddRow(new string[] {
                            "Length",
                            "9999999"});
                table2.AddRow(new string[] {
                            "Height",
                            "9999999"});
                table2.AddRow(new string[] {
                            "window",
                            "999"});
                table2.AddRow(new string[] {
                            "door",
                            "999"});
#line 35
testRunner.When("Enter the data in Room TextBox", ((string)(null)), table2, "When ");
#line hidden
#line 43
testRunner.And("User Click on \"WALLA\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
testRunner.And("User Click on Option \"Texture\" of \"WALLA\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
testRunner.And("User Click on \"WALLB\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
testRunner.And("User Click on Option \"Paint\" of \"WALLB\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
testRunner.And("User Click on \"WALLC\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
testRunner.And("User Click on Option \"Paint\" of \"WALLC\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
testRunner.And("User Click on \"WALLD\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
testRunner.And("User Click on Option \"Paint\" of \"WALLD\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
testRunner.And("User Click on \"CALCULATE NOW\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
testRunner.Then("User Verify the Caculated Result of Advance Calculator \"₹ 21,47,48,36,47,545\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

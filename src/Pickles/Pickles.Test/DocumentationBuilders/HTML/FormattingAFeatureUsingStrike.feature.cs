﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PicklesDoc.Pickles.Test.DocumentationBuilders.HTML
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Formatting a Feature Using Strike")]
    public partial class FormattingAFeatureUsingStrikeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FormattingAFeatureUsingStrike.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Formatting a Feature Using Strike", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Description with image should render correctly")]
        [NUnit.Framework.CategoryAttribute("enableExperimentalFeatures")]
        public virtual void DescriptionWithImageShouldRenderCorrectly()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Description with image should render correctly", new string[] {
                        "enableExperimentalFeatures"});
#line 4
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 6
  testRunner.Given("I have this feature description", "Including a picture: ![](./image.png)", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
    testRunner.When("I generate the documentation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
    testRunner.Then("the result should be", "<div id=\"feature\">\r\n  <h1>a feature</h1>\r\n  <div class=\"description\">\r\n    <p>Inc" +
                    "luding a picture: <img src=\"./image.png\" alt=\"\" /></p>\r\n  </div>\r\n  <ul id=\"scen" +
                    "arios\" />\r\n</div>", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Description with image with extra attributes should render correctly")]
        public virtual void DescriptionWithImageWithExtraAttributesShouldRenderCorrectly()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Description with image with extra attributes should render correctly", ((string[])(null)));
#line 22
       this.ScenarioSetup(scenarioInfo);
#line hidden
#line 24
  testRunner.Given("I have this feature description", "Including a picture: ![alt text](./image.png \"Image Title\")", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
    testRunner.When("I generate the documentation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
    testRunner.Then("the result should be", "<div id=\"feature\">\r\n  <h1>a feature</h1>\r\n  <div class=\"description\">\r\n    <p>Inc" +
                    "luding a picture: <img src=\"./image.png\" alt=\"alt text\" title=\"Image Title\" /></" +
                    "p>\r\n  </div>\r\n  <ul id=\"scenarios\" />\r\n</div>", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

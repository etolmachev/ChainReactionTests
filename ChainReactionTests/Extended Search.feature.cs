﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ChainReactionTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Extended Search")]
    public partial class ExtendedSearchFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Extended Search.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Extended Search", @"To have a quick way to find products matching my specific needs,
As a customer,
I want to be able to filter search by number of criteria (Brand, Gender, Price, etc.).
A/C:
1. I have extended search on search page
2. I can filter my search results by Brand, Gender, Price etc (one filter, some of these filters or all filters).
3. If no results found, I should see message ""no results found""
4. Only valid results should be shown
4.1 Items not matching specified search criteria are NOT listed.", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 12
#line 13
testRunner.Given("I open browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.When("I navigate to the page \"http://www.chainreactioncycles.com/ru/en\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("I see the main page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.When("I click on RubRub dropdown and I select language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.And("I click Update button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.Then("I see the main page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify search with option Gender")]
        [NUnit.Framework.TestCaseAttribute("bike", "Male", "1184", "466", null)]
        [NUnit.Framework.TestCaseAttribute("Jacket", "Female", "245", "74", null)]
        public virtual void VerifySearchWithOptionGender(string product, string gender, string result, string count, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify search with option Gender", exampleTags);
#line 21
this.ScenarioSetup(scenarioInfo);
#line 12
this.FeatureBackground();
#line 23
 testRunner.When(string.Format("I enter \"{0}\" in the search text", product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.And(string.Format("I see \"{0} results for \'{1}\'\" message on search page", result, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.When(string.Format("I click gender \"{0} {1}\" on search page", gender, count), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then(string.Format("I see \"{0} results for \'{1}\'\" message on search page", count, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify search with option Gender and Brand")]
        [NUnit.Framework.TestCaseAttribute("bike", "Male", "1184", "466", "Colnago", "4", null)]
        [NUnit.Framework.TestCaseAttribute("JaCKet", "Female", "245", "74", "Fox Racing", "2", null)]
        [NUnit.Framework.TestCaseAttribute("COM", "Male", "109", "53", "Ergon", "4", null)]
        public virtual void VerifySearchWithOptionGenderAndBrand(string product, string gender, string result, string countGender, string brand, string countBrand, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify search with option Gender and Brand", exampleTags);
#line 36
this.ScenarioSetup(scenarioInfo);
#line 12
this.FeatureBackground();
#line 38
 testRunner.When(string.Format("I enter \"{0}\" in the search text", product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.And(string.Format("I see \"{0} results for \'{1}\'\" message on search page", result, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.When(string.Format("I click gender \"{0} {1}\" on search page", gender, countGender), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.Then(string.Format("I see \"{0} results for \'{1}\'\" message on search page", countGender, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.When(string.Format("I click brand \"{0} {1}\" on search page", brand, countBrand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then(string.Format("I see \"{0} results for \'{1}\'\" message on search page", countBrand, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.And(string.Format("I see \"{0}\" items on search page", countBrand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And(string.Format("I see items name include \"{0}\"", brand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify search with three options")]
        [NUnit.Framework.TestCaseAttribute("bike", "Male", "1184", "466", "Dawes", "8", "Blue", "3", null)]
        [NUnit.Framework.TestCaseAttribute("JaCKet", "Female", "245", "74", "Fox Racing", "2", "Black", "1", null)]
        public virtual void VerifySearchWithThreeOptions(string product, string gender, string result, string countGender, string brand, string countBrand, string colour, string countColour, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify search with three options", exampleTags);
#line 58
this.ScenarioSetup(scenarioInfo);
#line 12
this.FeatureBackground();
#line 60
 testRunner.When(string.Format("I enter \"{0}\" in the search text", product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.And(string.Format("I see \"{0} results for \'{1}\'\" message on search page", result, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.When(string.Format("I click gender \"{0}\" on search page", gender), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.Then(string.Format("I see \"{0} results for \'{1}\'\" message on search page", countGender, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.When(string.Format("I click brand \"{0}\" on search page", brand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.Then(string.Format("I see \"{0} results for \'{1}\'\" message on search page", countBrand, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
 testRunner.And(string.Format("I see \"{0}\" items on search page", countBrand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And(string.Format("I see items name include \"{0}\"", brand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.When(string.Format("I click colour \"{0}\" on search page", colour), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.Then(string.Format("I see \"{0} results for \'{1}\'\" message on search page", countColour, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
 testRunner.And(string.Format("I see \"{0}\" items on search page", countColour), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And(string.Format("I see items include colour \"{0}\"", colour), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify find 0 items with incorrect option Price")]
        [NUnit.Framework.TestCaseAttribute("bike", "Male", "1184", "466", "Dawes", "8", "Blue", "3", "1000", "1500", null)]
        [NUnit.Framework.TestCaseAttribute("JaCKet", "Female", "245", "74", "Fox Racing", "2", "Black", "1", "5000", "8000", null)]
        public virtual void VerifyFind0ItemsWithIncorrectOptionPrice(string product, string gender, string result, string countGender, string brand, string countBrand, string colour, string countColour, string from, string to, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify find 0 items with incorrect option Price", exampleTags);
#line 84
this.ScenarioSetup(scenarioInfo);
#line 12
this.FeatureBackground();
#line 86
 testRunner.When(string.Format("I enter \"{0}\" in the search text", product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
 testRunner.And(string.Format("I see \"{0} results for \'{1}\'\" message on search page", result, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.When(string.Format("I click gender \"{0}\" on search page", gender), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
 testRunner.Then(string.Format("I see \"{0} results for \'{1}\'\" message on search page", countGender, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
 testRunner.When(string.Format("I click brand \"{0}\" on search page", brand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then(string.Format("I see \"{0} results for \'{1}\'\" message on search page", countBrand, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
 testRunner.And(string.Format("I see \"{0}\" items on search page", countBrand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.And(string.Format("I see items name include \"{0}\"", brand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.When(string.Format("I click colour \"{0}\" on search page", colour), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.Then(string.Format("I see \"{0} results for \'{1}\'\" message on search page", countColour, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.And(string.Format("I see \"{0}\" items on search page", countColour), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And(string.Format("I see items include colour \"{0}\"", colour), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.When(string.Format("I choose price from \"{0}\" to \"{1}\" on search page and click Go button", from, to), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.Then("I see \"No products found – please change your price range\" message on search page" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify delete option fron filter")]
        [NUnit.Framework.TestCaseAttribute("bike", "Male", "1184", "466", "Dawes", "8", "Blue", "3", "1000", "1500", null)]
        [NUnit.Framework.TestCaseAttribute("JaCKet", "Female", "245", "74", "Fox Racing", "2", "Black", "1", "5000", "8000", null)]
        public virtual void VerifyDeleteOptionFronFilter(string product, string gender, string result, string countGender, string brand, string countBrand, string colour, string countColour, string from, string to, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify delete option fron filter", exampleTags);
#line 112
this.ScenarioSetup(scenarioInfo);
#line 12
this.FeatureBackground();
#line 114
 testRunner.When(string.Format("I enter \"{0}\" in the search text", product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 115
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 117
 testRunner.And(string.Format("I see \"{0} results for \'{1}\'\" message on search page", result, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.When(string.Format("I click gender \"{0}\" on search page", gender), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.Then(string.Format("I see \"{0} results for \'{1}\'\" message on search page", countGender, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 122
 testRunner.When(string.Format("I click brand \"{0}\" on search page", brand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
 testRunner.Then(string.Format("I see \"{0} results for \'{1}\'\" message on search page", countBrand, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 124
 testRunner.And(string.Format("I see \"{0}\" items on search page", countBrand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.And(string.Format("I see items name include \"{0}\"", brand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.When(string.Format("I click colour \"{0}\" on search page", colour), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 128
 testRunner.Then(string.Format("I see \"{0} results for \'{1}\'\" message on search page", countColour, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 129
 testRunner.And(string.Format("I see \"{0}\" items on search page", countColour), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
 testRunner.And(string.Format("I see items include colour \"{0}\"", colour), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.When(string.Format("I choose price from \"{0}\" to \"{1}\" on search page and click Go button", from, to), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 133
 testRunner.Then("I see \"No products found – please change your price range\" message on search page" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 135
 testRunner.When("I delete price from filter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 136
 testRunner.Then(string.Format("I see I see \"{0} results for \'{1}\'\" message on search page", countColour, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 138
 testRunner.When(string.Format("I delete option \"{0}\" from filter", colour), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 139
 testRunner.Then(string.Format("I see \"{0} results for \'{1}\'\" message on search page", countBrand, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
 testRunner.And(string.Format("I see \"{0}\" items on search page", countBrand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.And(string.Format("I see items name include \"{0}\"", brand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
 testRunner.When(string.Format("I delete option \"{0}\" from filter", brand), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 144
 testRunner.Then(string.Format("I see \"{0} results for \'{1}\'\" message on search page", countGender, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 146
 testRunner.When(string.Format("I delete option \"{0}\" from filter", gender), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 147
 testRunner.Then(string.Format("I see \"{0} results for \'{1}\'\" message on search page", result, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

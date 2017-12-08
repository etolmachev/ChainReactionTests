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
    [NUnit.Framework.DescriptionAttribute("Item Details")]
    public partial class ItemDetailsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Item Details.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Item Details", @"To have a better idea about each product,
As a customer,
I want to have a page with details information about selected product, such as rating, price, etc.
A/C:
1. There is a page with description and the following details for each item:
Name,
Rating,
Price,
Color,
Model/Size", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 13
#line 14
 testRunner.Given("I open browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When("I navigate to the page \"http://www.chainreactioncycles.com/ru/en\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("I see the main page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.When("I click on RubRub dropdown and I select language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.And("I click Update button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.Then("I see the main page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify Item Details of bike product")]
        [NUnit.Framework.TestCaseAttribute("Vitus Bikes Sommet CR FS Bike - Carbon Sram X1 1x11 2017", "138999.00 RUB", "4.8 / 5", "Black - Grey", "27.5\" (650b)", null)]
        [NUnit.Framework.TestCaseAttribute("Intense Spider 275C NM Expert Bike", "171999.00 RUB", "5 / 5", "Silver", "27.5\" (650b)", null)]
        public virtual void VerifyItemDetailsOfBikeProduct(string name, string price, string rating, string colour, string wheelSize, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify Item Details of bike product", exampleTags);
#line 22
this.ScenarioSetup(scenarioInfo);
#line 13
this.FeatureBackground();
#line 24
 testRunner.When(string.Format("I enter \"{0}\" in the search text", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.When(string.Format("I click on product with name \"{0}\" from search results", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then(string.Format("I see the product page for \"{0}\" is loaded", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Details",
                        "Value"});
            table1.AddRow(new string[] {
                        "Price",
                        string.Format("{0}", price)});
            table1.AddRow(new string[] {
                        "Rating",
                        string.Format("{0}", rating)});
            table1.AddRow(new string[] {
                        "Colour",
                        string.Format("{0}", colour)});
            table1.AddRow(new string[] {
                        "Wheel Size",
                        string.Format("{0}", wheelSize)});
#line 30
 testRunner.And("I see details on product page", ((string)(null)), table1, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify Item Details of water bottle product")]
        public virtual void VerifyItemDetailsOfWaterBottleProduct()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify Item Details of water bottle product", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 13
this.FeatureBackground();
#line 44
 testRunner.When("I enter \"Camelbak Podium Ice Water Bottle\" in the search text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
 testRunner.When("I click on product with name \"Camelbak Podium Ice Water Bottle\" from search resul" +
                    "ts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
 testRunner.Then("I see the product page for \"Camelbak Podium Ice Water Bottle\" is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Details",
                        "Value"});
            table2.AddRow(new string[] {
                        "Price",
                        "1293.99 RUB"});
            table2.AddRow(new string[] {
                        "Rating",
                        "4.1 / 5"});
            table2.AddRow(new string[] {
                        "Size",
                        "610ml"});
#line 50
 testRunner.And("I see details on product page", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify change options of products")]
        [NUnit.Framework.TestCaseAttribute("Vitus Bikes Sommet CR FS Bike - Carbon Sram X1 1x11 2017", "Frame Size", "43cm (17\")", null)]
        [NUnit.Framework.TestCaseAttribute("Camelbak Podium Ice Water Bottle", "Colour", "Snow", null)]
        [NUnit.Framework.TestCaseAttribute("100% Geico Honda Factory Hoodie", "Size", "S", null)]
        public virtual void VerifyChangeOptionsOfProducts(string name, string option, string value, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify change options of products", exampleTags);
#line 56
this.ScenarioSetup(scenarioInfo);
#line 13
this.FeatureBackground();
#line 58
 testRunner.When(string.Format("I enter \"{0}\" in the search text", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.When(string.Format("I click on product with name \"{0}\" from search results", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.Then(string.Format("I see the product page for \"{0}\" is loaded", name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
 testRunner.When(string.Format("I select option \"{0}\" on product page", value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Details",
                        "Value"});
            table3.AddRow(new string[] {
                        string.Format("{0}", option),
                        string.Format("{0}", value)});
#line 66
 testRunner.Then("I see new details on product page", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify Reviews summary of product")]
        [NUnit.Framework.TestCaseAttribute("Vitus Bikes Sommet CR FS Bike - Carbon Sram X1 1x11 2017", "8", "4.8 / 5", null)]
        [NUnit.Framework.TestCaseAttribute("Pedros Chain Pig Machine Kit", "4", "2.8 / 5", null)]
        public virtual void VerifyReviewsSummaryOfProduct(string product, string count, string rating, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify Reviews summary of product", exampleTags);
#line 76
this.ScenarioSetup(scenarioInfo);
#line 13
this.FeatureBackground();
#line 77
 testRunner.When(string.Format("I enter \"{0}\" in the search text", product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.When(string.Format("I click on product with name \"{0}\" from search results", product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.Then(string.Format("I see the product page for \"{0}\" is loaded", product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.When("I click on Read all reviews", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "Rating",
                        string.Format("{0}", rating)});
            table4.AddRow(new string[] {
                        "Reviews",
                        string.Format("{0} reviews", count)});
#line 85
 testRunner.Then("I see the following values in Ratings summary on product page", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify product without rating summary and reviewes")]
        [NUnit.Framework.TestCaseAttribute("Animal Bikes T1 BMX Tyre", null)]
        [NUnit.Framework.TestCaseAttribute("100% Geico Honda Factory Hoodie", null)]
        public virtual void VerifyProductWithoutRatingSummaryAndReviewes(string product, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify product without rating summary and reviewes", exampleTags);
#line 95
this.ScenarioSetup(scenarioInfo);
#line 13
this.FeatureBackground();
#line 96
 testRunner.When(string.Format("I enter \"{0}\" in the search text", product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.When(string.Format("I click on product with name \"{0}\" from search results", product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
 testRunner.Then(string.Format("I see the product page for \"{0}\" is loaded", product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 103
 testRunner.When("I scroll to description of product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
 testRunner.When("I click on Empty Reviews", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.Then("I don\'t see Ratings summary on product page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
 testRunner.And("I see Write A Review button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify open Size Chart for product")]
        [NUnit.Framework.TestCaseAttribute("Vitus Bikes Sommet CR FS Bike - Carbon Sram X1 1x11 2017", null)]
        [NUnit.Framework.TestCaseAttribute("100% Geico Honda Factory Hoodie", null)]
        public virtual void VerifyOpenSizeChartForProduct(string product, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify open Size Chart for product", exampleTags);
#line 113
this.ScenarioSetup(scenarioInfo);
#line 13
this.FeatureBackground();
#line 114
 testRunner.When(string.Format("I enter \"{0}\" in the search text", product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 115
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 118
 testRunner.When(string.Format("I click on product with name \"{0}\" from search results", product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
 testRunner.Then(string.Format("I see the product page for \"{0}\" is loaded", product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 121
 testRunner.When("I click Size Chart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 122
 testRunner.Then("I see chart is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

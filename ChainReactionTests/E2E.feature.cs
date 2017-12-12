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
    [NUnit.Framework.DescriptionAttribute("E2E")]
    [NUnit.Framework.CategoryAttribute("MyTag")]
    public partial class E2EFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "E2E.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "E2E", @"To make sure that the entire project works as one system and not just a set of features,
As a QA,
I want to be able to test scope of the features connected in one test.
A/C:
1. e2e tests including registration, logout, login, create wishlist, search, add to wishlist, remove from wishlist, delete wishlist", ProgrammingLanguage.CSharp, new string[] {
                        "MyTag"});
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
#line 9
#line 10
 testRunner.Given("I open browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.When("I navigate to the page \"http://www.chainreactioncycles.com/ru/en\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("I see the main page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.When("I click on RubRub dropdown and I select language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.And("I click Update button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.Then("I see the main page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("E2E test")]
        public virtual void E2ETest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("E2E test", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 19
 testRunner.When("I click on Sign In on top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("I see the Sign In page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.When("I click on Create Account button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("I see the Create Account page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.When("I add \"newestaccexamag+{{5::rnd}}@gmail.com\" value with \"email\" key to Scenario C" +
                    "ontext", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table1.AddRow(new string[] {
                        "first",
                        "test"});
            table1.AddRow(new string[] {
                        "last",
                        "test"});
            table1.AddRow(new string[] {
                        "email",
                        "{{email::context}}"});
            table1.AddRow(new string[] {
                        "confirmEmail",
                        "{{email::context}}"});
            table1.AddRow(new string[] {
                        "password",
                        "1231231234qwe"});
            table1.AddRow(new string[] {
                        "confirmPassword",
                        "1231231234qwe"});
#line 26
 testRunner.And("I set following parameters on Create Account page", ((string)(null)), table1, "And ");
#line 34
 testRunner.And("I click Apply button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.Then("I see My Account page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.When("I enter \"Bike Cave\" in the search text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.And("I see \"1\" items on search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("I see items name include \"Bike Cave\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.When("I enter \"Vitus Bikes Escarpe Suspension Bike - Deore 2017\" in the search text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 44
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.When("I click on product with name \"Vitus Bikes Escarpe Suspension Bike - Deore 2017\" f" +
                    "rom search results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("I see the product page for \"Vitus Bikes Escarpe Suspension Bike - Deore 2017\" is " +
                    "loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Details",
                        "Value"});
            table2.AddRow(new string[] {
                        "Price",
                        "87999.00 RUB"});
            table2.AddRow(new string[] {
                        "Rating",
                        "4.4 / 5"});
            table2.AddRow(new string[] {
                        "Colour",
                        "Blue - Orange"});
            table2.AddRow(new string[] {
                        "Wheel Size",
                        "27.5\" (650b)"});
#line 49
 testRunner.And("I see details on product page", ((string)(null)), table2, "And ");
#line 56
 testRunner.When("I click Size Chart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.Then("I see chart is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.When("I close Size Chart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("I see the product page for \"Vitus Bikes Escarpe Suspension Bike - Deore 2017\" is " +
                    "loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.When("I click on Read all reviews", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Rating",
                        "4.4 / 5"});
            table3.AddRow(new string[] {
                        "Reviews",
                        "7 reviews"});
#line 63
 testRunner.Then("I see the following values in Ratings summary on product page", ((string)(null)), table3, "Then ");
#line 68
 testRunner.When("I scroll to name of product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 69
 testRunner.When("I select option \"43cm (17\")\" on product page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Details",
                        "Value"});
            table4.AddRow(new string[] {
                        "Frame Size",
                        "43cm (17\")"});
#line 70
 testRunner.Then("I see new details on product page", ((string)(null)), table4, "Then ");
#line 74
 testRunner.When("I click Add To Wishlist button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.Then("I see select wishlist popup is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.When("I enter name of wishlist \"My Wishlist\" in the create text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.And("I click Create And Add To List button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.Then("I see \"Item added to wishlist\" message on wishlist popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 80
 testRunner.And("I click Close button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.When("I click Wishlist button on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.Then("I see \"1\" wishlists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.And("I see \"1\" items in wishlist with name \"My Wishlist\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.When("I click View List button on wishlist with name \"My Wishlist\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.Then("I see the wishlist page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Details",
                        "Value"});
            table5.AddRow(new string[] {
                        "Title",
                        "Vitus Bikes Escarpe Suspension Bike - Deore 2017"});
            table5.AddRow(new string[] {
                        "Price",
                        "From RUB87999.00"});
#line 88
 testRunner.And("I see details of goods in wishlist", ((string)(null)), table5, "And ");
#line 93
 testRunner.When("I click Logo on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 94
 testRunner.Then("I see the main page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
 testRunner.When("I click Logout button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 97
 testRunner.Then("I see the main page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
 testRunner.When("I click on Sign In on top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.Then("I see the Sign In page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table6.AddRow(new string[] {
                        "email",
                        "{{email::context}}"});
            table6.AddRow(new string[] {
                        "password",
                        "1231231234qwe"});
#line 102
 testRunner.When("I set following parameters on Sign In page", ((string)(null)), table6, "When ");
#line 106
 testRunner.And("I click Sign In button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.Then("I see the main page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 109
 testRunner.When("I click Wishlist button on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
 testRunner.Then("I see \"1\" wishlists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
 testRunner.And("I see \"1\" items in wishlist with name \"My Wishlist\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.When("I click View List button on wishlist with name \"My Wishlist\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 114
 testRunner.Then("I see the wishlist page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 115
 testRunner.And("I see \"1\" items in wishlist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.When("I click Remove button on item with name \"Vitus Bikes Escarpe Suspension Bike - De" +
                    "ore 2017\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 118
 testRunner.Then("I see empty wishlist with message \"YOU HAVE NO ITEMS ON YOUR WISH LIST.MY WISHLIS" +
                    "T\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 120
 testRunner.When("I enter \"Camelbak Podium Ice Water Bottle\" in the search text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 124
 testRunner.When("I click on product with name \"Camelbak Podium Ice Water Bottle\" from search resul" +
                    "ts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 125
 testRunner.Then("I see the product page for \"Camelbak Podium Ice Water Bottle\" is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Details",
                        "Value"});
            table7.AddRow(new string[] {
                        "Price",
                        "1293.99 RUB"});
            table7.AddRow(new string[] {
                        "Rating",
                        "4.2 / 5"});
            table7.AddRow(new string[] {
                        "Size",
                        "610ml"});
#line 126
 testRunner.And("I see details on product page", ((string)(null)), table7, "And ");
#line 132
 testRunner.When("I select option \"Electric Blue\" on product page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Details",
                        "Value"});
            table8.AddRow(new string[] {
                        "Colour",
                        "Electric Blue"});
#line 133
 testRunner.Then("I see new details on product page", ((string)(null)), table8, "Then ");
#line 137
 testRunner.When("I set \"3\" as quantity on item page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 138
 testRunner.And("I click Add To Basket button on item page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.Then("I see message \"ITEM ADDED TO BASKET\" in basket popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
 testRunner.And("I wait for \"5\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
 testRunner.When("I scroll to Basket on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 143
 testRunner.And("I click Basket button on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
 testRunner.Then("I see \"1\" items in basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Quantity",
                        "Price",
                        "Option"});
            table9.AddRow(new string[] {
                        "Camelbak Podium Ice Water Bottle",
                        "3",
                        "Now 1293.99RUB",
                        "Electric Blue, 610ml"});
#line 145
 testRunner.Then("I see following items in basket", ((string)(null)), table9, "Then ");
#line 148
 testRunner.And("I see \"3881.97RUB\" subtotal cost on basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
 testRunner.When("I click Continue Shopping button on basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 151
 testRunner.Then("I see the main page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 153
 testRunner.When("I enter \"Animal Bikes T1 BMX Tyre\" in the search text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 154
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 157
 testRunner.When("I select \"Black, 20\", 2.4\"\" option in item dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 158
 testRunner.And("I click Buy button on item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
 testRunner.Then("I see message \"ITEM ADDED TO BASKET\" in basket popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 160
 testRunner.And("I wait for \"5\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 162
 testRunner.When("I scroll to Basket on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 163
 testRunner.And("I click Basket button on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
 testRunner.Then("I see \"2\" items in basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Quantity",
                        "Price",
                        "Option"});
            table10.AddRow(new string[] {
                        "Animal Bikes T1 BMX Tyre",
                        "1",
                        "Now 2517.99RUB",
                        "Black, 20\", 2.4\","});
            table10.AddRow(new string[] {
                        "Camelbak Podium Ice Water Bottle",
                        "3",
                        "Now 1293.99RUB",
                        "Electric Blue, 610ml"});
#line 165
 testRunner.And("I see following items in basket", ((string)(null)), table10, "And ");
#line 169
 testRunner.And("I see \"6399.96RUB\" subtotal cost on basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 171
 testRunner.When("I click Remove button on item in basket with name \"Camelbak Podium Ice Water Bott" +
                    "le\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 172
 testRunner.Then("I see \"1\" items in basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Quantity",
                        "Price",
                        "Option"});
            table11.AddRow(new string[] {
                        "Animal Bikes T1 BMX Tyre",
                        "1",
                        "Now 2517.99RUB",
                        "Black, 20\", 2.4\","});
#line 173
 testRunner.And("I see following items in basket", ((string)(null)), table11, "And ");
#line 176
 testRunner.And("I see \"2517.99RUB\" subtotal cost on basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 178
 testRunner.When("I click Remove button on item in basket with name \"Animal Bikes T1 BMX Tyre\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 179
 testRunner.Then("I see the \"There are no items in your basket.\" message on the basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 180
 testRunner.And("I see \"0.00RUB\" subtotal cost on basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

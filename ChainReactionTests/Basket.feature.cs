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
    [NUnit.Framework.DescriptionAttribute("Basket")]
    public partial class BasketFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Basket.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Basket", @"To be able to buy something in the store and get the entire cost for my products,
As a customer,
I want to be able to Add/Remove items to basket
A/C:
1. I can add to basket
1.1 If there is an item in my basket, I can see it's name, price, selected option and amount of copies of this item.
1.2 If there are several items in my basket, I can see all these items, their amount and cost (for each item and total).
2. I can delete items from basket
3. If there are no items in it I see ""There are no items in your basket."" message
4. If basket isn't empty I can operate it using popup", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 22
 testRunner.When("I click on Sign In on top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("I see the Sign In page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table1.AddRow(new string[] {
                        "email",
                        "otbtguukb@emltmp.com"});
            table1.AddRow(new string[] {
                        "password",
                        "123123123"});
#line 25
 testRunner.When("I set following parameters on Sign In page", ((string)(null)), table1, "When ");
#line 29
 testRunner.And("I click Sign In button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.Then("I see the main page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
 testRunner.When("I click Basket button on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.Then("I make sure that basket is empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.When("I click Wishlist button on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then("I make sure that exist wishlist with name \"My Wishlist\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify see an empty basket")]
        public virtual void VerifySeeAnEmptyBasket()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify see an empty basket", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line 13
this.FeatureBackground();
#line 40
 testRunner.When("I click Basket button on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("I see the basket page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
 testRunner.And("I see the \"There are no items in your basket.\" message on the basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify add goods in basket from seach page")]
        public virtual void VerifyAddGoodsInBasketFromSeachPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify add goods in basket from seach page", ((string[])(null)));
#line 44
this.ScenarioSetup(scenarioInfo);
#line 13
this.FeatureBackground();
#line 45
 testRunner.When("I enter \"Camelbak Podium Ice Water Bottle\" in the search text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.When("I select \"Cosmic Blue, 610ml\" option in item dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.And("I click Buy button on item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.Then("I see message \"ITEM ADDED TO BASKET\" in basket popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.When("I click Basket button on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("I see \"1\" items in basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Quantity",
                        "Price",
                        "Option"});
            table2.AddRow(new string[] {
                        "Camelbak Podium Ice Water Bottle",
                        "1",
                        "Now 909.49RUB",
                        "Electric Blue, 610ml"});
#line 55
 testRunner.And("I see following items in basket", ((string)(null)), table2, "And ");
#line 58
 testRunner.And("I see \"909.49RUB\" subtotal cost on basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify add goods with different quantity in basket")]
        public virtual void VerifyAddGoodsWithDifferentQuantityInBasket()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify add goods with different quantity in basket", ((string[])(null)));
#line 60
this.ScenarioSetup(scenarioInfo);
#line 13
this.FeatureBackground();
#line 61
 testRunner.When("I enter \"Camelbak Podium Ice Water Bottle\" in the search text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
 testRunner.When("I click on product with name \"Camelbak Podium Ice Water Bottle\" from search resul" +
                    "ts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.Then("I see the product page for \"Camelbak Podium Ice Water Bottle\" is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.When("I select option \"Snow\" on product page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Details",
                        "Value"});
            table3.AddRow(new string[] {
                        "Colour",
                        "Snow"});
#line 69
 testRunner.Then("I see new details on product page", ((string)(null)), table3, "Then ");
#line 73
 testRunner.When("I set \"3\" as quantity on item page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
 testRunner.And("I click Add To Basket button on item page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.Then("I see message \"ITEM ADDED TO BASKET\" in basket popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.When("I click Basket button on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.Then("I see \"1\" items in basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Quantity",
                        "Price",
                        "Option"});
            table4.AddRow(new string[] {
                        "Camelbak Podium Ice Water Bottle",
                        "3",
                        "Now 1468.49RUB",
                        "Snow, 610ml"});
#line 79
 testRunner.Then("I see following items in basket", ((string)(null)), table4, "Then ");
#line 82
 testRunner.And("I see \"4405.47RUB\" subtotal cost on basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify add goods in basket from wishlist")]
        public virtual void VerifyAddGoodsInBasketFromWishlist()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify add goods in basket from wishlist", ((string[])(null)));
#line 84
this.ScenarioSetup(scenarioInfo);
#line 13
this.FeatureBackground();
#line 85
 testRunner.When("I enter \"Animal Bikes T1 BMX Tyre\" in the search text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
 testRunner.When("I click on product with name \"Animal Bikes T1 BMX Tyre\" from search results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.Then("I see the product page for \"Animal Bikes T1 BMX Tyre\" is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
 testRunner.When("I click Add To Wishlist button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
 testRunner.Then("I see add to wishlist popup is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
 testRunner.When("I choose good with option \"2.4\" and click Add To Wishlist button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
 testRunner.Then("I see select wishlist popup is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
 testRunner.When("I select wishlist with name \"My Wishlist\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.And("I click Add To List button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.Then("I see \"Item added to wishlist\" message on wishlist popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.And("I click Close button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.When("I click Wishlist button on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
 testRunner.Then("I see the wishlist page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 105
 testRunner.And("I see \"1\" wishlists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.When("I click View List button on wishlist with name \"My Wishlist\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 108
 testRunner.Then("I see the wishlist page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
 testRunner.When("I click Add To Basket button for item \"Animal Bikes T1 BMX Tyre\" on wishlist page" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 111
 testRunner.Then("I see empty wishlist with message \"YOU HAVE NO ITEMS ON YOUR WISH LIST.MY WISHLIS" +
                    "T\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 113
 testRunner.When("I click Basket button on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 114
 testRunner.Then("I see \"1\" items in basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Quantity",
                        "Price",
                        "Option"});
            table5.AddRow(new string[] {
                        "Animal Bikes T1 BMX Tyre",
                        "1",
                        "Now 2517.99RUB",
                        "Black, 20\", 2.4\","});
#line 115
 testRunner.And("I see following items in basket", ((string)(null)), table5, "And ");
#line 118
 testRunner.And("I see \"2517.99RUB\" subtotal cost on basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify add a few goods in basket with continue shopping")]
        public virtual void VerifyAddAFewGoodsInBasketWithContinueShopping()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify add a few goods in basket with continue shopping", ((string[])(null)));
#line 120
this.ScenarioSetup(scenarioInfo);
#line 13
this.FeatureBackground();
#line 122
 testRunner.When("I enter \"Animal Bikes T1 BMX Tyre\" in the search text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 123
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 126
 testRunner.When("I click on product with name \"Animal Bikes T1 BMX Tyre\" from search results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 127
 testRunner.Then("I see the product page for \"Animal Bikes T1 BMX Tyre\" is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 129
 testRunner.When("I select option \"2.4\"\" on product page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Details",
                        "Value"});
            table6.AddRow(new string[] {
                        "Width",
                        "2.4\""});
#line 130
 testRunner.Then("I see new details on product page", ((string)(null)), table6, "Then ");
#line 134
 testRunner.When("I click Add To Basket button on item page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
 testRunner.Then("I see message \"ITEM ADDED TO BASKET\" in basket popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 137
 testRunner.When("I click Basket button on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 138
 testRunner.Then("I see \"1\" items in basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
 testRunner.When("I click Continue Shopping button on basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 141
 testRunner.Then("I see the main page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 143
 testRunner.When("I enter \"Camelbak Podium Ice Water Bottle\" in the search text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 144
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 147
 testRunner.When("I click on product with name \"Camelbak Podium Ice Water Bottle\" from search resul" +
                    "ts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 148
 testRunner.Then("I see the product page for \"Camelbak Podium Ice Water Bottle\" is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 150
 testRunner.When("I select option \"Electric Blue\" on product page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Details",
                        "Value"});
            table7.AddRow(new string[] {
                        "Colour",
                        "Electric Blue"});
#line 151
 testRunner.Then("I see new details on product page", ((string)(null)), table7, "Then ");
#line 155
 testRunner.When("I click Add To Basket button on item page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 156
 testRunner.Then("I see message \"ITEM ADDED TO BASKET\" in basket popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 158
 testRunner.When("I click Basket button on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 159
 testRunner.Then("I see \"2\" items in basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Quantity",
                        "Price",
                        "Option"});
            table8.AddRow(new string[] {
                        "Animal Bikes T1 BMX Tyre",
                        "1",
                        "Now 2517.99RUB",
                        "Black, 20\", 2.4\","});
            table8.AddRow(new string[] {
                        "Camelbak Podium Ice Water Bottle",
                        "1",
                        "Now 909.49RUB",
                        "Electric Blue, 610ml"});
#line 160
 testRunner.And("I see following items in basket", ((string)(null)), table8, "And ");
#line 164
 testRunner.And("I see \"3427.48RUB\" subtotal cost on basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify delete goods from basket")]
        public virtual void VerifyDeleteGoodsFromBasket()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify delete goods from basket", ((string[])(null)));
#line 167
this.ScenarioSetup(scenarioInfo);
#line 13
this.FeatureBackground();
#line 168
 testRunner.When("I enter \"Camelbak Podium Ice Water Bottle\" in the search text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 169
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 170
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 172
 testRunner.When("I select \"Electric Blue, 610ml\" option in item dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 173
 testRunner.And("I click Buy button on item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 174
 testRunner.Then("I see message \"ITEM ADDED TO BASKET\" in basket popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 176
 testRunner.When("I click Basket button on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 177
 testRunner.Then("I see \"1\" items in basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 179
 testRunner.When("I click Continue Shopping button on basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 180
 testRunner.Then("I see the main page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 182
 testRunner.When("I enter \"Animal Bikes T1 BMX Tyre\" in the search text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 183
 testRunner.And("I click Search button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 184
 testRunner.Then("I see the search page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 186
 testRunner.When("I select \"Black, 20\", 2.4\"\" option in item dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 187
 testRunner.And("I click Buy button on item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 188
 testRunner.Then("I see message \"ITEM ADDED TO BASKET\" in basket popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 190
 testRunner.When("I click Basket button on Top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 191
 testRunner.Then("I see the basket page is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 192
 testRunner.And("I see \"2\" items in basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Quantity",
                        "Price",
                        "Option"});
            table9.AddRow(new string[] {
                        "Camelbak Podium Ice Water Bottle",
                        "1",
                        "Now 909.49RUB",
                        "Electric Blue, 610ml"});
            table9.AddRow(new string[] {
                        "Animal Bikes T1 BMX Tyre",
                        "1",
                        "Now 2517.99RUB",
                        "Black, 20\", 2.4\","});
#line 193
 testRunner.And("I see following items in basket", ((string)(null)), table9, "And ");
#line 197
 testRunner.And("I see \"3427.48RUB\" subtotal cost on basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 199
 testRunner.When("I click Remove button on item in basket with name \"Camelbak Podium Ice Water Bott" +
                    "le\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 200
 testRunner.Then("I see \"1\" items in basket", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line 201
 testRunner.And("I see following items in basket", ((string)(null)), table10, "And ");
#line 204
 testRunner.And("I see \"2517.99RUB\" subtotal cost on basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 206
 testRunner.When("I click Remove button on item in basket with name \"Animal Bikes T1 BMX Tyre\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 207
 testRunner.Then("I see the \"There are no items in your basket.\" message on the basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 208
 testRunner.And("I see \"0.00RUB\" subtotal cost on basket page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

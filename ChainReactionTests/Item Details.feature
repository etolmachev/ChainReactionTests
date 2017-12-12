﻿Feature: Item Details
	To have a better idea about each product,
	As a customer,
	I want to have a page with details information about selected product, such as rating, price, etc.
A/C:
1. There is a page with description and the following details for each item:
	Name,
	Rating,
	Price,
	Color,
	Model/Size 

Background: 
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded

Scenario Template: Verify Item Details of bike product

	When I enter "<Name>" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "<Name>" from search results
	Then I see the product page for "<Name>" is loaded
	And I see details on product page
		| Details    | Value       |
		| Price      | <Price>     |
		| Rating     | <Rating>    |
		| Colour     | <Colour>    |
		| Wheel Size | <WheelSize> |

	Scenarios: 
		| Name                                                     | Price         | Rating  | Colour       | WheelSize    |
		| Vitus Bikes Sommet CR FS Bike - Carbon Sram X1 1x11 2017 | 138999.00 RUB | 4.8 / 5 | Black - Grey | 27.5" (650b) |
		| Nukeproof Mega 275 Comp Bike 2018                        | 140000.00 RUB  | 4.5 / 5 | Red - Silver | 27.5" (650b)|

	@MyFailTag 
Scenario: Verify Item Details of water bottle product

	When I enter "Camelbak Podium Ice Water Bottle" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Ice Water Bottle" from search results
	Then I see the product page for "Camelbak Podium Ice Water Bottle" is loaded
	And I see details on product page
	| Details | Value       |
	| Price   | 1293.99 RUB |
	| Rating  | 4.1 / 5     |
	| Size    | 610ml       |

Scenario Template: Verify change options of products

	When I enter "<Name>" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "<Name>" from search results
	Then I see the product page for "<Name>" is loaded

	When  I select option "<Value>" on product page
	Then I see new details on product page
		| Details  | Value    |
		| <Option> | <Value>  |

	Scenarios: 
		| Name                                                     | Option     | Value      |
		| Vitus Bikes Sommet CR FS Bike - Carbon Sram X1 1x11 2017 | Frame Size | 43cm (17") |
		| Camelbak Podium Ice Water Bottle                         | Colour     | Snow       |
		| 100% Geico Honda Factory Hoodie                          | Size       | S          |

Scenario Template: Verify Reviews summary of product
	When I enter "<Product>" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "<Product>" from search results
	Then I see the product page for "<Product>" is loaded
	
	When I click on Read all reviews 
	Then I see the following values in Ratings summary on product page
		| Field   | Value           |
		| Rating | <Rating>         |
		| Reviews | <Count> reviews |

	Scenarios: 
		| Product                                                  | Count | Rating  |
		| Vitus Bikes Sommet CR FS Bike - Carbon Sram X1 1x11 2017 | 8     | 4.8 / 5 |
		| Pedros Chain Pig Machine Kit                             | 4     | 2.8 / 5 |
	 
Scenario Template: Verify product without rating summary and reviewes
	When I enter "<Product>" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "<Product>" from search results
	Then I see the product page for "<Product>" is loaded

	When I scroll to description of product
	When I click on Empty Reviews 
	Then I don't see Ratings summary on product page
	And I see Write A Review button

	Scenarios: 
		| Product                         |
		| Animal Bikes T1 BMX Tyre        |
		| 100% Geico Honda Factory Hoodie |

Scenario Template: Verify open Size Chart for product
	When I enter "<Product>" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "<Product>" from search results
	Then I see the product page for "<Product>" is loaded

	When I click Size Chart
	Then I see chart is opened 

	Scenarios: 
		| Product                                                  |
		| Vitus Bikes Sommet CR FS Bike - Carbon Sram X1 1x11 2017 |
		| 100% Geico Honda Factory Hoodie                          |
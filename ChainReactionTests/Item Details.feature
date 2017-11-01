Feature: Item Details
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
		| Name                          | Price         | Rating | Colour                    | WheelSize    |
		| Vitus Bikes Sommet CR FS Bike | 138999.00 RUB | 4.3    | Black - Grey              | 27.5" (650b) |
		| Nukeproof Mega 290 Factory    | 225000.00 RUB | 0      | Desert Camo Brown - Olive | 29"          |

Scenario: Verify Item Details of water bottle product

	When I enter "<Name>" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "<Name>" from search results
	Then I see the product page for "<Name>" is loaded
	And I see details on product page
	| Details | Value   |
	| Price   | <Price> |
	| Rating  | <Rating> |
	| Size    |  <Size>  |

	Scenarios:
	| Name                             | Price                    | Rating | Size  |
	| camelbak podium bottle 710ml     | 489.49                   | 4.7    | 710ml |
	| Camelbak Podium Ice Water Bottle | 909.49 RUB - 1258.49 RUB | 4.3    | 610ml |

Scenario Template: Verify change options of products

	When I enter "<Name>" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "<Name>" from search results
	Then I see the product page for "<Name>" is loaded

	When I select option "<Option>" with value "<Value>" on product page
	And I see details on product page
		| Details  | Value    |
		| <Option> | <Value>  |

	Scenarios: 
		| Name                                        | Option     | Value        |
		| Vitus Bikes Sommet CR FS Bike               | frame size | 48cm (19")   |
		| camelbak podium bottle 710ml                | colour     | Clear Carbon |
		| Gore Bike Wear Element Urban GWS Hoody AW17 | size       | M            |

Scenario Template: Verify Reviews summary of product
	When I enter "<Product>" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "<Product>" from search results
	Then I see the product page for "<Product>" is loaded
	
	When I click "Customer Reviews (<Count>)"
	Then I see the following values in Ratings summary on product page
		| Field   | Value           |
		| Raiting | 4.7 / 5         |
		| Reviews | <Count> reviews |

	Scenarios: 
		| Product                       | Count |
		| Vitus Bikes Sommet CR FS Bike | 3     |
		| Pedros Chain Pig Machine Kit  | 4     |
	 
Scenario Template: Verify product without rating summary and reviewes
	When I enter "<Product>" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "<Product>" from search results
	Then I see the product page for "<Product>" is loaded

	When I click "Customer Reviews (0)"
	Then I don't see Ratings summary on product page
	And I see Write A Review button

	Scenarios: 
		| Product                                     |
		| Animal Bikes T1 BMX Tyre                    |
		| Gore Bike Wear Element Urban GWS Hoody AW17 |

Scenario Template: Verify open Size Chart for product
	When I enter "<Product>" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "<Product>" from search results
	Then I see the product page for "<Product>" is loaded

	When I click Size Chart
	Then I see chart is opened 

	Scenarios: 
		| Product                                     |
		| Vitus Bikes Sommet CR FS Bike               |
		| Gore Bike Wear Element Urban GWS Hoody AW17 |
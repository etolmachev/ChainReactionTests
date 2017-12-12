Feature: Extended Search
	To have a quick way to find products matching my specific needs,
As a customer,
I want to be able to filter search by number of criteria (Brand, Gender, Price, etc.).
A/C:
1. I have extended search on search page
2. I can filter my search results by Brand, Gender, Price etc (one filter, some of these filters or all filters).
3. If no results found, I should see message "no results found"
4. Only valid results should be shown
4.1 Items not matching specified search criteria are NOT listed.

Background: 
Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded

Scenario Template: Verify search with option Gender
	
	When I enter "<Product>" in the search text
	And I click Search button
	Then I see the search page is loaded
	And I see "<Result> results for '<Product>'" message on search page

	When I click gender "<Gender>" on search page
	Then I see "<Count> results for '<Product>'" message on search page

	Scenarios: 
	| Product | Gender | Result | Count |
	| bike    | Male   | 1272   | 516   |
	| Jacket  | Female | 315    | 97    |

Scenario Template: Verify search with option Gender and Brand

	When I enter "<Product>" in the search text
	And I click Search button
	Then I see the search page is loaded
	And I see "<Result> results for '<Product>'" message on search page

	When I click gender "<Gender>" on search page
	Then I see "<CountGender> results for '<Product>'" message on search page

	When I click brand "<Brand>" on search page
	Then I see "<CountBrand> results for '<Product>'" message on search page

	And I see "<CountBrand>" items on search page
	And I see items name include "<Brand>"

	Scenarios: 
	| Product | Gender | Result | CountGender | Brand      | CountBrand |
	| bike    | Male   | 1272   | 516         | Colnago    | 4          |
	| JaCKet  | Female | 315    | 97          | Fox Racing | 2          |
	| COM     | Male   | 121    | 61          | Ergon      | 4          |

Scenario Template:  Verify search with three options
	
	When I enter "<Product>" in the search text
	And I click Search button
	Then I see the search page is loaded
	And I see "<Result> results for '<Product>'" message on search page

	When I click gender "<Gender>" on search page
	Then I see "<CountGender> results for '<Product>'" message on search page

	When I click brand "<Brand>" on search page
	Then I see "<CountBrand> results for '<Product>'" message on search page

	And I see "<CountBrand>" items on search page
	And I see items name include "<Brand>"

	When I click colour "<Colour>" on search page
	Then I see "<CountColour> results for '<Product>'" message on search page
	And I see "<CountColour>" items on search page
	And I see items include colour "<Colour>"

	Scenarios: 
	| Product | Gender | Result | CountGender | Brand      | CountBrand | Colour | CountColour |
	| bike    | Male   | 1272   | 516         | Dawes      | 6          | Blue   | 2           |
	| JaCKet  | Female | 315    | 97          | Fox Racing | 2          | Black  | 1           |

Scenario Template:  Verify find 0 items with incorrect option Price
	
	When I enter "<Product>" in the search text
	And I click Search button
	Then I see the search page is loaded
	And I see "<Result> results for '<Product>'" message on search page

	When I click gender "<Gender>" on search page
	Then I see "<CountGender> results for '<Product>'" message on search page

	When I click brand "<Brand>" on search page
	Then I see "<CountBrand> results for '<Product>'" message on search page
	And I see "<CountBrand>" items on search page
	And I see items name include "<Brand>"

	When I click colour "<Colour>" on search page
	Then I see "<CountColour> results for '<Product>'" message on search page
	And I see "<CountColour>" items on search page
	And I see items include colour "<Colour>"

	When I enter price from "<From>" to "<To>" on search page and click Go button
	Then I see message "No products found – please change your price range" after filter on search page

	Scenarios: 
	| Product | Gender | Result | CountGender | Brand      | CountBrand | Colour | CountColour | From | To   |
	| bike    | Male   | 1272   | 516         | Dawes      | 6          | Blue   | 2           | 1000 | 1500 |
	| JaCKet  | Female | 315    | 97          | Fox Racing | 2          | Black  | 1           | 5000 | 8000 |

	@MyTag
Scenario Template:  Verify delete option from filter
	
	When I enter "<Product>" in the search text
	And I click Search button
	Then I see the search page is loaded
	And I see "<Result> results for '<Product>'" message on search page

	When I click gender "<Gender>" on search page
	Then I see "<CountGender> results for '<Product>'" message on search page

	When I click brand "<Brand>" on search page
	Then I see "<CountBrand> results for '<Product>'" message on search page
	And I see "<CountBrand>" items on search page
	And I see items name include "<Brand>"

	When I click colour "<Colour>" on search page
	Then I see "<CountColour> results for '<Product>'" message on search page
	And I see "<CountColour>" items on search page
	And I see items include colour "<Colour>"

	When I enter price from "<From>" to "<To>" on search page and click Go button
	Then I see message "No products found – please change your price range" after filter on search page

	When I delete price from filter
	Then I see "<CountColour> results for '<Product>'" message on search page

	When I delete colour from filter
	Then I see "<CountBrand> results for '<Product>'" message on search page
	And I see "<CountBrand>" items on search page
	And I see items name include "<Brand>"

	When I delete option "<Brand>" from filter
	Then I see "<CountGender> results for '<Product>'" message on search page

	When I delete option "<Gender>" from filter
	Then I see "<Result> results for '<Product>'" message on search page

	Scenarios: 
	| Product | Gender | Result | CountGender | Brand      | CountBrand | Colour | CountColour | From | To   |
	| bike    | Male   | 1272   | 516         | Dawes      | 6          | Blue   | 2           | 1000 | 1500 |
	| JaCKet  | Female | 315    | 97          | Fox Racing | 2          | Black  | 1           | 5000 | 8000 |


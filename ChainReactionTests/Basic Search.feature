Feature: Basic Search

Background: 
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded

Scenario: Verify search by name of goods

	When I enter "bike" in the search text
	And I click Search button
	Then I see the search page is loaded
	And I see "1184 results for 'bike'" message on search page

Scenario: Verify equal names of search text and result text

	When I enter "Bike Cave" in the search text
	And I click Search button
	Then I see the search page is loaded
	And I see "1" items on search page
	And I see items name include "Bike Cave"

Scenario: Verify result for nonexisten goods

	When I enter "auto and shirt" in the search text
	And I click Search button
	Then I see the empty search page is loaded
	And I see "0" message on search page for ""auto and shirt""

Scenario: Verify search by product attribute

	When I enter "123" in the search text
	And I click Search button
	Then I see the search page is loaded
	And I see "1" items on search page
	And I dont see items name include "123"
	And I see items name include "Cube Hanger"

#------------

Scenario Template: Verify equal names of search text and result text - by name
	When I enter "<SearchValue>" in the search text
	And I click Search button
	Then I see the search page is loaded
	And I see "<Amount> results for '<SearchValue>'" message on search page

	And I see "<Amount>" items on search page
	And I see items name include "<ResultValue>"

	Scenarios: 
		| SearchValue | Amount | ResultValue |
		| animal bike | 17     | Animal Bike |
		| ANIMAL BikE | 17     | Animal Bike |
		|   auto      |   3    |      Auto   |

#Need to implement
Scenario Template: Verify equal names of search text and result text - by category
	When I enter "<SearchValue>" in the search text
	And I click Search button
	Then I see the search page is loaded
	And I see "<ResultValue>" on search page

	And I see "<Amount>" items on search page
	And I see items name include "<ResultValue>"

	Scenarios: 
		| SearchValue | Amount | ResultValue |
		| Bike Cave   | 2      | Bike Cave   |
		| BiKE CavE   | 2      | Bike Cave   |


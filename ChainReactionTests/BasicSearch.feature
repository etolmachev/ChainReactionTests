Feature: BasicSearch

@mytag
Scenario: Verify search by name of goods
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded

	When I enter "bike" in the search text
	And I click Search button
	Then I see the search page is loaded
	And I see "1183 results for 'bike'" message on search page

Scenario: Verify matching all goods in result
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded

	When I enter "Bike Cave" in the search text
	And I click Search button
	Then I see the search page is loaded
	And I see "2" items on search page

Scenario: Verify result for nonexisten goods
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded

	When I enter "auto and shirt" in the search text
	And I click Search button
	Then I see the search page is loaded
	And I see "0 results for "auto and shirt"" message on search page

Scenario: Verify equal names of search text and result text
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded

	When I enter "Bike Cave" in the search text
	And I click Search button
	Then I see the search page is loaded
	And I see "2" items on search page
	And I see items name include "Bike Cave"



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

Scenario: Verify search with option Gender
	


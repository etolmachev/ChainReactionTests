Feature: Basket
To be able to buy something in the store and get the entire cost for my products,
As a customer,
I want to be able to Add/Remove items to basket
A/C:
1. I can add to basket
1.1 If there is an item in my basket, I can see it's name, price, selected option and amount of copies of this item.
1.2 If there are several items in my basket, I can see all these items, their amount and cost (for each item and total).
2. I can delete items from basket
3. If there are no items in it I see "There are no items in your basket." message
4. If basket isn't empty I can operate it using popup

Background: 
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded
	
	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I set following parameters on Sign In page
		| Name     | Value                |
		| email    | otbtguukb@emltmp.com |
		| password | 123123123            |
	And I click Sign In button
	Then I see the main page is loaded

Scenario: Open Basket 
	When I click Basket button
	Then I see the basket page is loaded

Scenario: Hover to basket with items
	When I hover to Basket button
	Then I see basket popup is open
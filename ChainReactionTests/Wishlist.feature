Feature: Wishlist
To be able to save preferable products which I want to buy in the nearest future,
As a customer,
I want to be able to Create/Edit/Delete Wishlist to store such products there.
A/C:
	1.I can create wishlist (I can see it in my profile and can add some product in it)
	2.I can delete existing wishlist (I can't see it in my profile)
	3.I can see list of my wishlists

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

#given account without wishlist
Scenario: Verify see an empty list of wishilist
	When I click Wishilist button
	Then I see empty list of wishilist

#given account without wishlist
Scenario: Verify unable to add good in nonexisten wishlist
	When I enter "Camelbak Podium Bottle 710ml" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Bottle 710ml" from search results
	Then I see the product page for "Camelbak Podium Bottle 710ml" is loaded

	When I click Add To Wishilist button
	Then I see add to wishlist popup

	When I choose good and click Add To Wishlist button
	Then I see select wishlist popup

	When I click Add To List button
	Then I see "Please enter wish list name." message on wishlist popup

#given account without wishlist
Scenario: Verify create new wishlist
	When I enter "Camelbak Podium Bottle 710ml" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Bottle 710ml" from search results
	Then I see the product page for "Camelbak Podium Bottle 710ml" is loaded

	When I click Add To Wishilist button
	Then I see add to wishlist popup

	When I choose good and click Add To Wishlist button
	Then I see select wishlist popup

	When I enter name of wishlist "My Wishlist" in the create text
	And I click Create And Add To List button
	Then I see "Item added to wishlist" message on wishlist popup
	And I click Close button

	When I click Wishilist button
	Then I see my wishlist without items

#given account with 1 wishlist
Scenario: Verify add good in wishlist
	When I enter "Camelbak Podium Bottle 710ml" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Bottle 710ml" from search results
	Then I see the product page for "Camelbak Podium Bottle 710ml" is loaded

	When I click Add To Wishilist button
	Then I see add to wishlist popup

	When I choose good and click Add To Wishlist button
	Then I see wishlist popup

	When I select wishlist with name "My Wishlist"
	And I click Add To List button
	Then I see "Item added to wishlist" message on wishlist popup
	And I click Close button

	When I click Wishilist button
	Then I see list with names of wishilist
	And I see "1" item in wishlist with name "My Wishlist"

#given account with 2 wishlists
Scenario: Verify select wishlist to add new good

	When I enter "Camelbak Podium Bottle 710ml" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Bottle 710ml" from search results
	Then I see the product page for "Camelbak Podium Bottle 710ml" is loaded

	When I click Add To Wishilist button
	Then I see add to wishlist popup

	When I choose good and click Add To Wishlist button
	Then I see select wishlist popup

	When I enter name of wishlist "Second Wishlist" in the create text
	And I click Create And Add To List button
	Then I see "Item added to wishlist" message on wishlist popup
	And I click Close button
	Then I see the product page for "Camelbak Podium Bottle 710ml" is loaded

	When I click Wishilist button
	Then I see list with names of wishilist
	And I see "1" item in wishlist with name "Second Wishlist"

#given account with 1 wishlist
Scenario: Verify see details of goods in wishlist
	When I enter "Camelbak Podium Bottle 710ml" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Bottle 710ml" from search results
	Then I see the product page for "Camelbak Podium Bottle 710ml" is loaded

	When I click Add To Wishilist button
	Then I see add to wishlist popup

	When I choose good and click Add To Wishlist button
	Then I see wishlist popup

	When I select wishlist with name "My Wishlist"
	And I click Add To List button
	Then I see "Item added to wishlist" message on wishlist popup
	And I click Close button

	When I click Wishilist button
	Then I see list with names of wishilist
	And I see "1" item in wishlist with name "My Wishlist"

	When I click View List button on wishlist with name "My Wishlist"
	Then I see wishlist page is loaded
	And I see details of goods in wishlist
	| Details | Value                        |
	| Title   | Camelbak Podium Bottle 710ml |
	| Quanity | 1                            |

#given account with 1 wishlist
Scenario: Verify delete wishilist

	When I click Wishilist button
	Then I see list of wishilist

	When I click Delete button on wishlist with name "My Wishlist"
	Then I see empty list of wishilist

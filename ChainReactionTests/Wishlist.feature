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

#given account without wishlist
Scenario: Verify see an empty list of wishilist
	When I set following parameters on Sign In page
		| Name     | Value                |
		| email    | onlnnqbg@yomail.info |
		| password | 1234567890           |
	And I click Sign In button
	Then I see the main page is loaded

	When I click Wishlist button on Top menu
	Then I see the wishlist page is loaded
	Then I see empty list of wishlist with message "YOU HAVE NO ITEMS ON YOUR WISH LIST"

#given account without wishlist
Scenario: Verify unable to add good in nonexisten wishlist
	When I set following parameters on Sign In page
		| Name     | Value                |
		| email    | onlnnqbg@yomail.info |
		| password | 1234567890           |
	And I click Sign In button
	Then I see the main page is loaded

	When I enter "Camelbak Podium Ice Water Bottle" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Ice Water Bottle" from search results
	Then I see the product page for "Camelbak Podium Ice Water Bottle" is loaded

	When I click Add To Wishlist button
	Then I see add to wishlist popup is loaded
	Then I wait for "1" seconds

	When I choose good with option "Snow" and click Add To Wishlist button
	Then I see select wishlist popup is loaded

	When I click Add To List button
	Then I wait for "1" seconds
	Then I see "Please enter wish list name." message on wishlist popup

#given account without wishlist
Scenario: Verify create new wishlist
	When I set following parameters on Sign In page
		| Name     | Value                |
		| email    | onlnnqbg@yomail.info |
		| password | 1234567890           |
	And I click Sign In button
	Then I see the main page is loaded

	When I enter "Camelbak Podium Ice Water Bottle" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Ice Water Bottle" from search results
	Then I see the product page for "Camelbak Podium Ice Water Bottle" is loaded

	When I click Add To Wishlist button
	Then I see add to wishlist popup is loaded
	Then I wait for "1" seconds

	When I choose good with option "Snow" and click Add To Wishlist button
	Then I see select wishlist popup is loaded

	When I enter name of wishlist "My Wishlist" in the create text
	And I click Create And Add To List button
	Then I see "Item added to wishlist" message on wishlist popup
	And I click Close button
	Then I wait for "1" seconds

	When I click Wishlist button on Top menu
	Then I see my wishlist with "1" items

	When I click Delete button on wishlist with name "My Wishlist"
	Then I wait for "1" seconds
	When I click Confirm button

#given account with 1 wishlist
Scenario: Verify add good in wishlist
	When I set following parameters on Sign In page
		| Name     | Value               |
		| email    | qvxzkgmj@emlhub.com |
		| password | 1234rewq            |
	And I click Sign In button
	Then I see the main page is loaded

	When I enter "Camelbak Podium Ice Water Bottlel" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Ice Water Bottle" from search results
	Then I see the product page for "Camelbak Podium Ice Water Bottle" is loaded

	When I click Add To Wishlist button
	Then I see add to wishlist popup is loaded
	Then I wait for "1" seconds

	When I choose good with option "Snow" and click Add To Wishlist button
	Then I see select wishlist popup is loaded

	When I select wishlist with name "My Wishlist"
	And I click Add To List button
	Then I see "Item added to wishlist" message on wishlist popup
	And I click Close button
	Then I wait for "1" seconds

	When I click Wishlist button on Top menu
	Then I see "1" wishlists
	And I see "1" items in wishlist with name "My Wishlist"

#given account without wishlist
Scenario: Verify select wishlist to add new good
	When I set following parameters on Sign In page
		| Name     | Value                |
		| email    | onlnnqbg@yomail.info |
		| password | 1234567890           |
	And I click Sign In button
	Then I see the main page is loaded

	When I enter "Camelbak Podium Ice Water Bottle" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Ice Water Bottle" from search results
	Then I see the product page for "Camelbak Podium Ice Water Bottle" is loaded

	When I click Add To Wishlist button
	Then I see add to wishlist popup is loaded
	Then I wait for "1" seconds

	When I choose good with option "Snow" and click Add To Wishlist button
	Then I see select wishlist popup is loaded

	When I enter name of wishlist "First Wishlist" in the create text
	And I click Create And Add To List button
	Then I see "Item added to wishlist" message on wishlist popup
	And I click Close button
	Then I wait for "1" seconds

	When I click Add To Wishlist button
	Then I see add to wishlist popup is loaded
	Then I wait for "1" seconds

	When I choose good with option "Snow" and click Add To Wishlist button
	Then I see select wishlist popup is loaded

	When I enter name of wishlist "Second Wishlist" in the create text
	And I click Create And Add To List button
	Then I see "Item added to wishlist" message on wishlist popup
	And I click Close button
	Then I wait for "1" seconds

	When I enter "Animal Bikes T1 BMX Tyre" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Animal Bikes T1 BMX Tyre" from search results
	Then I see the product page for "Animal Bikes T1 BMX Tyre" is loaded

	When I click Add To Wishlist button
	Then I see add to wishlist popup is loaded
	Then I wait for "1" seconds

	When I choose good with option "2.4" and click Add To Wishlist button
	Then I see select wishlist popup is loaded

	When I select wishlist with name "Second Wishlist"
	And I click Add To List button
	Then I see "Item added to wishlist" message on wishlist popup
	And I click Close button
	Then I wait for "1" seconds

	When I click Wishlist button on Top menu
	Then I see "2" wishlists
	And I see "2" items in wishlist with name "Second Wishlist"

	When I click Delete button on wishlist with name "First Wishlist"
	Then I wait for "1" seconds
	When I click Confirm button

	When I click Delete button on wishlist with name "Second Wishlist"
	Then I wait for "1" seconds
	When I click Confirm button

#given account with 1 wishlist
Scenario: Verify see details of goods in wishlist
	When I set following parameters on Sign In page
		| Name     | Value               |
		| email    | qvxzkgmj@emlhub.com |
		| password | 1234rewq            |
	And I click Sign In button
	Then I see the main page is loaded

	When I enter "Camelbak Podium Ice Water Bottle" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Ice Water Bottle" from search results
	Then I see the product page for "Camelbak Podium Ice Water Bottle" is loaded

	When I click Add To Wishlist button
	Then I see add to wishlist popup is loaded
	Then I wait for "1" seconds

	When I choose good with option "Snow" and click Add To Wishlist button
	Then I see select wishlist popup is loaded

	When I select wishlist with name "My Wishlist"
	And I click Add To List button
	Then I see "Item added to wishlist" message on wishlist popup
	And I click Close button
	Then I wait for "1" seconds

	When I click Wishlist button on Top menu
	Then I see "1" wishlists
	And I see "1" items in wishlist with name "My Wishlist"

	When I click View List button on wishlist with name "My Wishlist"
	Then I see the wishlist page is loaded
	And I see details of goods in wishlist
	| Details | Value                        |
	| Title   | Camelbak Podium Bottle 710ml |
	| Price   | From RUB489.49               |

#given account without wishlist
Scenario: Verify delete wishilist
	When I set following parameters on Sign In page
		| Name     | Value                |
		| email    | onlnnqbg@yomail.info |
		| password | 1234567890           |
	And I click Sign In button
	Then I see the main page is loaded

	When I enter "Camelbak Podium Ice Water Bottle" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Ice Water Bottle" from search results
	Then I see the product page for "Camelbak Podium Ice Water Bottle" is loaded

	When I click Add To Wishlist button
	Then I see add to wishlist popup is loaded
	Then I wait for "1" seconds

	When I choose good with option "Snow" and click Add To Wishlist button
	Then I see select wishlist popup is loaded

	When I enter name of wishlist "My Wishlist" in the create text
	And I click Create And Add To List button
	Then I see "Item added to wishlist" message on wishlist popup
	And I click Close button
	Then I wait for "1" seconds

	When I click Wishlist button on Top menu
	Then I see the wishlist page is loaded
	And I see "1" wishlists

	When I click Delete button on wishlist with name "My Wishlist"
	Then I wait for "1" seconds
	When I click Confirm button
	Then I see empty list of wishlist with message "YOU HAVE NO ITEMS ON YOUR WISH LIST"

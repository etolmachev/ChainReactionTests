Feature: Items
To have a quick access to products I would like to buy in the nearest future
As a customer,
I want to be able to add/delete product to/from my wishlist(s)
A/C:
1. I can add products to wishlist (I can see it in my profile)
1.1 If there is an item in my wishlist, I can see it's name, price, selected option and amount of copies of this item.
1.2 If there are several items in my wishlist, I can see all these items, their amount and cost (for each item and total).
2. I can delete products from wishlist (I can't see in my profile)
3. I don't see any products in an empty wishlist

Background: 
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded
	
	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

Scenario: Verify add good in wishlist
	When I set following parameters on Sign In page
		| Name     | Value               |
		| email    | qvxzkgmj@emlhub.com |
		| password | 1234rewq            |
	And I click Sign In button
	Then I see the main page is loaded

	When I enter "Camelbak Podium Bottle 710ml" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Bottle 710ml" from search results
	Then I see the product page for "Camelbak Podium Bottle 710ml" is loaded

	When I click Add To Wishlist button
	Then I see add to wishlist popup is loaded
	Then I wait for "1" seconds

	When I choose good with option "Clear Blue" and click Add To Wishlist button
	Then I see select wishlist popup is loaded

	When I select wishlist with name "My Wishlist"
	And I click Add To List button
	Then I see "Item added to wishlist" message on wishlist popup
	And I click Close button
	Then I wait for "1" seconds

	When I click Wishlist button on Top menu
	Then I see "1" wishlists
	And I see "1" items in wishlist with name "My Wishlist"


Scenario: Verify see details of goods in wishlist
	When I set following parameters on Sign In page
		| Name     | Value               |
		| email    | qvxzkgmj@emlhub.com |
		| password | 1234rewq            |
	And I click Sign In button
	Then I see the main page is loaded

	When I enter "Camelbak Podium Bottle 710ml" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Bottle 710ml" from search results
	Then I see the product page for "Camelbak Podium Bottle 710ml" is loaded
	Then I wait for "1" seconds

	When I click Add To Wishlist button
	Then I see add to wishlist popup is loaded
	Then I wait for "1" seconds

	When I choose good with option "Clear Blue" and click Add To Wishlist button
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

Scenario: Verify delete items from wishlist
	When I set following parameters on Sign In page
		| Name     | Value               |
		| email    | qvxzkgmj@emlhub.com |
		| password | 1234rewq            |
	And I click Sign In button
	Then I see the main page is loaded

	When I enter "Camelbak Podium Bottle 710ml" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Bottle 710ml" from search results
	Then I see the product page for "Camelbak Podium Bottle 710ml" is loaded

	When I click Add To Wishlist button
	Then I see add to wishlist popup is loaded
	Then I wait for "1" seconds

	When I choose good with option "Clear Blue" and click Add To Wishlist button
	Then I see select wishlist popup is loaded

	When I select wishlist with name "My Wishlist"
	And I click Add To List button
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

	When I select wishlist with name "My Wishlist"
	And I click Add To List button
	Then I see "Item added to wishlist" message on wishlist popup
	And I click Close button
	Then I wait for "1" seconds

	When I click Wishlist button on Top menu
	Then I see "1" wishlists
	And I see "2" items in wishlist with name "My Wishlist"

	When I click View List button on wishlist with name "My Wishlist"
	Then I see the wishlist page is loaded
	And I see "2" items in wishlist

	When I click Remove button on item with name "Animal Bikes T1 BMX Tyre"
	Then I see "1" items in wishlist

	When I click Remove button on item with name "Camelbak Podium Bottle 710m"
	Then  I see empty wishlist with message "YOU HAVE NO ITEMS ON YOUR WISH LIST.MY WISHLIST"

#account without items in wishlist
Scenario: Verify see empty wishlist
	When I set following parameters on Sign In page
		| Name     | Value                       |
		| email    | xigorreguz-2914@yopmail.com |
		| password | 123ewqasd                   |
	And I click Sign In button
	Then I see the main page is loaded

	When I click Wishlist button on Top menu
	Then I see "1" wishlists
	And I see "0" items in wishlist with name "My Wishlist"

	When I click View List button on wishlist with name "My Wishlist"
	Then I see empty wishlist with message "YOU HAVE NO ITEMS ON YOUR WISH LIST.MY WISHLIST"

Scenario: Verify update quantity on item in wishlist
	When I set following parameters on Sign In page
		| Name     | Value               |
		| email    | qvxzkgmj@emlhub.com |
		| password | 1234rewq            |
	And I click Sign In button
	Then I see the main page is loaded

	When I enter "Camelbak Podium Bottle 710ml" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Bottle 710ml" from search results
	Then I see the product page for "Camelbak Podium Bottle 710ml" is loaded

	When I click Add To Wishlist button
	Then I see add to wishlist popup is loaded
	Then I wait for "1" seconds

	When I choose good with option "Clear Blue" and click Add To Wishlist button
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

	When I enter quantity "15" in first item and click Update button
	Then I see "15" quantity

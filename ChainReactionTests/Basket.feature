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

	When I click Basket button on Top menu
	Then I make sure that basket is empty

	When I click Wishlist button on Top menu
	Then I make sure that exist wishlist with name "My Wishlist"


Scenario: Verify see an empty basket 
	When I click Basket button on Top menu
	Then I see the basket page is loaded
	And I see the "There are no items in your basket." message on the basket page

Scenario: Verify add goods in basket from seach page
	When I enter "Camelbak Podium Ice Water Bottle" in the search text
	And I click Search button
	Then I see the search page is loaded
	
	When I select "Cosmic Blue, 610ml" option in item dropdown
	And I click Buy button on item
	Then I see message "ITEM ADDED TO BASKET" in basket popup

	When I click Basket button on Top menu
	Then I see "1" items in basket
	And I see following items in basket
		| Name                             | Quantity | Price          | Option               |
		| Camelbak Podium Ice Water Bottle | 1        | Now 1293.99RUB | Electric Blue, 610ml |
	And I see "1293.99RUB" subtotal cost on basket page

Scenario: Verify add goods with different quantity in basket
	When I enter "Camelbak Podium Ice Water Bottle" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Ice Water Bottle" from search results
	Then I see the product page for "Camelbak Podium Ice Water Bottle" is loaded

	When I select option "Snow" on product page
	Then I see new details on product page
		| Details | Value      |
		| Colour  | Snow |

	When I set "3" as quantity on item page
	And I click Add To Basket button on item page
	Then I see message "ITEM ADDED TO BASKET" in basket popup

	When I click Basket button on Top menu
	Then I see "1" items in basket 
	Then I see following items in basket
		| Name                             | Quantity | Price          | Option      |
		| Camelbak Podium Ice Water Bottle | 3        | Now 1293.99RUB | Snow, 610ml |
	And I see "3881.97RUB" subtotal cost on basket page

Scenario: Verify add goods in basket from wishlist
	When I enter "Animal Bikes T1 BMX Tyre" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Animal Bikes T1 BMX Tyre" from search results
	Then I see the product page for "Animal Bikes T1 BMX Tyre" is loaded

	When I click Add To Wishlist button
	Then I see add to wishlist popup is loaded

	When I choose good with option "2.4" and click Add To Wishlist button
	Then I see select wishlist popup is loaded

	When I select wishlist with name "My Wishlist"
	And I click Add To List button
	Then I see "Item added to wishlist" message on wishlist popup
	And I click Close button
	
	When I click Wishlist button on Top menu
	Then I see the wishlist page is loaded
	And I see "1" wishlists

	When I click View List button on wishlist with name "My Wishlist"
	Then I see the wishlist page is loaded

	When I click Add To Basket button for item "Animal Bikes T1 BMX Tyre" on wishlist page
	Then I see empty wishlist with message "YOU HAVE NO ITEMS ON YOUR WISH LIST.MY WISHLIST"

	When I click Basket button on Top menu
	Then I see "1" items in basket
	And I see following items in basket
		| Name                     | Quantity | Price          | Option            |
		| Animal Bikes T1 BMX Tyre | 1        | Now 2517.99RUB | Black, 20", 2.4", |
	And I see "2517.99RUB" subtotal cost on basket page

Scenario: Verify add a few goods in basket with continue shopping

	When I enter "Animal Bikes T1 BMX Tyre" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Animal Bikes T1 BMX Tyre" from search results
	Then I see the product page for "Animal Bikes T1 BMX Tyre" is loaded

	When I select option "2.4"" on product page
	Then I see new details on product page
		| Details | Value |
		| Width   | 2.4"  |

	When I click Add To Basket button on item page
	Then I see message "ITEM ADDED TO BASKET" in basket popup

	When I click Basket button on Top menu
	Then I see "1" items in basket

	When I click Continue Shopping button on basket page
	Then I see the main page is loaded

	When I enter "Camelbak Podium Ice Water Bottle" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Ice Water Bottle" from search results
	Then I see the product page for "Camelbak Podium Ice Water Bottle" is loaded

	When I select option "Electric Blue" on product page
	Then I see new details on product page
		| Details | Value         |
		| Colour  | Electric Blue |

	When I click Add To Basket button on item page
	Then I see message "ITEM ADDED TO BASKET" in basket popup

	When I click Basket button on Top menu
	Then I see "2" items in basket
	And I see following items in basket
	| Name                             | Quantity | Price          | Option               |
	| Animal Bikes T1 BMX Tyre         | 1        | Now 2517.99RUB | Black, 20", 2.4",    |
	| Camelbak Podium Ice Water Bottle | 1        | Now 1293.99RUB | Electric Blue, 610ml |
	And I see "3811.98RUB" subtotal cost on basket page


Scenario: Verify delete goods from basket
	When I enter "Camelbak Podium Ice Water Bottle" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I select "Electric Blue, 610ml" option in item dropdown
	And I click Buy button on item
	Then I see message "ITEM ADDED TO BASKET" in basket popup

	When I click Basket button on Top menu
	Then I see "1" items in basket

	When I click Continue Shopping button on basket page
	Then I see the main page is loaded

	When I enter "Animal Bikes T1 BMX Tyre" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I select "Black, 20", 2.4"" option in item dropdown
	And I click Buy button on item
	Then I see message "ITEM ADDED TO BASKET" in basket popup

	When I click Basket button on Top menu
	Then I see the basket page is loaded
	And I see "2" items in basket
	And I see following items in basket
	| Name                             | Quantity | Price          | Option               |
	| Camelbak Podium Ice Water Bottle | 1        | Now 1293.99RUB | Electric Blue, 610ml |
	| Animal Bikes T1 BMX Tyre         | 1        | Now 2517.99RUB | Black, 20", 2.4",    |
	And I see "3811.98RUB" subtotal cost on basket page

	When I click Remove button on item in basket with name "Camelbak Podium Ice Water Bottle"
	Then I see "1" items in basket
	And I see following items in basket
	| Name                         | Quantity | Price          | Option              |
	| Animal Bikes T1 BMX Tyre     | 1        | Now 2517.99RUB | Black, 20", 2.4",   |
	And I see "2517.99RUB" subtotal cost on basket page

	When I click Remove button on item in basket with name "Animal Bikes T1 BMX Tyre"
	Then I see the "There are no items in your basket." message on the basket page
	And I see "0.00RUB" subtotal cost on basket page

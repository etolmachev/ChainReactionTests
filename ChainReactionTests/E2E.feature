@MyTag
Feature: E2E
	To make sure that the entire project works as one system and not just a set of features,
As a QA,
I want to be able to test scope of the features connected in one test.
A/C:
1. e2e tests including registration, logout, login, create wishlist, search, add to wishlist, remove from wishlist, delete wishlist

Background:
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded

Scenario: E2E test
	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I click on Create Account button
	Then I see the Create Account page is loaded

	When I add "newestaccexamag+{{5::rnd}}@gmail.com" value with "email" key to Scenario Context
	And I set following parameters on Create Account page
		| Name            | Value              |
		| first           | test               |
		| last            | test               |
		| email           | {{email::context}} |
		| confirmEmail    | {{email::context}} |
		| password        | 1231231234qwe      |
		| confirmPassword | 1231231234qwe      |
	And I click Apply button
	Then I see My Account page is loaded
	
	When I enter "Bike Cave" in the search text
	And I click Search button
	Then I see the search page is loaded
	And I see "1" items on search page
	And I see items name include "Bike Cave"

	When I enter "Vitus Bikes Escarpe Suspension Bike - Deore 2017" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Vitus Bikes Escarpe Suspension Bike - Deore 2017" from search results
	Then I see the product page for "Vitus Bikes Escarpe Suspension Bike - Deore 2017" is loaded
	And I see details on product page
		| Details    | Value         |
		| Price      | 87999.00 RUB  |
		| Rating     | 4.4 / 5       |
		| Colour     | Blue - Orange |
		| Wheel Size | 27.5" (650b)  |

	When I click Size Chart
	Then I see chart is opened

	When I close Size Chart
	Then I see the product page for "Vitus Bikes Escarpe Suspension Bike - Deore 2017" is loaded
	
	When I click on Read all reviews 
	Then I see the following values in Ratings summary on product page
		| Field   | Value     |
		| Rating  | 4.4 / 5   |
		| Reviews | 7 reviews |
		
	When I scroll to name of product 
	When I select option "43cm (17")" on product page
	Then I see new details on product page
		| Details    | Value      |
		| Frame Size | 43cm (17") |

	When I click Add To Wishlist button
	Then I see select wishlist popup is loaded

	When I enter name of wishlist "My Wishlist" in the create text
	And I click Create And Add To List button
	Then I see "Item added to wishlist" message on wishlist popup
	And I click Close button

	When I click Wishlist button on Top menu
	Then I see "1" wishlists
	And I see "1" items in wishlist with name "My Wishlist"

	When I click View List button on wishlist with name "My Wishlist"
	Then I see the wishlist page is loaded
	And I see details of goods in wishlist
	| Details | Value                                            |
	| Title   | Vitus Bikes Escarpe Suspension Bike - Deore 2017 |
	| Price   | From RUB87999.00                                 |

	When I click Logo on Top menu
	Then I see the main page is loaded

	When I click Logout button
	Then I see the main page is loaded 

	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I set following parameters on Sign In page
		| Name     | Value              |
		| email    | {{email::context}} |
		| password | 1231231234qwe      |
	And I click Sign In button
	Then I see the main page is loaded

	When I click Wishlist button on Top menu
	Then I see "1" wishlists
	And I see "1" items in wishlist with name "My Wishlist"

	When I click View List button on wishlist with name "My Wishlist"
	Then I see the wishlist page is loaded
	And I see "1" items in wishlist

	When I click Remove button on item with name "Vitus Bikes Escarpe Suspension Bike - Deore 2017"
	Then I see empty wishlist with message "YOU HAVE NO ITEMS ON YOUR WISH LIST.MY WISHLIST"

	When I enter "Camelbak Podium Ice Water Bottle" in the search text
	And I click Search button
	Then I see the search page is loaded

	When I click on product with name "Camelbak Podium Ice Water Bottle" from search results
	Then I see the product page for "Camelbak Podium Ice Water Bottle" is loaded
	And I see details on product page
	| Details | Value      |
	| Price   | 1048.49RUB |
	| Rating  | 4.2 / 5    |
	| Size    | 610ml      |

	When  I select option "Electric Blue" on product page
	Then I see new details on product page
		| Details | Value         |
		| Colour  | Electric Blue |

	When I set "3" as quantity on item page
	And I click Add To Basket button on item page
	Then I see message "ITEM ADDED TO BASKET" in basket popup
	And I wait for "5" seconds
	
	When I scroll to Basket on Top menu
	And I click Basket button on Top menu
	Then I see "1" items in basket 
	Then I see following items in basket
		| Name                             | Quantity | Price          | Option               |
		| Camelbak Podium Ice Water Bottle | 3        | Now 1048.49RUB | Electric Blue, 610ml |
	And I see "3145.47RUB" subtotal cost on basket page

	When I click Continue Shopping button on basket page
	Then I see the main page is loaded

	When I enter "Animal Bikes T1 BMX Tyre" in the search text
	And I click Search button
	Then I see the search page is loaded
	
	When I select "Black, 20", 2.4"" option in item dropdown
	And I click Buy button on item
	Then I see message "ITEM ADDED TO BASKET" in basket popup
	And I wait for "5" seconds

	When I scroll to Basket on Top menu
	And I click Basket button on Top menu
	Then I see "2" items in basket
	And I see following items in basket
		| Name                             | Quantity | Price          | Option               |
		| Animal Bikes T1 BMX Tyre         | 1        | Now 2517.99RUB | Black, 20", 2.4",    |
		| Camelbak Podium Ice Water Bottle | 3        | Now 1048.49RUB | Electric Blue, 610ml |
	And I see "5663.46RUB" subtotal cost on basket page

	When I click Remove button on item in basket with name "Camelbak Podium Ice Water Bottle"
	Then I see "1" items in basket
	And I see following items in basket
	| Name                     | Quantity | Price          | Option            |
	| Animal Bikes T1 BMX Tyre | 1        | Now 2517.99RUB | Black, 20", 2.4", |
	And I see "2517.99RUB" subtotal cost on basket page

	When I click Remove button on item in basket with name "Animal Bikes T1 BMX Tyre"
	Then I see the "There are no items in your basket." message on the basket page
	And I see "0.00RUB" subtotal cost on basket page
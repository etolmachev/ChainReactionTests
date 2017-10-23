Feature: Registration

Scenario:  Verify Register
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	#When I Click on RubRub dropdown
	#And I select "English" language and click Update button
	#Then I See the main page is loaded
	
	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I click on Create Account button
	Then I see the Create Account page is loaded
	When I set following parameters on Create Account page
		| Name | Value |
		| first  | test  |
		| last  | test  |
		| email |psoesxbbkcym@dropmail.me|
		|confirmEmail|psoesxbbkcym@dropmail.me|
		|password|1231231234|
		|confirmPassword|1231231234|
	And I click Apply button
	Then I see My Account page is loaded

Scenario: Verify Login and Logout
	Given I start the browser
	When I Navigate to the url "http://www.chainreactioncycles.com/ru/en"
	And I See the main page is loaded

	When I Click on RubRub dropdown
	And I select "English" language and click Update button
	Then I See the main page is loaded

	When I Click on Sign In on top menu
	Then I See the Sign In page is loaded

	When I set following parameters on Sign In page
		| Field | Value |
		| email  |   |
		| pass  |   |
	And I Click Sign In button
	Then I See the message on Sing In page

	When I set following parameters on Sign In page
		| Field | Value |
		| email  | test  |
		| pass  | test  |
	And I Click Sign In button
	Then I See the My Account page

	When I Click Logout button
	Then I See the main page 
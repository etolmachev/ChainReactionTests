Feature: Registration

Scenario:  Verify Register
	Given I Navigate to the url "http://www.chainreactioncycles.com/ru/en"
	And I See the main page is loaded

	When I Click on RubRub dropdown
	And I select "English" language and click Update button
	Then I See the main page is loaded
	
	When I Click on Sign In on top menu
	Then I See the Sign In page is loaded

	When I Click on Create Account button
	Then I See the Create Account page is loaded
	When I set following parameters on Create Account page
		| Field | Value |
		| name  | test  |
		| pass  | test  |
	And I Click Apply button
	Then I See My Account page is loaded

Scenario: Verify Login and Logout
	Given I start the browser
	When I Navigate to the url "http://www.chainreactioncycles.com/ru/en"
	Then I See the main page is loaded

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
	Then I See the "The Email Address Or Password You Entered Is Incorrect" on Sing In page

	When I set following parameters on Sign In page
		| Field | Value |
		| email  | test  |
		| pass  | test  |
	And I Click Sign In button
	Then I See the My Account page

	When I Click Logout button
	Then I See the main page 
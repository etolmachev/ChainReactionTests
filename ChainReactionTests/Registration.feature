Feature: Registration

Scenario:  Verify Register
	Given I Navigate to the url "http://www.chainreactioncycles.com/ru/en"
	And I See the main page is loaded

	When I Click on RubRub dropdown
	And I select "English" language and click Update button
	Then I See the main page is loaded
	
	When I Click on SignIn on top menu
	Then I See the SignIn page is loaded

	When I Click on Create Account button
	Then I See the Create Account page is loaded
	When I set following parameters on Create Account page
		| Field | Value |
		| name  | test  |
		| pass  | test  |
	And I Click Apply button
	Then I See My Account page is loaded

Scenario: Verify Login and Logout
	Given Click on Logout button
	And See that i navigate to the site
	When Click on SignIn link
	And See that i navigate to the SignIn page
	And Fill login and password fields
	Then Click on SignIn button
	And See that i login
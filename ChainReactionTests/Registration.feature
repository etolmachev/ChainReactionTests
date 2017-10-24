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
		| email |psoesxe|
		|confirmEmail|psoesxe|
		|password|1231231234|
		|confirmPassword|1231231234|
	And I click Apply button
	Then I see My Account page is loaded

Scenario: Verify Login and Logout
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	#When I Click on RubRub dropdown
	#And I select "English" language and click Update button
	#Then I See the main page is loaded

	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I set following parameters on Sign In page
		| Name | Value |
		| email  |   |
		| password  |   |
	And I click Sign In button
	Then I see the The Email Address Or Password You Entered Is Incorrect message on Sing In page
	And I see Please Enter Your Email Address To Continue message on Sign In page
	And I see Please Enter Your Password To Continue message on Sign In page

	When I set following parameters on Sign In page
		| Name | Value |
		| email  |otbtguukb@emltmp.com|
		| password  |   |
	And I click Sign In button
	Then I see the The Email Address Or Password You Entered Is Incorrect message on Sing In page
	And I see Please Enter Your Password To Continue message on Sign In page

	When I set following parameters on Sign In page
		| Name | Value |
		| email  |   |
		| password  |123123123|
	And I click Sign In button
	Then I see the The Email Address Or Password You Entered Is Incorrect message on Sing In page
	And I see Please Enter Your Email Address To Continue message on Sign In page

	When I set following parameters on Sign In page
		| Name | Value |
		| email  | otbtguukb@emltmp.com  |
		| password  | 123123123  |
	And I click Sign In button
	Then I see the main page is loaded

	When I click Logout button
	Then I see the main page is loaded 
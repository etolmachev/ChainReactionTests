Feature: Registration

Scenario:  Verify Register with all fields
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded
	
	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I click on Create Account button
	Then I see the Create Account page is loaded
	When I set following parameters on Create Account page
		| Name         | Value      |
		| first        | test       |
		| last         | test       |
		| email        | psoesxewxq    |
		| confirmEmail | psoesxewxq   |
		| password     | 1231231234 |
		|confirmPassword|1231231234|
	And I click Apply button
	Then I see My Account page is loaded

Scenario: Verify Login
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded

	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I set following parameters on Sign In page
		| Name | Value |
		| email  | otbtguukb@emltmp.com  |
		| password  | 123123123  |
	And I click Sign In button
	Then I see the main page is loaded

Scenario: Verify Login without Email and Password
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded

	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I set following parameters on Sign In page
		| Name | Value |
		| email  |   |
		| password  |   |
	And I click Sign In button
	Then I see the "The Email Address Or Password You Entered Is Incorrect" message on Sing In page
	And I see "Please Enter Your Email Address To Continue" message on Sign In page
	And I see "Please Enter Your Password To Continue" message on Sign In 

Scenario: Verify Login with Email and without Password
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded

	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I set following parameters on Sign In page
		| Name | Value |
		| email  |otbtguukb@emltmp.com|
		| password  |   |
	And I click Sign In button
	Then I see the "The Email Address Or Password You Entered Is Incorrect" message on Sing In page
	And I see "Please Enter Your Password To Continue" message on Sign In 

Scenario: Verify Login with Password and without Email
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded

	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I set following parameters on Sign In page
		| Name | Value |
		| email  |   |
		| password  |123123123|
	And I click Sign In button
	Then I see the "The Email Address Or Password You Entered Is Incorrect" message on Sing In page
	And I see "Please Enter Your Email Address To Continue" message on Sign In page

Scenario: Verify Logout
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded

	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I set following parameters on Sign In page
		| Name | Value |
		| email  | otbtguukb@emltmp.com  |
		| password  | 123123123  |
	And I click Sign In button
	Then I see the main page is loaded

	When I click Logout button
	Then I see the main page is loaded 

Scenario:  Verify Register without First Name
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded
	
	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I click on Create Account button
	Then I see the Create Account page is loaded
	When I set following parameters on Create Account page
		| Name         | Value      |
		| first        |        |
		| last         | test       |
		| email        | psoesxew    |
		| confirmEmail | psoesxew   |
		| password     | 1231231234 |
		|confirmPassword|1231231234|
	And I click Apply button
	Then I see "Please Enter Your First Name" message on Create Account page

Scenario:  Verify Register without Last Name
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded
	
	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I click on Create Account button
	Then I see the Create Account page is loaded
	When I set following parameters on Create Account page
		| Name         | Value      |
		| first        |   test     |
		| last         |        |
		| email        | psoesxew    |
		| confirmEmail | psoesxew   |
		| password     | 1231231234 |
		|confirmPassword|1231231234|
	And I click Apply button
	Then I see "Please Enter Your Last Name" message on Create Account page

Scenario:  Verify Register without matching Email and Confirm Email
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded
	
	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I click on Create Account button
	Then I see the Create Account page is loaded
	When I set following parameters on Create Account page
		| Name         | Value      |
		| first        |    test    |
		| last         | test       |
		| email        |    |
		| confirmEmail | psoesxew   |
		| password     | 1231231234 |
		|confirmPassword|1231231234|
	And I click Apply button
	Then I see "Email Address And Confirm Email Address Does Not Match" message on Create Account page

Scenario:  Verify Register without Password
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded
	
	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I click on Create Account button
	Then I see the Create Account page is loaded
	When I set following parameters on Create Account page
		| Name         | Value      |
		| first        |    test    |
		| last         | test       |
		| email        | psoesxew    |
		| confirmEmail | psoesxew   |
		| password     |  |
		|confirmPassword|1231231234|
	And I click Apply button
	Then I see "Please Enter Password" message on Create Account page

Scenario:  Verify Register without Confirm Password
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded
	
	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I click on Create Account button
	Then I see the Create Account page is loaded
	When I set following parameters on Create Account page
		| Name         | Value      |
		| first        |    test    |
		| last         | test       |
		| email        | psoesxew    |
		| confirmEmail | psoesxew   |
		| password     | 1231231234 |
		|confirmPassword||
	And I click Apply button
	Then I see "Confirm Password And New Password Does Not Match" message on Create Account page

Scenario:  Verify Register with short Password 
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded
	
	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I click on Create Account button
	Then I see the Create Account page is loaded
	When I set following parameters on Create Account page
		| Name         | Value      |
		| first        |    test    |
		| last         | test       |
		| email        | psoesxew    |
		| confirmEmail | psoesxew   |
		| password     |123|
		|confirmPassword||
	And I click Apply button
	Then I see "Please Enter At Least 8 Characters" message on Create Account page

#remove ignore when utils will be implemented
@ignore
Scenario:  Verify Register without Email
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded
	
	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I click on Create Account button
	Then I see the Create Account page is loaded
	When I set following parameters on Create Account page
		| Name         | Value      |
		| first        |    test    |
		| last         | test       |
		| email        |    |
		| confirmEmail |   |
		| password     | 1231231234 |
		|confirmPassword|1231231234|
	And I click Apply button
	Then I see "Email Address And Confirm Email Address Does Not Match" message on Create Account page
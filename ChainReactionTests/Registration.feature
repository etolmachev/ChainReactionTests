Feature: Registration

@mytag
Scenario: Verify goto sign up
	Given I navigate to the page "www.chainreactioncycles.com/signin"
	And I see the page is loaded
	When I click on CreateAnAccount Button
	Then I go to the page "www.chainreactioncycles.com/create-an-account"

Scenario:  Verify Navigate to the SignIn
	Given Navigate to the site 
    And See the page is loaded
	When Click on RubRub dropdown
	And Change the language 
	And  Click on Update button
	And Click on SignIn link
	Then See that i navigate to the SignIn page

Scenario: Verify SignUp
	
    When Click on CreateAnAccount button
	And See that i navigate to the create page
    And Fill feilds
	And Click Apply button
    Then See that i navigate to MyAccount page
	
   
Scenario: Verify Login and Logout
	Given Click on Logout button
	And See that i navigate to the site 
	When Click on SignIn link
	And See that i navigate to the SignIn page
	And Fill login and password fields 
	Then Click on SignIn button
	And See that i login
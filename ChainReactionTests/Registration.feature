Feature: Registration

@mytag
Scenario: Verify goto sign up
	Given I navigate to the page "www.chainreactioncycles.com/signin"
	And I see the page is loaded
	When I click on CreateAnAccount Button
	Then I go to the page "www.chainreactioncycles.com/create-an-account"

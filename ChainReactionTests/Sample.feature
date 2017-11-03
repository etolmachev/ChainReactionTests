Feature: Sample

Scenario: Sample verify
	Given I open browser
	When I navigate to the page "http://www.chainreactioncycles.com/ru/en"
	Then I see the main page is loaded

	When I click on RubRub dropdown and I select language
	And I click Update button
	Then I see the main page is loaded

	When I click on Sign In on top menu
	Then I see the Sign In page is loaded

	When I set following parameters on Sign In page
		| Name     | Value |
		| email    |otbtguukb@emltmp.com|
		| password |123123123|
	And I click Sign In button
	Then I see the main page is loaded

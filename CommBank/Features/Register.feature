Feature: Register

@Register
Scenario: Verify I am able to register to commbiz using advance control and Foreign exchange options.
	Given I am on Commbiz Login Page and I click Register Online Now button 
	And I select options on registeration Page and click ok
	When I click next on custom registration information page
	When i enter details and click next on registration page 
	Then Test is complete
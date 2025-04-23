Feature: logOut

As a user I can log out from the website

@logout
Scenario: I can log out from the website
	Given I am logged in
	And I am on the Inventory page
	When I click the logout button
	Then I should be logged out

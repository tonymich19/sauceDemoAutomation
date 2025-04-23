Feature: checkout

As a user when I am logged in I can checkout

Background: 
	Given I am logged in

@tag1
Scenario: User can checkout
	Given I add sauce-labs-backpack to the cart
	And I proceed to the checkout
	And I enter my details
	When I finish the checkout
	Then the order should be complete

	


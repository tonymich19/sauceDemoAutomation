Feature: addToCart

Validate that a user can add items to the cart
Background: 
	Given I am logged in

@cart
Scenario Outline: as a user I can add items to the cart
	Then I am on the Inventory page
	When I add <item> to the cart
	Then the cart is updated with the <item>
	Examples:
	| item								|
	| sauce-labs-backpack               |
	| sauce-labs-bike-light             |
	| sauce-labs-bolt-t-shirt           |
	| sauce-labs-fleece-jacket          |
	| test.allthethings()-t-shirt-(red) |
	| sauce-labs-onesie                 |

Feature: ProductList

After user is logged in the the product list is displayed correctly

@productList
Scenario: After I log in, the product list is displayed correctly
	Given I am logged in
	And I am on the Inventory page
	Then the product list should contain the following products
		| Product Name                      |
		| sauce-labs-backpack               |
		| sauce-labs-bike-light             |
		| sauce-labs-bolt-t-shirt           |
		| sauce-labs-fleece-jacket          |
		| test.allthethings()-t-shirt-(red) |
		| sauce-labs-onesie                 |

		

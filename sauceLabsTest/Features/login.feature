Feature: login

User can log in to sauce demo with valid credentials

Background: User is on the login page
	Given I am on the login page


Scenario: Valid user can log in
	When I enter valid username and password
	And I click on the login button
	Then I am on the Inventory page


Scenario Outline: Invalid user cannot log in
	When I enter invalid username and password
	And I click on the login button
	Then Error message should contain <message>
	Examples: 
		| message |
		| Username and password do not match any user in this service |


	

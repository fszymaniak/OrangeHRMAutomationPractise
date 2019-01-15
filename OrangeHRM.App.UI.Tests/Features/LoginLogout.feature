Feature: LoginLogout

Scenario: Login
	Given I am on OrangeHRM App Login page
	And I have entered login credentials
	When I press login button
	Then I can log to the application

Scenario: Unsuccessful Login with invalid user name
	Given I am on OrangeHRM App Login page
	And I have entered login credentials with invalid user name
	When I press login button
	Then I cannot log to the application

Scenario: Unsuccessful Login with invalid password
	Given I am on OrangeHRM App Login page
	And I have entered login credentials with invalid password
	When I press login button
	Then I cannot log to the application

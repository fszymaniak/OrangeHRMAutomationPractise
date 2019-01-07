Feature: LoginLogout

Scenario: Login
	Given I am on OrangeHRM App Login page
	And I have entered login credentials
	When I press login button
	Then I can log to the application

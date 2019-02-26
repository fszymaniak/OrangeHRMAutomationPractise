Feature: Login

Scenario: Login successfully to the application
	Given User is on the OrangeHRM App Login page
	And User has entered a valid login credentials
	When User press a login button
	Then User should be redirected to the dashboard page

Scenario Outline: Unsuccessful Login with invalid user name
	Given User is on the OrangeHRM App Login page
	And User has entered an invalid login credentials: <name> , <password>
	When User press a login button
	Then User should have failed while login to the application

	Examples: 
	| name     | password |
	| Admin12  | admin123 |
	| UserUSer | admin123 |

Scenario Outline: Unsuccessful Login with invalid password
	Given User is on the OrangeHRM App Login page
	And User has entered an invalid login credentials: <name> , <password>
	When User press a login button
	Then User should have failed while login to the application

	Examples: 
	| name   | password |
	| Admin  | pass1    |
	| Admin  | 133123   |

Scenario Outline: Unsuccessful Login with invalid user name and invalid password
	Given User is on the OrangeHRM App Login page
	And User has entered an invalid login credentials: <name> , <password>
	When User press a login button
	Then User should have failed while login to the application

	Examples: 
	| name       | password |
	| Admin123   | pass1    |
	| AdminAdmin | 133123   |
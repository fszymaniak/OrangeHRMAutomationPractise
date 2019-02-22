Feature: LoginLogout

Scenario: Login successfully to the application
	Given User is on OrangeHRM App Login page
	And User has entered valid login credentials
	When User press login button
	Then User should be redirected to the dashboard

Scenario: Unsuccessful Login with invalid user name
	Given User is on OrangeHRM App Login page
	And User has entered invalid login credentials: <name> , <password>
	When User press login button
	Then User should failed while login to the application

	Examples: 
	| name     | password |
	| Admin12  | admin123 |
	| UserUSer | admin123 |

Scenario: Unsuccessful Login with invalid password
	Given User is on OrangeHRM App Login page
	And User has entered invalid login credentials: <name> , <password>
	When User press login button
	Then User should failed while login to the application

	Examples: 
	| name   | password |
	| Admin  | pass1    |
	| Admin  | 133123   |

Scenario: Unsuccessful Login with invalid user name and invalid password
	Given User is on OrangeHRM App Login page
	And User has entered invalid login credentials: <name> , <password>
	When User press login button
	Then User should failed while login to the application

	Examples: 
	| name       | password |
	| Admin123   | pass1    |
	| AdminAdmin | 133123   |
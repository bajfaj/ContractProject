Feature: Login
	As a registered user of giftrete
	I would like to log in
	so that I can use the site

@mytag
Scenario: Valid Login
	Given I navigate to the site
	When I click on the login button
	And I enter my email
	And I enter my password
	And I click on the signin button
	Then I am logged in 

# Below invalid scenarios not completed yet
Scenario:  Invalid Login - valid username and invalid password
    Given i navigate to the site
	And I enter a valid username and invalid password
	When I click ok
	Then user should be unable to login

Scenario:  Invalid Login - invalid username and valid password
    Given i navigate to the site
	And I enter an invalid username and valid password
	When I click ok
	Then user should be unable to login

Scenario:  Invalid Login - invalid username and invalid password
    Given i navigate to the site
	And I enter invalid username and invalid password
	When I click ok
	Then user should be unable to login

Scenario:  Invalid Login - empty username and empty password
    Given i navigate to the site
	And I enter no username and no password
	When I click ok
	Then user should be unable to login

Scenario:  Invalid Login - empty username and valid password
    Given i navigate to the site
	And I enter no username and valid password
	When I click ok
	Then user should be unable to login

Scenario:  Invalid Login - empty username and invalid password
    Given i navigate to the site
	And I enter no username and invalid password
	When I click ok
	Then user should be unable to login

Scenario:  Invalid Login - valid username and empty password
    Given i navigate to the site
	And I enter a valid username and no password
	When I click ok
	Then user should be unable to login

Scenario:  Invalid Login - invalid username and empty password
    Given i navigate to the site
	And I enter a invalid username and no password
	When I click ok
	Then user should be unable to login

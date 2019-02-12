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

Scenario:  Invalid Login 1 - valid username and invalid password
	Given I navigate to the site
	When I click on the login button
	And I enter my email
	And I enter an invalid password
	And I click on the signin button
	Then user should be unable to login

# "" to be used for passing paramters. e.g enter email"emailaddress"

Scenario:  Invalid Login 2 - invalid username and valid password
    Given I navigate to the site
	When I click on the login button
	And I enter an invalid email "john@people.com"
	And I enter my password
	And I click on the signin button
	Then user should be unable to login

# invalid login 3, 4, 5, 6, 7 and 8 unable to run due to messagee hint when field is blank 	
Scenario:  Invalid Login 3 - invalid username and invalid password
    Given I navigate to the site
	When I click on the login button
	And I enter an invalid email "mikes@yahoo.com"
	And I enter an invalid password
	And I click on the signin button
	Then user should be unable to login

Scenario:  Invalid Login 4 - empty username and empty password
    Given I navigate to the site
	When I click on the login button
	And I enter no email address
	And I enter no password
	And I click on the signin button
	Then user should be unable to login

Scenario:  Invalid Login 5 - empty username and valid password
    Given I navigate to the site
	When I click on the login button
	And I enter no email address
	And I enter my password
	And I click on the signin button
	Then user should be unable to login

Scenario:  Invalid Login 6 - empty username and invalid password
    Given I navigate to the site
	When I click on the login button
	And I enter no email address
	And I enter an invalid password
	And I click on the signin button
	Then user should be unable to login

Scenario:  Invalid Login 7 - valid username and empty password
	Given I navigate to the site
	When I click on the login button
	And I enter my email
	And I enter no password
	And I click on the signin button
	Then user should be unable to login

Scenario:  Invalid Login 8 - invalid username and empty password
    Given I navigate to the site
	When I click on the login button
	And I enter an invalid email "final@people.com"
	And I enter no password
	And I click on the signin button
	Then user should be unable to login


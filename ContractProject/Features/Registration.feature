Feature: Registration
	So that I can use the site
	I need to register

@mytag
Scenario: Valid Registration
	Given I navigate to the site
	When Click on the register link
	And I enter firstname
	And I enter lastname
	And I enter emailaddress
	And I enter mobile number
	And I enter password
	And I confirm password
	And I click on signup
	# Then I should be registered
	Then Registration second confirmation

	# last step not running due to captcha

Scenario: InValid Registration
	Given I navigate to the site
	When Click on the register link
	And I enter firstname
	And I enter lastname
	And I enter emailaddress
	And I enter mobile number
	And I enter password "MyNewPassword"
	And I confirm password "No"
	And I click on signup
	Then Registration second confirmation

Scenario: Password Fields
    Given I navigate to the site
	When Click on the register link
	And I enter firstname
	And I enter lastname
	And I enter emailaddress
	And I enter mobile number
	And I enter password "one"
	Then the password is too short error message is displayed





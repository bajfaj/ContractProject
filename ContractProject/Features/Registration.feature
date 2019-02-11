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
	# last step not running due to captcha

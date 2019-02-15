Feature: ErrorMessages
	Login Error Messages using Data Driven Test

@mytag
Scenario Outline: Various Test Fields
    Given I navigate to the site
	When Click on the register link
	And I enter firstname
	And I enter lastname
	And I enter emailaddress
	# And I enter email "wrongemail.com"
	And I enter mobile number
	And I enter password "one"
	And I click on signup
	Then the error message "<message>" is displayed for the "<test>"

	Examples: 
	| test            | message                                                |
	| PasswordTooShort | Your Password Must Be At Least 5 Characters Long       |
	| InvalidEmail     | Please Enter A Valid Email Address                     |
	| MobileTooShort   | Your Mobile Number Must Be At Least 10 Characters Long |



Feature: APIWithSpecFlow
	I want to get a successful message with a valid request

@mytag
Scenario: Method.Get
	Given I have my EndPoint
	And I send a "Method.Get"
	When I execute the response
	Then the response is succesfull

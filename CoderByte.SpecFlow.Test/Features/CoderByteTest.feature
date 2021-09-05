Feature: CoderByteTest
	Simple ReqRest API Test

@mytag
Scenario: REQRES API GET USER TEST - Test Case 2
	Given the URL is "https://reqres.in/api/users"
	And the user id is 4
	When the end user perform GET Request
	Then the response status code should be 200
	And  the user first_name should be "Eve"
	And  the user last_name should be "Holt"

Scenario: REQRES API GET USER TEST - Test Case 3
	Given the URL is "https://reqres.in/api/users"
	And the user id is 6
	When the end user perform GET Request
	Then the response status code should be 200
	And  the user first_name should be "Sergio"
	And  the user last_name should be "Ramos"

Scenario: REQRES API GET USER TEST - Test Case 4
	Given the URL is "https://reqres.in/api/users"
	And the user id is 23
	When the end user perform GET Request
	Then the response status code should be 404

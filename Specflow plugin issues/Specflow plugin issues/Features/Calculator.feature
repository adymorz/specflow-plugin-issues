Feature: Calculator

Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Subtract a number from another
	Given the first number is 50
	And the second number is 70
	When the two numbers are subtracted
	Then the result should be -20

Scenario: Multiply two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are multiplied
	Then the result should be 3500

Scenario: Divide a numbers by another
	Given the first number is 5000
	And the second number is 50
	When the two numbers are divided
	Then the result should be 100

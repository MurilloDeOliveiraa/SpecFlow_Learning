@Regression
Feature: Table

As a QA Software Engineer
I want to learn about specflow and C#
So that I can have a better understanding of how to write automated test scenarios

#How to create and use a table
@UAT
Scenario: Table Example
	Given I am at the login page
	And I type my credentials
	| username | password |
	| murillo  | 123      |
	| laryssa  | 333      |
	| anderson | 222      |
	When I click on the login button
	Then I navigate to the home page

#Example of how create parameters 
@PAT
Scenario Outline: Table Example 2 
	Given I am at the login page
	And I type <username> and <password>
	When I click on the login button
	Then I navigate to the home page
Examples: 
	| username | password |
	| murillo  | 123      |
	| lary     | 333      |

@WEX @172628
Scenario: Pick up the details and send to the UI
	And I type my credentials
	| username | password |
	| murillo  | 123      |
	| laryssa  | 333      |
	| anderson | 222      |	

@WEX @172628
Scenario Outline: Table with Parameters
	And I type my credentials
	| username   | password   |
	| <username> | <password> |	
Examples: 
| username | password |
| murillo  | 123      |
| laryssa  | 333      |
| anderson | 222      |
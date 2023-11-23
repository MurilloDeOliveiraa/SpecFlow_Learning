@UltimateQA 
Feature: UltimateQA

Background: 
	Given I'm on the ultimateQA page

@Prod_Tests
Scenario: Selecting Dropdown option	
	When I select "Audi" on the dropdown section
	Then I should see the previous option selected
	
@Prod_Tests
Scenario: Selecting Radio Button
	When I select the "other" radio button
	Then I should see the correct radio button selected

Feature: TesterGlobal

Background:
	Given I navigate to the home page

@QA 
Scenario Outline: Search for an item on the search bar	
	When I search for <Product> product 
	Then I'm redirected to the <Product> page
Examples: 
| Product        |
| Camera         |
| Black pants    |
| Black trousers |

@QA
Scenario Outline: Search for an specific product's category, add first item to the cart and check the cart
	When I select the <Category> category 
	Then I'm redirected to the <Product> page
	And I add the an item to the cart
	Then I should see the previous item added into the cart's page
Examples: 
| Category | Product   |
| Calçados | Snaeakers |


@QA
Scenario: Add a new user to our HR spreadsheet
	Given I fill the "Add_User_Template.xlsx" with the user informations
	| Field | Value    |
	| Name  | Murillo  |
	| Age   | 26       |
	| City  | Curitiba |
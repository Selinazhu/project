Feature: CustomerClickMainMenu
	in order to check the main menu button is working

@mytag
Scenario Outline:Customers are able to click the main menu
	Given I have entered <userName> and <passWord>
	And I will see the main website and the main menu in the top left of the website
	When I press the main menu button
	Then I can see the list
Examples: 
| userName      | passWord     |
| standard_user | secret_sauce |
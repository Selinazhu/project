Feature: BuyingoneMoreItems
	

@mytag
Scenario Outline: the customers are able to buy more items
	Given I entered <userName> and <passWord>
	And I could see the main website
	When I choose one more items 
	Then I could buy it
Examples: 
| userName      | passWord     |
| standard_user | secret_sauce |
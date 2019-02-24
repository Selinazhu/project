Feature: BuyingItemwithWholeProcess
	In order to buy item from the website

@mytag
Scenario Outline: Users buy the item from the website
	Given I have entered <userName> and <passWord>
	And I see the main website
	When I choose one of the goods
	Then I can buy it 
Examples: 
	| userName      | passWord     |
	| standard_user | secret_sauce |
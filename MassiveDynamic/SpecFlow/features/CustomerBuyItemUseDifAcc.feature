Feature: CustomerBuyItemUseDifAcc
	

@mytag
Scenario: customer uses different information
	Given I login to application
	| username      | password     |
	| standard_user | secret_sauce |

	And I choose one of the item from the website
	And I fill following personal details
	| firstname | lastname | zip  |
	| Su        | Lisa     | "1010" |
	Then complete the process

Scenario:customer uses different information2
	Given I login and enter user details
	Then I click button

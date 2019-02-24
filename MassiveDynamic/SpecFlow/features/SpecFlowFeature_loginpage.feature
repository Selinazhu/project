Feature: SpecFlowFeature_loginpage
	

@mytag
Scenario Outline: LoginPage_parameterization
	Given I have entered website address
	And I entered <username> and <password>
	When I press login button
	Then the customer should be able to see home page
	Examples: 
	| username      | password     |
	| standard_user | secret_sauce |
	| problem_user  | secret_sauce |





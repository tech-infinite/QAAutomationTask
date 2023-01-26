Feature: RunReport

A short summary of the feature

@tag1
Scenario: Run the report
	Given Given I login to the CRM demo site
	When I navigate to 'Reports & Settings'
	And I select 'Reports'
	And I find 'Project Profitability' report
	When I run the report
	Then I should verify the results returned

@tag2
Scenario: Remove events
	Given Given I login to the CRM demo site
	When I navigate to 'Reports & Settings'
	When I click the 'Activity log'
	And I select the first 3 items in the table
	When I delete these actions
	Then I should verify these items are deleted
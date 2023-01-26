Feature: CreateContact

A short summary of the feature

@tag1
Scenario: Create new contact
	Given I login to the CRM demo site
	And I navigate to Sales & Marketing
	And I select 'Contacts'
	When I create a new contact
	And I open the created contact
	Then I should verify the data matches these details 

Feature: Login to EAAPP
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@functional
Scenario: Login to Execute Automation
	Given I navigate to following application
	| URL                    |
	| http://eaapp.somee.com |
	And I click on Login link
	And I enter credentials as
	| UserName | Password |
	| admin    | password |
	And I click on Login button
	Then I should see home page
Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Login to test site
	Given I have navigated to <URL> acme site
	When I enter credentials 'gaurav.mudgal@gmail.com' and password 'Market@2st'
	Then I click on Login button
	Then I should see the homepage

	Examples: 
	| URL                           |
	| https://youtube.com/ |

Scenario Outline: Login to gmail
	Given I have navigated to <URL> acme site
	When I enter credentials 'gaurav.mudgal@gmail.com' and password 'Market@2st'
	Then I click on Login button
	Then I should see the homepage

	Examples: 
	| URL                           |
	| https://gmail.com/ |


Scenario Outline: Login to qtpselenium.com
	Given I have navigated to <URL> acme site
	When I enter credentials 'gaurav.mudgal@gmail.com' and password 'Market@2st'
	Then I click on Login button
	Then I should see the homepage

	Examples: 
	| URL                           |
	| https://qtpselenium.com/ |
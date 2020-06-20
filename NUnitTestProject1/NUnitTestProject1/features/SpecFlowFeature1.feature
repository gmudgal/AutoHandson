Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Open youtube and gmail
	Given I have entered <URL1> into the browser
	And I have entered <URL2> into the browser
	When I press add
	Then the result should be 120 on the screen
Examples: 

| URL1              | URL2                |
| https://uipath.com | https://acme.com |

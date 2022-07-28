Feature: FindAContractor


Background:launch browser, Application and navigate to find a contractor 
Given Launch the browser and Application
When User click on "Find a Contractor"

Scenario: Verify the Find a Contractor page
Then User Verify the title of "Find a Contractor" page and Take screenshot



#@smokeTesting
Scenario Outline:  Verify the pincodetextbox with valid data
When User enter the valid "<data>" in "Pincode/Area" text box
And User Click on "SEARCH" button
Then Contractors profile display

Examples: 
	| data   | 
	| 583201 |

Scenario:  Verify the pincodetextbox with invalid data
When User enter the invalid "<data>" in "Pincode/Area" text box
And User Click on "SEARCH" button
Then Error message display
Examples: 
	| data   | 
	| 58     |


@validate
Scenario:  Verify the contractor profile with img
When User enter the invalid "<data>" in "Pincode/Area" text box
And User Click on "SEARCH" button
Then Verify No of Contractor Profile

Examples: 
	| data   | 
	| 583201 |


@validate
Scenario:  Verify the contractor profile with name
When User enter the invalid "<data>" in "Pincode/Area" text box
And User Click on "SEARCH" button
Then Verify Contractor name

Examples: 
	| data   | 
	| 583201 |






Feature: QuickCalculator

Background: Navigate to paint budget calculator
Given Launch the browser and Application
When User mouse hover on "PAINTS & TEXTURES"
And User click on "Paint Budget Calculator"


Scenario:  Verify paint Budget calculator page
Then User Verify the title of "Paint Budget Calculator" page and Take screenshot


Scenario Outline:  Verify  quick Calculator with valid data and Select interior space radio button
Then User Verity Is selected "Fresh Painting" radio button
Then User Verity Is selected "Interior" radio button
Then User Verity Is selected "1BHK" radio button
When  User Enter valid "<carpetArea>","Ex: 1200" Text box
And  User Click on "CALCULATE NOW" button of Quick Calculator
Then User Verify Quick calcualtor with valid data

Examples: 
		| carpetArea |
		| 1200       |
		| 1          |



Scenario Outline:  Verify quick Calculator with invalid data and Select interior space radio button
Then User Verity Is selected "Fresh Painting" radio button
Then User Click on "Exterior" radio button
When  User Enter invalid "<carpetArea>","Ex: 1200" Text box
And  User Click on "CALCULATE NOW" button of Quick Calculator
Then User Verify Quick calcualtor with invalid

Examples: 
		| carpetArea  |
		| 0           |
		| 1a          |
		| 12345678912 |


Scenario Outline:  Verify  quick Calculator with valid data and Select Exterior space radio button
Then User Verity Is selected "Fresh Painting" radio button
Then User Click on "Exterior" radio button
When  User Enter valid "<carpetArea>","Ex: 1200" Text box
And  User Click on "CALCULATE NOW" button of Quick Calculator
Then User Verify Quick calcualtor with valid data

Examples: 
		| carpetArea |
		| 1200       |
		| 1          |



Scenario Outline:  Verify quick Calculator with invalid data and Select Exterior space radio button
Then User Verity Is selected "Fresh Painting" radio button
Then User Verity Is selected "Interior" radio button
Then User Verity Is selected "1BHK" radio button
When  User Enter invalid "<carpetArea>","Ex: 1200" Text box
And  User Click on "CALCULATE NOW" button of Quick Calculator
Then User Verify Quick calcualtor with invalid

Examples: 
		| carpetArea  |
		| 0           |
		| 1a          |
		| 12345678912 |




Scenario Outline:  Verify quick Calculator result
Then User Verity Is selected "Fresh Painting" radio button
Then User Verity Is selected "Interior" radio button
Then User Verity Is selected "1BHK" radio button
When  User Enter valid "<carpetArea>","Ex: 1200" Text box
And  User Click on "CALCULATE NOW" button of Quick Calculator
Then User Verify Quick calcualtor Calculated Result "<expected>"

Examples: 
		| carpetArea | expected |
		| 1200       | 38570    |
		



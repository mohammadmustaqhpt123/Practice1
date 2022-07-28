Feature: QuickCalculator
#
Background: Navigate to paint budget calculator
Given Launch the browser and Application
When User mouse hover on "PAINTS & TEXTURES"
And User click on "Paint Budget Calculator"


Scenario:  Verify paint Budget calculator page
Then User Verify the title of "Colours & Textures" page and Take screenshot


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







#Scenario Outline:  Verify  quick Calculator with invalid data and Select interior space radio button
#Then Verify fresh painting radio button is selected
#And  Verify interior space radio button is selected
#And  Verify 1BHK radio button is selected
#And  enter invalid carpetArea "<carpetArea>"
#And  Click on calculate now button of quick calculator
#Then error message is displayed
#
#Examples: 
#		| carpetArea  |
#		| 1a          |
#		| 0           |
#		| 12345678912 |
#
#
#Scenario Outline:  Verify  quick Calculator with valid data and Select exterior space radio button 
#Then Verify fresh painting radio button is selected
#And  select exterior space radio button
#And  enter valid carpetArea "<carpetArea>"
#And  Click on calculate now button of quick calculator
#Then calculated result is displayed of quick calculator
# Examples: 
#		 | carpetArea  |
#		 |  1200       |
#		 |  1          |
#		 |  123456789  |


#Scenario:  Verify  quick Calculator with invalid data and Select exterior space radio button
#When select fresh painting radio button
#And  select exterior space radio button
#And  enter invalid carpetArea 
#    | carpetArea  |
#    | 0           |
#    | 1234567891  |
#And  Click on calculate now button
#Then error message is displayed
#
#
#Scenario:  Verify quick Calculator result
#When select fresh painting radio button
#And  select interior space radio button
#And  select 1BHK radio button
#And  enter valid carpetArea
#    | carpetArea  |
#    |  1200       |
#And  Click on calculate now button
#Then Verify calculated result

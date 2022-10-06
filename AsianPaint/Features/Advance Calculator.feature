Feature: Advance Calculator

Background: Navigate to paint budget calculator
Given Launch the browser and Application
When User mouse hover on "PAINTS & TEXTURES"
And User click on "Paint Budget Calculator"
And User Click on Advance Calculator

Scenario: Verify the Advance Calculator with valid data and Select Interior radio button
Then User Verity Is selected "Fresh Painting" radio button of Advance Calculator
Then User Verity Is selected "Interior" radio button of Advance Calculator
When Enter the data in Room TextBox
	| key    | value |
	| Width  | 12    |
	| Length | 12    |
	| Height | 12    |
	| window | 6     |
	| door   | 8     |

And User Click on "WALLA"
And User Click on Option "Texture" of "WALLA"
And User Click on "WALLB"
And User Click on Option "Paint" of "WALLB"
And User Click on "WALLC"
And User Click on Option "Paint" of "WALLC"
And User Click on "WALLD"
And User Click on Option "Paint" of "WALLD"
And User Click on "CALCULATE NOW" button
Then User Verify the Caculated Result of Advance Calculator "₹ 10,575"


Scenario: Verify the Advance Calculator with invalid data and Select Interior radio button
Then User Verity Is selected "Fresh Painting" radio button of Advance Calculator
Then User Verity Is selected "Interior" radio button of Advance Calculator
When Enter the data in Room TextBox
	| key    | value      |
	| Width  | 9999999    |
	| Length | 9999999    |
	| Height | 9999999    |
	| window | 999        |
	| door   | 999        |

And User Click on "WALLA"
And User Click on Option "Texture" of "WALLA"
And User Click on "WALLB"
And User Click on Option "Paint" of "WALLB"
And User Click on "WALLC"
And User Click on Option "Paint" of "WALLC"
And User Click on "WALLD"
And User Click on Option "Paint" of "WALLD"
And User Click on "CALCULATE NOW" button
Then User Verify the Caculated Result of Advance Calculator "₹ 21,47,48,36,47,545"
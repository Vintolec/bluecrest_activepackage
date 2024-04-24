Feature: ActivePackageHomePage

As a prospective Bluecrest Wellbeing application user,
I want to be able to choose the active package,
so that I can subscribe to the services and benefits.

Background: 

Given the user Navigate to Bluecrest Wellbeing Website "https://www.bluecrestwellness.com/"
And the user has accepted the privacy policy and close the popup

Scenario: User selects an Active Package on the HomePage
	
	
	When the user clicks on the BookNow button for the Active Package
	And User inputs location in the search field
	And clicks the search button
	And the user selects a venue from the list
	And selects a date and time
	And clicks on confirm Button
	Then views the Order Summary
	When the user clicks on the continue button
	Then the user can view the personal details page


Scenario: User Select an ActivePackage Via View All Health Check 

	When User clicks on the View All the Health Check Button on the Body of the HomePage
	And  the user clicks on the BookNow button for the Active Package
	And User inputs location in the search field
	And clicks the search button
	And the user selects a venue from the list
	And selects a date and time
	And clicks on confirm Button
	Then views the Order Summary
	When  the user clicks on the continue button
	Then the user can view the personal details page

Scenario: User Select an ActivePackage Via the Health Assessment Menu
	
	When User clicks on the Health Assessment Menu on the Header of the HomePage
	And  the user clicks on the BookNow button for the Active Package
	And User inputs location in the search field
	And clicks the search button
	And the user selects a venue from the list
	And selects a date and time
	And clicks on confirm Button
	Then views the Order Summary
	When  the user clicks on the continue button
	Then the user can view the personal details page

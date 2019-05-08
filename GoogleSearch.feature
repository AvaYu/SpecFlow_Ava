Feature: GoogleSearch
       In order to avoid silly mistakes
       As a math idiot
       I want to be told the sum of two numbers

@mytag
Scenario: Search in Google
       Given I am on the Google Home Page
       And I have also entered 'specflow' on the search bar
       When I click the Google Search Button
       Then A new page should be shown with the page title 'specflow'

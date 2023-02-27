# SeleniumCsharp_HybridFwk
Selenium,Csharp,Nunit,Hybrid fwk ,ExtentReport,Parameters,POM design

Hybrid automation test framework - 
  Selenium csharp Nunit 
  WebdriverManager 
  WebDriverWait 
  CSVReader 
  Extent reports													

The homepage should load successfully without any errors.
The search functionality should work as expected, returning accurate search results for valid search queries.
The regions page should load successfully and display the correct regions for the selected country.
All links and buttons on the page should work correctly, taking the user to the expected pages.                                                                               Feature: Regions functionality on RSMUK website
    As a user of the RSMUK website
    I want to be able to change regions from worldwide industries list
    So that I can see corresponsing regions page and its information
    
    Feature: Search functionality on RSMUK website
    As a user of the RSMUK website
    I want to be able to search for information
    So that I can find what I'm looking for quickly and easily

    Scenario: Search for a specific term
    Given I am on the RSMUK homepage
    When I enter "tax planning" into the search bar
    And I click the search button
    Then I should see a list of search results
    And each result should contain the term "tax planning"

    
    

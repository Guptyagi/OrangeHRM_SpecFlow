Feature: Login

In order to maintain employee record
As an Admin
I want to access the portal

Background: 
Given I have browser with OrangeHRM Application

Scenario: Valid Credential
	
	When I enter username as 'Admin'
	And I enter password as 'admin123'
	And I click on login
	Then I should be able to access URL as 'https://opensource-demo.orangehrmlive.com/index.php/dashboard'

Scenario Outline: Invalid Credential
	
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
	Then I should get an error Message as 'Invalid credentials'
	Examples: 
	| username | password |
	| John     | John123  |
	| Peter    | Peter123 |

Feature: Login

In order to maintain employee record
As an Admin
I want to access the portal
@tag1
Scenario: Valid Credential
	Given I have browser with OrangeHRM Application
	Then I enter username as 'Admin'
	And I enter password as 'admin123'
	And I click on login
	Then I should be able to access URL as 'https://opensource-demo.orangehrmlive.com/index.php/dashboard'

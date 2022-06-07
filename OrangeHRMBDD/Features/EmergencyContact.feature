Feature: EmergencyContact

In order to maintain the emergency contacts
As an Admin
I should be able to add, delete and Edit contacts

Scenario Outline: Add Emergency Contact

Given I have browser with OrangeHRM Application

When I enter username as '<username>'
And I enter password as '<password>'
And I click on login
And I click on MyInfo
And I click on Emergency Contacts
And I click add Emergency Contacts
And I fill the form
| contactname	| relationship    | homephone   | mobile   | workphone |
| <contactname> | <relationship>  | <homephone> | <mobile> | <workphone>|

And I click on save
Then I should get the name added to assigned contact table
Examples: 
| username | password | contactname | relationship | homephone | mobile | workphone |
| Admin    | admin123 | Pooja       | Sister       | 909       | 909    | 909       |
| Admin    | admin123 | Preety      | Sister       | 890       | 890    | 890       |




Feature: EmergencyContact

In order to maintain the emergency contacts
As an Admin
I should be able to add, delete and Edit contacts

Scenario: Add Emergency Contact

Given I have browser with OrangeHRM Application

When I enter username as 'Admin'
And I enter password as 'admin123'
And I click on login
And I click on MyInfo
And I click on Emergency Contacts
And I click add Emergency Contacts
And I fill the form
| contactname | relationship | homephone | mobile | workphone |
| Sam         | Brother      | 908       | 989    | 987       |

And I click on save
Then I should get the name added to assigned contact table



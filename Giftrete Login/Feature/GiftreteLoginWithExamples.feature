Feature: GifteteLoginWithExamples
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: GiftreteLoginWithExamples
	Given I navigate to site "https://www.qa.giftrete.com/account/authentication?ref=1"
	When I enter email"<Email>"
	And I enter password "<Password>"
	And I click on remember me box
	And I click on sign in
	Then I should be logged in with name displayed



	Examples: 
	| Email              | Password |
	| dougdodo@gmail.com | Thankyou |
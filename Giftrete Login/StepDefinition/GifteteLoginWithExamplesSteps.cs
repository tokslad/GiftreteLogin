using Giftrete_Login.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Giftrete_Login.StepDefinition
{
    [Binding]
    public class GifteteLoginWithExamplesSteps
    {
        GiftreteLoginWithExamplesPage giftreteLoginWithExamplesPage;
        public GifteteLoginWithExamplesSteps()
        {
            giftreteLoginWithExamplesPage = new GiftreteLoginWithExamplesPage();
        }
        [Given(@"I navigate to site ""(.*)""")]
        public void GivenINavigateToSite(string url)
        {
            giftreteLoginWithExamplesPage.NavigateToWebsite(url);
        }
        
        [When(@"I enter email""(.*)""")]
        public void WhenIEnterEmail(string yogi)
        {
            giftreteLoginWithExamplesPage.EnterEmail(yogi);
        }
        
        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string woo)
        {
            giftreteLoginWithExamplesPage.EnterPassword(woo);
        }
        
        [When(@"I click on remember me box")]
        public void WhenIClickOnRememberMeBox()
        {
            giftreteLoginWithExamplesPage.RememberMeBox();
        }
        
        [When(@"I click on sign in")]
        public void WhenIClickOnSignIn()
        {
            giftreteLoginWithExamplesPage.ClickOnSignIn();
        }
        
        [Then(@"I should be logged in with name displayed")]
        public void ThenIShouldBeLoggedInWithNameDisplayed()
        {
            Assert.That(giftreteLoginWithExamplesPage.IsNameDisplayed);
        }
    }
}

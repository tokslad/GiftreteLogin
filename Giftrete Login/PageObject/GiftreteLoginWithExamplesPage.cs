using Giftrete_Login.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Giftrete_Login.PageObject
{
    class GiftreteLoginWithExamplesPage
    {
        
        public GiftreteLoginWithExamplesPage()
        {
            driver = Hooks1.driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);  
        }

        IWebDriver driver;


        IWebElement enterEmail => driver.FindElement(By.XPath("//*[@id='user_email']"));
        IWebElement enterPassword => driver.FindElement(By.XPath("//*[@id='user_password']"));
        IWebElement rememberMeBox => driver.FindElement(By.XPath("//*[@id='store_session']"));
        IWebElement clickOnSignIn => driver.FindElement(By.XPath("//*[@id='btn_signin']"));
        IWebElement isNameDisplayed => driver.FindElement(By.XPath("//span[contains(text(),'doug ian')]"));
        








        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterEmail(string yogi)
        {
            enterEmail.SendKeys(yogi);
        }

        public void EnterPassword(string woo)
        {
            enterPassword.SendKeys(woo);
        }

        public void RememberMeBox()
        {
            rememberMeBox.Click();
        }

        public void ClickOnSignIn()
        {
            clickOnSignIn.Click();
        }

        public bool IsNameDisplayed()
        {
            Thread.Sleep(5000);
            return isNameDisplayed.Displayed;
        }

        







    }
}

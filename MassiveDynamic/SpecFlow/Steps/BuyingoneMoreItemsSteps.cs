using MassiveDynamic.Browser;
using MassiveDynamic.Pages;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MassiveDynamic.SpecFlow.Steps
{
    [Binding]
    public sealed class BuyingoneMoreItemsSteps
    {
        [Given(@"I entered (.*) and (.*)")]
        [Scope(Feature = "BuyingoneMoreItems")]
        public void GivenIEnteredStandard_UserAndSecret_Sauce(string userName, string passWord)
        {
            CommonDriver.driver = new ChromeDriver();
            CommonDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            LoginPage Loginp = new LoginPage();
            Loginp.ParameterisedLoginData(userName, passWord);
        }
        [Given(@"I could see the main website")]
        public void GivenICouldSeeTheMainWebsite()
        {
            
        }

        [When(@"I choose one more items")]
        public void WhenIChooseOneMoreItems()
        {
            HomePage homePage = new HomePage();
            homePage.CustomerBuyingOneMoreItems();

            CheckOutPage checkoutpage = new CheckOutPage();
            checkoutpage.Checkout_Continue();

            OverViewPage overviewpage = new OverViewPage();
            overviewpage.Action_finish();
        }

        [Then(@"I could buy it")]
        public void ThenICouldBuyIt()
        {
            OverViewPage overviewpage = new OverViewPage();
            overviewpage.validationCompleteProcess();
        }

    }
}

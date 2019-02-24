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
    public sealed class CustomerClickMainMenuSteps
    {
        [Given(@"I have entered (.*) and (.*)")]
        [Scope(Feature = "CustomerClickMainMenu")]
        public void GivenIEnteredStandard_UserAndSecret_Sauce(string userName, string passWord)
        {
            CommonDriver.driver = new ChromeDriver();
            CommonDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            LoginPage Loginp = new LoginPage();
            Loginp.ParameterisedLoginData(userName, passWord);
        }

        [Given(@"I will see the main website and the main menu in the top left of the website")]
        public void GivenIWillSeeTheMainWebsiteAndTheMainMenuInTheTopLeftOfTheWebsite()
        {

            
        }

        [When(@"I press the main menu button")]
        public void WhenIPressTheMainMenuButton()
        {
            HomePage homepage = new HomePage();
            homepage.CustomerClickMenuButton();
        }

        [Then(@"I can see the list")]
        public void ThenICanSeeTheList()
        {
            HomePage homepage = new HomePage();
            homepage.validationCustomerClickMenuButton();
        }

    }
}

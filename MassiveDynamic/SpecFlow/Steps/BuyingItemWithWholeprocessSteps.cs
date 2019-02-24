using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
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
    public sealed class BuyingItemWithWholeprocessSteps
    {
        [Given(@"I have entered (.*) and (.*)")]
        public void GivenIHaveEnteredAnd(string userName, string passWord)
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Selina\source\repos\MassiveDynamic\\SpecFlowTest.html");
            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            //Feature
            var feature = extent.CreateTest<Feature>("BuyingItemwithWholeProcess");

            //Scenario

            var scenario = feature.CreateNode<Scenario>("Users buy the item from the website");

            //Steps
            scenario.CreateNode<Given>("I have entered <userName> and <passWord>");
            scenario.CreateNode<And>("I see the main website");
            scenario.CreateNode<When>("I choose one of the goods");
            scenario.CreateNode<Then>("I can buy it");

            extent.Flush();
            CommonDriver.driver = new ChromeDriver();
            CommonDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            LoginPage Loginp = new LoginPage();
            Loginp.ParameterisedLoginData(userName, passWord);
        }

        [Given(@"I see the main website")]
        public void GivenISeeTheMainWebsite()
        {
           

        }

        [When(@"I choose one of the goods")]
        public void WhenIChooseOneOfTheGoods()
        {
            HomePage homePage = new HomePage();
            homePage.HomePageActionWithAdditem();

            CheckOutPage checkoutpage = new CheckOutPage();
            checkoutpage.Checkout_Continue();

            OverViewPage overviewpage = new OverViewPage();
            overviewpage.Action_finish();
        }

        [Then(@"I can buy it")]
        public void ThenICanBuyIt()
        {
            OverViewPage overviewpage = new OverViewPage();
            overviewpage.validationCompleteProcess();
        }

    }
}

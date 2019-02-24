using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using MassiveDynamic.Browser;
using MassiveDynamic.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MassiveDynamic
{
    [Binding]
    public class SpecFlowFeature_LoginpageSteps
    {
        [Given(@"I have entered website address")]
        public void GivenIHaveEnteredWebsiteAddress()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Selina\source\repos\MassiveDynamic\\SpecFlowTest.html");
            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            //Feature
            var feature = extent.CreateTest<Feature>("Login");

            //Scenario
            
            var scenario = feature.CreateNode<Scenario>("LoginPage_parameterization");

            //Steps
            scenario.CreateNode<Given>("I navigate to application");
            scenario.CreateNode<And>("I entered<username> and<password>");
            scenario.CreateNode< When>(" I press login button");
            scenario.CreateNode <Then>(" the customer should be able to see home page");

            extent.Flush();


            CommonDriver.driver = new ChromeDriver();
            CommonDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
        
        [Given(@"I entered (.*) and (.*)")]
        [Scope(Feature = "SpecFlowFeature_loginpage")]
        public void GivenIEnteredStandard_UserAndSecret_Sauce(string username,string password)
        {
            LoginPage Loginp = new LoginPage();
            Loginp.ParameterisedLoginData(username, password);
        }
        
        [When(@"I press login button")]
        public void WhenIPressLoginButton()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"the customer should be able to see home page")]
        public void ThenTheCustomerShouldBeAbleToSeeHomePage()
        {
            LoginPage Loginp = new LoginPage();
            Loginp.validationWithPositiveData();
        }
    }
}

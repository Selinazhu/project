using MassiveDynamic.Browser;
using MassiveDynamic.Pages;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MassiveDynamic.SpecFlow.Steps
{
    [Binding]
    public sealed class CustomerBuyItemUseDifACCSteps
    {
        
        [Given(@"I login to application")]
        public void GivenILoginToApplication(Table table)
        {
            CommonDriver.driver = new ChromeDriver();
            CommonDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            dynamic data = table.CreateDynamicInstance();
            LoginPage loginpage = new LoginPage();
            loginpage.ParameterisedLoginData(data.username, data.password);
        }

        [Given(@"I choose one of the item from the website")]
        public void GivenIChooseOneOfTheItemFromTheWebsite()
        {
            HomePage homepage = new HomePage();
            homepage.HomePageActionWithAdditem();
        }

        [Given(@"I fill following personal details")]
        public void GivenIFillFollowingPersonalDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CheckOutPage checkoutpage = new CheckOutPage();
            checkoutpage.checkout_checkoutButton();
            checkoutpage.checkout_filldifferentInfor(data.firstname, data.lastname, data.zip);
            checkoutpage.checkout_clickContiuneButton();
        }

        [Then(@"complete the process")]
        public void ThenCompleteTheProcess()
        {
            OverViewPage overviewpage = new OverViewPage();
            overviewpage.Action_finish();
            overviewpage.validationCompleteProcess();
        }

        //[Given(@"I login and enter user details")]
        //public void GivenILoginAndEnterUserDetails()
        //{
        //    CommonDriver.driver = new ChromeDriver();
        //    CommonDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        //    //create the column header
        //    string[] colHeader = { "username", "password" };
        //    string[] row = { "standard_user", "secret_sauce" };

        //    //create a table with values
        //    var table = new Table(colHeader);
        //    table.AddRow(row);

          

        //}

        //[Then(@"I click button")]
        //public void ThenIClickButton()
        //{
        //    ScenarioContext.Current.Pending();
        //}


    }
}

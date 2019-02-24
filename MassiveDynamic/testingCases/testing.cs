using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using MassiveDynamic.Browser;
using MassiveDynamic.Pages;
using Microsoft.Expression.Encoder.ScreenCapture;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MassiveDynamic.testingCases
{
    class testing
    {
        static void Main(string[] args)
        {

        }
        protected ExtentReports _extent;
        protected ExtentTest _test;

        [OneTimeSetUp]
        protected void Setup()
        {


            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Selina\source\repos\MassiveDynamic\\test.html");

            _extent = new ExtentReports();
            _extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        protected void TearDown()
        {
            _extent.Flush();//writing information into the report
        }

        [SetUp]
        public void BeforeTest()
        {
            //showing the name of the current testcase
            _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
           
        }

        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace)
                    ? ""
                    : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            Status logstatus;

            switch (status)
            {
                case TestStatus.Failed:
                    logstatus = Status.Fail;
                    break;
                case TestStatus.Inconclusive:
                    logstatus = Status.Warning;
                    break;
                case TestStatus.Skipped:
                    logstatus = Status.Skip;
                    break;
                default:
                    logstatus = Status.Pass;
                    break;
            }

            _test.Log(logstatus, "Test ended with " + logstatus + stacktrace);
            _extent.Flush();
        }
        [SetUp]
        public void LoginAction()
        {
            CommonDriver.driver = new ChromeDriver();
            CommonDriver.driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            CommonDriver.driver.Manage().Timeouts().PageLoad= TimeSpan.FromSeconds(20);
           
        }



       [Test]

        [TestCase("Valid test", "standard_user", "secret_sauce")]
        [TestCase("Valid test","problem_user", "secret_sauce")]
        [TestCase("inValid test with wrong Username","standard", "secret_sauce")]
        [TestCase("inValid test with wrong password", "standard_user", "wrong")]

        public void Login_Test(string test, string username,string password)
        {

           
            LoginPage Loginp = new LoginPage();
            screenshot screens = new screenshot();
           // ExtentReport Er = new ExtentReport();

            
            Loginp.ParameterisedLoginData(username, password);
             
            Loginp.validationWithPositiveData();
           // Er.ExtentTestCase();
            screens.Takescreenshot("filename");
           
        }
        [Test]
        public void loginpage_validUserNameAndPassword()
        {
            LoginPage Loginp = new LoginPage();
            Loginp.LoginWithValidData();
            Loginp.validationWithPositiveData();
        }

        [Test]

        [TestCase("Valid test", "standard_user", "secret_sauce")]

        public void HomePage_testUserAddItemtoCart(string test, string username, string password)
        {
            LoginPage loginpage = new LoginPage();
            HomePage homepage = new HomePage();
            screenshot screens = new screenshot();
            
            loginpage.ParameterisedLoginData(username, password);
            screens.Takescreenshot2("filename");

            homepage.HomePageActionWithAdditem();

            screens.Takescreenshot2("filename");

            homepage.validationUserAddItemtoCart();

        }

        [Test]

        [TestCase("Valid test", "standard_user", "secret_sauce")]
        public void HomePage_TestUserMoveItemFromCart(string test, string username, string password)
        {
            LoginPage loginpage = new LoginPage();
            HomePage homepage = new HomePage();
            screenshot screens = new screenshot();

            loginpage.ParameterisedLoginData(username, password);
            screens.Takescreenshot3("filename");

            homepage.HomePageActionWithDeleteitem();
            screens.Takescreenshot3("filename");

            homepage.validationUserRemoveItemFromCart();
        }

        [Test]
        [TestCase("Valid test", "standard_user", "secret_sauce")]
        public void HomePage_TestUserClickMenuButton(string test, string username, string password)
        {
            LoginPage loginpage = new LoginPage();
            HomePage homepage = new HomePage();
            screenshot screens = new screenshot();

            loginpage.ParameterisedLoginData(username, password);
            homepage.CustomerClickMenuButton();
            screens.Takescreenshot4("filename");
            homepage.validationCustomerClickMenuButton();
        }

        [Test]
        public void LoginPageWithExcelData()
        {
            LoginPage Loginp = new LoginPage();
            ExcelLib ExData = new ExcelLib();
            ExData.PopulateInCollection(@"C:\Users\Selina\source\repos\MassiveDynamic\Data.xlsx");

          


        }

       

        [Test]

        [TestCase("Valid test", "standard_user", "secret_sauce")]
        public void userBuyProductSuccessful(string test, string username, string password)
        {
            LoginPage loginpage = new LoginPage();
            HomePage homepage = new HomePage();
            CheckOutPage checkoutpage = new CheckOutPage();
            OverViewPage overviewpage = new OverViewPage();
            screenshot screens = new screenshot();

            loginpage.ParameterisedLoginData(username, password);
            screens.Takescreenshot9("filename");

            homepage.HomePageActionWithAdditem();
            screens.Takescreenshot9("filename");

            checkoutpage.Checkout_Continue();
            screens.Takescreenshot9("filename");

            overviewpage.Action_finish();
            

            overviewpage.validationCompleteProcess();

        }

        [Test]
        public void CaptureTestVideo()
        {
            ScreenCaptureJob scj = new ScreenCaptureJob();
            scj.OutputScreenCaptureFileName = @"C:\Users\Selina\source\repos\MassiveDynamic\Test.avi";
            scj.Start();
            Thread.Sleep(2000);
            scj.Stop();

        }

         [Test]
            
        




        [TearDown]
        public void finishAction()
        {
            //CommonDriver.driver.Quit();

           
        }
    }

}

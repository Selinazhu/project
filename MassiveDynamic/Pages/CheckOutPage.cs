using MassiveDynamic.Browser;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveDynamic.Pages
{
    class CheckOutPage
    {
        public CheckOutPage()
        {
            PageFactory.InitElements(CommonDriver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@class='cart_checkout_link']")]
        private IWebElement CheckoutButton { set; get; }

        [FindsBy(How= How.XPath,Using = "//input[@data-test='firstName']")]
        private IWebElement FirstNameT { set; get; }

        [FindsBy(How = How.XPath,Using = "//input[@data-test='lastName']")]
        private IWebElement LastNameT { set; get; }

        [FindsBy(How = How.XPath,Using = "//input[@data-test='postalCode']")]
        private IWebElement PostCodeT { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@class='cart_checkout_link']")]
        private IWebElement ContiuneButton { set; get; }

        [FindsBy(How= How.XPath,Using = "//a[@class='cart_cancel_link']")]
        private IWebElement CancelButton { set; get; }

        public void Checkout_Continue()
        {
            screenshot screens = new screenshot();
          
            CheckoutButton.Click();
            
            FirstNameT.SendKeys("sggi");
           
            LastNameT.SendKeys("r");
           
            PostCodeT.SendKeys("12345");
            screens.Takescreenshot5("filename");
            screens.Takescreenshot9("filename");

            ContiuneButton.Click();
            screens.Takescreenshot5("filename");
            screens.Takescreenshot9("filename");
        }

        public void checkout_checkoutButton()
        {
            CheckoutButton.Click();
        }

        public void checkout_filldifferentInfor(string firstname,string lastname,string zip)
        {
            screenshot screens = new screenshot();

            
            FirstNameT.SendKeys(firstname);
            LastNameT.SendKeys(lastname);
            PostCodeT.SendKeys(zip);
            
        }

        public void checkout_clickContiuneButton()
        {
            ContiuneButton.Click();
        }

        public void Checkout_Cancel()
        {
            screenshot screens = new screenshot();
            CheckoutButton.Click();
            FirstNameT.SendKeys("sggi");
            LastNameT.SendKeys("r");
            PostCodeT.SendKeys("12345");
            screens.Takescreenshot6("filename");

            CancelButton.Click();
            screens.Takescreenshot6("filename");

        }
    }
}

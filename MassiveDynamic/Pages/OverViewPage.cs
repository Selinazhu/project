using MassiveDynamic.Browser;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveDynamic.Pages
{
    class OverViewPage
    {
        public OverViewPage()
        {
            PageFactory.InitElements(CommonDriver.driver, this);
        }

        [FindsBy(How= How.XPath,Using = "//a[@class='cart_cancel_link']")]
        private IWebElement CancelButton { set; get; }

        [FindsBy(How= How.XPath,Using = "//a[@class='cart_checkout_link']")]
        private IWebElement FinishButton { set; get; }

        [FindsBy(How = How.XPath, Using = "//div[@class='subheader_label']")]
        private IWebElement CompleteLable { set; get; }

        public void Action_finish()
        {
            screenshot screens = new screenshot();
            
            FinishButton.Click();
            screens.Takescreenshot9("filename");


        }

        public void Action_Cancel()
        {
            CancelButton.Click();
        }

        public void validationCompleteProcess()
        {
            //Assert.True(CompleteLable.Displayed);
            if (CompleteLable.Displayed)
            {
                Console.WriteLine("The expected results is that the customer can be seen the words:'Checkout: Complete'" );
            }
            else
            {
                Console.WriteLine("Faild");
            }
            
        }
    }
}

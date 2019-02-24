using MassiveDynamic.Browser;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MassiveDynamic.Pages
{
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(CommonDriver.driver, this);
        }
        //find the username xpath
        [FindsBy(How = How.XPath, Using = "//input[@type='text']")]
        private IWebElement Username { set; get; }

            //find the password xpath
            [FindsBy(How = How.XPath,Using = "//input[@type='password']")]
            private IWebElement Password { set; get; }
            
            //find the password xpath
            [FindsBy(How= How.XPath, Using = "//input[@type='submit']")]
            private IWebElement Login { set; get; }

        [FindsBy(How = How.XPath,Using = "//button[@class='error-button']")]
        private IWebElement ErrorButton { set; get; }
       
        public void LoginWithValidData()
        {
            Username.SendKeys("standard_user");
            
            Password.SendKeys("secret_sauce");
           
            Login.Click();
        }

        public void ParameterisedLoginData(string username,string password)
        {
            screenshot screens = new screenshot();

            Username.SendKeys(username);
            Console.WriteLine("The name of the customer is " + username);
          
            Password.SendKeys(password);
            Console.WriteLine("the password is " + password);

            screens.Takescreenshot("filename");
            screens.Takescreenshot2("filename");
            screens.Takescreenshot4("filename");
            screens.Takescreenshot9("filename");

            Login.Click();

            WebDriverWait wait = new WebDriverWait(CommonDriver.driver, TimeSpan.FromSeconds(10));
           
        }

        //public void LoginAction()
        //{
        //    Username.SendKeys("standard_user");
        //    //Username.Sendkeys("locked_out_user");
        //    //Username.SendKeys("problem_user");

        //    Password.SendKeys("secret_sauce");

        //    Login.Click();

        //}

        //public void validationForValidData()
        //{

        //    string titleW = CommonDriver.driver.FindElement(By.XPath("//div[@class='product_label']")).Text;
        //    Assert.Equals("Products", titleW);
        //} //string words = CommonDriver.driver.FindElement(By.XPath("//h3[@data-test='error']")).Text;



        public void validationWithPositiveData()
        {
            IWebElement title1 = null;

            string actualWords = "Epic sadface: ";

            string actualResult = "Products";
            try
            {
                title1 = CommonDriver.driver.FindElement(By.XPath("//div[@class='product_label']"));
                if (title1 == null)
                {
                    Console.WriteLine("fail");
                    return;
                }
            }
            catch (Exception e )
            {
                Console.WriteLine("the actual result is that cannot find the element : " + e.Message );
                Console.WriteLine("the expected result is user can not login - so thay can not see the page " + actualResult);
                return;
            }
            

            if (title1.Text != null && title1.Text == "Products")
            {
                Console.WriteLine("Successful");
                Console.WriteLine("the actual result is " + actualResult);
                Console.WriteLine("the expected result is " + title1.Text);
            }

            else
            {
                Console.WriteLine("fails");
                Console.WriteLine(actualWords);
            }

        }








        public void validationData()
        {
            string titleW = CommonDriver.driver.FindElement(By.XPath("//div[@class='product_label']")).Text;
            string actualWords = "Epic sadface: ";

            string words = CommonDriver.driver.FindElement(By.XPath("//*[@id='login_button_container']/div/form/h3")).Text;

            if (titleW == "Products")
            {
                Console.WriteLine("successful");
            }

            else
            {
              if(actualWords == words) {
                    Console.WriteLine("Successfully");
                }
                else
                {
                    Console.WriteLine("fail");
                }
                
            }
            Console.WriteLine("actual result : " + titleW);

        }






        public void validationForInvalidData()
        {
            //      string words = CommonDriver.driver.FindElement(By.XPath("//*[@id='login_button_container']/div/form/h3")).Text;

            //string actualWords = "Epic sadface: " + "Username and password do not match any user in this service";
           Assert.True (CommonDriver.driver.FindElement(By.XPath("//button[@class='error-button']")).Displayed);
            //      if (words == actualWords)
            //      {
            //          Console.WriteLine("successful");
            //      }
            //      else { Console.WriteLine("fail");

            //      }
            //      Console.WriteLine("actual result: " + words);
            //      Console.WriteLine("Expected result: " + actualWords);

            //  }

            //public void validationBackGroundColor()
            //{
            //    string btncolor = Login.GetCssValue("background");

            //    Console.WriteLine("the background color is" + btncolor);

            //    Color hexColor = Color.FromArgb(97, 175, 254);

            //    string hex = hexColor.R.ToString("X2") + hexColor.G.ToString("X2") + hexColor.B.ToString("X2");

            //    Console.WriteLine("the hex color is : " + hex);
            //    if (hex == "61AFFE")
            //    {
            //        Console.WriteLine("the background color is correct");
            //    }
            //    else
            //    {
            //        Console.WriteLine("the background color does not match");
            //    }
        }

    }
}

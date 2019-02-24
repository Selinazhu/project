using MassiveDynamic.Browser;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveDynamic.Pages
{
    class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(CommonDriver.driver, this);
        }
        [FindsBy(How = How.XPath,Using = "//button[text()='Open Menu']")]
        private IWebElement MenuButton { set; get; }

        [FindsBy(How = How.XPath, Using = "//a[@id='inventory_sidebar_link']")]
        private IWebElement AllMenubutton { set; get; }

        [FindsBy(How=How.XPath,Using = "//*[@id='item_4_img_link']/img")]
        private IWebElement BackPackImg { set; get; }

        [FindsBy (How = How.XPath, Using = "//button[@class='inventory_details_back_button']")]
        private IWebElement ImgBackButton { set; get; }

        [FindsBy(How= How.XPath,Using = "//button[@class='add-to-cart-button']")]
        private IWebElement ImgADDTOCARTButton { set; get; }

        [FindsBy(How= How.XPath, Using = "//button[@class='remove-from-cart-button']")]
        private IWebElement RemoveButton { set; get; }

        [FindsBy(How = How.XPath, Using = "//div[@id='shopping_cart_container']")]
        private IWebElement CartImg { set; get; }

        [FindsBy(How = How.XPath,Using = "//a[@class='cart_checkout_link']")]
        private IWebElement CheckoutButton { set; get; }

        [FindsBy(How = How.XPath,Using = "//a[@class='cart_cancel_link']")]
        private IWebElement ConitnueShoppingButton { set; get; }

       [FindsBy(How = How.XPath, Using = "product_sort_container")]
       private IWebElement SelectButton { set; get; }

        [FindsBy(How= How.XPath, Using = "//div[@class='cart_desc_label']")]
        private IWebElement DescriptionWords { set; get; }

        [FindsBy(How = How.XPath, Using = "//div[text()='Sauce Labs Backpack']")]
        private IWebElement ItemName { set; get; }

        //find items
        [FindsBy(How = How.XPath,Using = "(//button[@class='add-to-cart-button'])[2]")]
        private IWebElement ItemNameSec { set; get; }

        [FindsBy(How = How.XPath,Using = "(//button[@class='add-to-cart-button'])[1]")]
        private IWebElement ItemFristOne { set; get; }

        [FindsBy (How= How.XPath,Using = "(//div[@class='inventory_item_name'])[1]")]
        private IWebElement ItemNameCart { set; get; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='inventory_item_name'])[2]")]
        private IWebElement ItemNameSecCart { set; get; }

        public void HomePageActionWithAdditem()
        {
            screenshot screens = new screenshot();
           

            //this fuction is not working yet

            //WebDriverWait wait = new WebDriverWait(CommonDriver.driver, new TimeSpan(0, 0, 10));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id='shopping_cart_container']")));

            //SelectElement Oselection = new SelectElement(SelectButton);
            //Oselection.SelectByText("Name (Z to A)");

            BackPackImg.Click();
            screens.Takescreenshot2("filename");
            screens.Takescreenshot9("filename");

            ImgBackButton.Click();
            screens.Takescreenshot2("filename");
            screens.Takescreenshot9("filename");

            ImgADDTOCARTButton.Click();
            screens.Takescreenshot2("filename");
            screens.Takescreenshot9("filename");

            CartImg.Click();
            Console.WriteLine("The item that the customer chose is " + ItemName.Text );
            screens.Takescreenshot2("filename");
            screens.Takescreenshot9("filename");



        }
        public void HomePageActionWithDeleteitem()
        {
            screenshot screens = new screenshot();
            BackPackImg.Click();
            screens.Takescreenshot3("filename");

            ImgBackButton.Click();
            screens.Takescreenshot3("filename");

            ImgADDTOCARTButton.Click();
            screens.Takescreenshot3("filename");

            CartImg.Click();
            screens.Takescreenshot3("filename");

            RemoveButton.Click();
            screens.Takescreenshot3("filename");

            ConitnueShoppingButton.Click();
            screens.Takescreenshot3("filename");

            CartImg.Click();
            screens.Takescreenshot3("filename");
        }

        public void CustomerClickMenuButton()
        {
            screenshot screens = new screenshot();
            MenuButton.Click();
            screens.Takescreenshot4("filename");
            //CartImg.Click();
            //Console.WriteLine("The item that the customer chose is " + ItemName.Text);
        }

        public void CustomerBuyingOneMoreItems()
        {
            screenshot screens = new screenshot();
            //ImgADDTOCARTButton.Click();
            //screens.Takescreenshot3("filename");
            ItemFristOne.Click();
            ItemNameSec.Click();
            //ImgADDTOCARTButton.Click();
            CartImg.Click();
            Console.WriteLine("The item that the customer chose is " + ItemNameCart.Text);
            Console.WriteLine("The item that the customer chose is " + ItemNameSecCart.Text);
        }

        public void validationUserAddItemtoCart()
        {
            if (DescriptionWords.Displayed)
            {
                Console.WriteLine("The user expected to see the description of the item");
            }
            else
            {
                Console.WriteLine("faild, the customer cannot see the description of the item");
            }
        }

        public void validationUserRemoveItemFromCart()
        {

            try
            {
                if (ItemName.Displayed)
            {
                Console.WriteLine("Faild, the customer still can see the item in the cart");
                    
            }
       

            }
            catch(Exception e)
            {
                Console.WriteLine("successful, the item successfully delete from the cart" );
            }
              
       
        }

        public void validationCustomerClickMenuButton()
        {
            if (AllMenubutton.Displayed)
            {
                Console.WriteLine("successful, the customer is able to see the main menu");
            }
            else
            {
                Console.WriteLine("faild, the customer is not able to see the main menu");
            }
        }
    }
}

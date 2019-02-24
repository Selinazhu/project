using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;

namespace MassiveDynamic
{
    class Program
    {
    //    static void Main(string[] args)d
    //    {
    //        IWebDriver driver = new ChromeDriver();

    //        driver.Navigate().GoToUrl("https://www.saucedemo.com/");

    //        //find the username xpath
    //        IWebElement Username = driver.FindElement(By.XPath("/html/body/div/div/form/input[1]"));
    //        Username.SendKeys("standard_user");
    //        //Username.Sendkeys("locked_out_user");
    //        //Username.SendKeys("problem_user");

    //        //find the password xpath
    //        IWebElement Password = driver.FindElement(By.XPath("/html/body/div/div/form/input[2]"));
    //        Password.SendKeys("secret_sauce");

    //        //find the password xpath
    //        IWebElement Login = driver.FindElement(By.XPath("/html/body/div/div/form/input[3]"));


    //        //validation the background color of the Login button
    //        string btncolor = Login.GetCssValue("background");

    //        Console.WriteLine("the background color is" + btncolor);



    //        Color hexColor = Color.FromArgb(97, 175, 254);

    //        string hex = hexColor.R.ToString("X2") + hexColor.G.ToString("X2") + hexColor.B.ToString("X2");

    //        Console.WriteLine("the hex color is : " + hex);
    //        if (hex == "61AFFE")
    //        {
    //            Console.WriteLine("the background color is correct");
    //        }
    //        else
    //        {
    //            Console.WriteLine("the background color does not match");
    //        }

    //        // Assert.assertEquals(btncolor, hex);



    //        // Login.Click();

    //        //verify the background color for the Login




    //        //assertEquals("#61affe",color.GetCssValue("Background"));

    //        //assertTrue(arrColor[1].Equals("#61affe"));



    //        //import the Excel data
    //        excel.Application x1app = new excel.Application();

    //        excel.Workbook x1workbook = x1app.Workbooks.Open(@"C:\Users\Selina\Desktop");

    //        excel.Worksheet x1worksheet = x1workbook.Sheets[1];

    //        excel.Range x1range = x1worksheet.UsedRange;

    //        string username;
    //        string password;
    //        for(int i =1; i < 3; i++)
    //        {
    //            username = x1range.Cells[i][1].value2;
    //            password = x1range.Cells[i][2].value2;

    //        }

    //        driver.Close();

    //    }

        
    }
}

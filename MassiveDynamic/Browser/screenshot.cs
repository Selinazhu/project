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
    class screenshot
    {
        public screenshot(){
            PageFactory.InitElements(CommonDriver.driver, this);
        }

        public void Takescreenshot(string filename)
        {
            Screenshot ss = ((ITakesScreenshot)CommonDriver.driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\Selina\source\repos\MassiveDynamic\ScreenshotFile\LoginScreenShot\" + filename + "-" + DateTime.Now.ToString("yyyy-mm-dd hh mm ss") +".png",ScreenshotImageFormat.Png);
        }

        public void Takescreenshot2(string filename)
        {
            Screenshot ss = ((ITakesScreenshot)CommonDriver.driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\Selina\source\repos\MassiveDynamic\ScreenshotFile\HomePageScreenShot_AddItem\" + filename + "-" + DateTime.Now.ToString("yyyy-mm-dd hh mm ss") + ".png", ScreenshotImageFormat.Png);
        }

        public void Takescreenshot3(string filename)
        {
            Screenshot ss = ((ITakesScreenshot)CommonDriver.driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\Selina\source\repos\MassiveDynamic\ScreenshotFile\HomePageScreenShot_DeleteItem\" + filename + "-" + DateTime.Now.ToString("yyyy-mm-dd hh mm ss") + ".png", ScreenshotImageFormat.Png);
        }

        public void Takescreenshot4(string filename)
        {
            Screenshot ss = ((ITakesScreenshot)CommonDriver.driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\Selina\source\repos\MassiveDynamic\ScreenshotFile\HomePageScreenShot_ClickMenuButton\" + filename + "-" + DateTime.Now.ToString("yyyy-mm-dd hh mm ss") + ".png", ScreenshotImageFormat.Png);
        }

        public void Takescreenshot5(string filename)
        {
            Screenshot ss = ((ITakesScreenshot)CommonDriver.driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\Selina\source\repos\MassiveDynamic\ScreenshotFile\CheckOutScreenShot_Continue\" + filename + "-" + DateTime.Now.ToString("yyyy-mm-dd hh mm ss") + ".png", ScreenshotImageFormat.Png);
        }

        public void Takescreenshot6(string filename)
        {
            Screenshot ss = ((ITakesScreenshot)CommonDriver.driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\Selina\source\repos\MassiveDynamic\ScreenshotFile\CheckOutScreenShot_Cancel\" + filename + "-" + DateTime.Now.ToString("yyyy-mm-dd hh mm ss") + ".png", ScreenshotImageFormat.Png);
        }

        public void Takescreenshot7(string filename)
        {
            Screenshot ss = ((ITakesScreenshot)CommonDriver.driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\Selina\source\repos\MassiveDynamic\ScreenshotFile\OverviewScreenShot_finish\" + filename + "-" + DateTime.Now.ToString("yyyy-mm-dd hh mm ss") + ".png", ScreenshotImageFormat.Png);
        }

        public void Takescreenshot8(string filename)
        {
            Screenshot ss = ((ITakesScreenshot)CommonDriver.driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\Selina\source\repos\MassiveDynamic\ScreenshotFile\OverviewScreenShot_cancel\" + filename + "-" + DateTime.Now.ToString("yyyy-mm-dd hh mm ss") + ".png", ScreenshotImageFormat.Png);
        }

        public void Takescreenshot9(string filename)
        {
            Screenshot ss = ((ITakesScreenshot)CommonDriver.driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\Selina\source\repos\MassiveDynamic\ScreenshotFile\WholeProcessScreenShot\" + filename + "-" + DateTime.Now.ToString("yyyy-mm-dd hh mm ss") + ".png", ScreenshotImageFormat.Png);
        }
    }
}

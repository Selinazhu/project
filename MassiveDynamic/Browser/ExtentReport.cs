using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveDynamic.Browser
{
    class ExtentReport
    {
        [Test]
        public void ExtentTestCase()
        {
            var htmlReporter = new ExtentHtmlReporter("extentReport.html");
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            //hard coding
            extent.AddSystemInfo("Operating System:", "Windows 10");
            extent.AddSystemInfo("HostName:", "SeleniumPC");
            extent.AddSystemInfo("Browser: ", "Google Chrome");

            var test = extent.CreateTest("ExtentTestCase");
            test.Log(Status.Info, "Step 1: Test case starts.");
            test.Log(Status.Pass, "Step 2: Test case for pass");
            test.Log(Status.Fail, "Step 3: Test case for failed");
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.png").Build());
            test.Pass("Screenshot").AddScreenCaptureFromPath("screenshot.png");
            extent.Flush();
        }
    }
}

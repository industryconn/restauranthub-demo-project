using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using restauranthub.config;
using restauranthub.POM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static restauranthub.Global.CommanMethodes;

namespace restauranthub.Global
{
    class Base
    {
        #region To access Path from resource file

        public static int Browser = Int32.Parse(restaurantresource.Browser);
        public static String ExcelPath = restaurantresource.ExcelPath;
        public static string ScreenshotPath = restaurantresource.ScreenShotPath;
        public static string ReportPath = restaurantresource.ReportPath;
        //#endregion

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;
        #endregion

        #region setup and tear down
        [SetUp]
        public void Inititalize()
        {

            // advisasble to read this documentation before proceeding http://extentreports.relevantcodes.com/net/
            switch (Browser)
            {

                case 1:
                    Driver.driver = new ChromeDriver();
                    Driver.driver.Manage().Window.Maximize();
                    Driver.driver.Manage().Cookies.DeleteAllCookies();
                    
                    break;
                case 2:
                    Driver.driver = new FirefoxDriver();
                    Driver.driver.Manage().Window.Maximize();
                    Driver.driver.Manage().Cookies.DeleteAllCookies();
                    

                    break;

            }
            Driver.driver.Navigate().GoToUrl("https://www.restauranthub.co.nz");
            Restauranthubhome resobj = new Restauranthubhome();
            resobj.resthome();
            extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
            extent.LoadConfig(restaurantresource.ReportXMLPath);
        }


        [TearDown]
        public void TearDown()
        {
            // Screenshot
            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
            test.Log(LogStatus.Info, "Image example: " + img);
            // end test. (Reports)
            extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
            extent.Flush();
            // Close the driver :)            
            Driver.driver.Close();
        }
        #endregion

    }
}
#endregion
    


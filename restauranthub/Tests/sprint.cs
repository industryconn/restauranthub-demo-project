using NUnit.Framework;
using RelevantCodes.ExtentReports;
using restauranthub.Global;
using restauranthub.POM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static restauranthub.Global.CommanMethodes;

namespace restauranthub.Tests
{
    class sprint
    {
        [TestFixture]
        [Category("Sprint1")]
        class review : Base
        {

            [Test, Description("Verifies Review Feature")]
            public void reviewbutt()
            {
                try
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest("Restauranthub review", "verify user able to see reviews of restaurants on restauranthub");
                   
                    Reviewbutt revobj = new Reviewbutt();
                    revobj.reviewbutton();
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "review details");
                }
                catch (Exception e)
                {

                    //Logging results
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error in finding review details " + e.Message);

                    //screenshots
                    String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
                    test.Log(LogStatus.Info, "Image example: " + img);

                }
            }
        }
    }
}
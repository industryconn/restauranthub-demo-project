using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauranthub.POM
{
    class Reviewbutt
    {
        public Reviewbutt()
        {
            PageFactory.InitElements(Global.Driver.driver, this);
        }
        [FindsBy(How = How.XPath, Using = ".//*[@id='search_results']/div[1]/div[2]/div/div[2]/h4/a")]
        private IWebElement restaurant { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='reviews-tab']")]
        private IWebElement review { get; set; }

        public void reviewbutton()
        {
            // open the turn up login page. 

            restaurant.Click();
            review.Click();

        }
    }
}

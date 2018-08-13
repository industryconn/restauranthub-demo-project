using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restauranthub.POM
{
    class Restauranthubhome
    {
        public Restauranthubhome()
        {

            PageFactory.InitElements(Global.Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = ".//*[@id='book-tab']")]
        private IWebElement Booktable { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='search-input']")]
        private IWebElement searchbar { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='search-restaurants']/div[2]/input")]
        private IWebElement searchbutton { get; set; }


        public void resthome()
        {
          
           // Global.Driver.driver.Navigate().GoToUrl("https://www.restauranthub.co.nz");
            Booktable.Click();
            searchbar.SendKeys("mt.wellington");
            searchbutton.Click();
        }
    }
}

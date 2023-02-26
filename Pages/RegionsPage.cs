using HybridFwk_POM_SeleniumProject.util;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridFwk_POM_SeleniumProject.BasePage
{
    public class RegionsPage
    {
        private readonly IWebDriver driver;

        public RegionsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement RegionalLeadername => driver.FindElement(By.XPath("(//*[@class='key-contact--profile-details my-lg-3']//a)[1]"));

        //*[@class='field--name body-24 mb-2']


        IWebElement RegionalContact => driver.FindElement(By.XPath("//*[@class='field--job-title mb-2']"));

        IWebElement AlertDialog => driver.FindElement(By.XPath("//*[@id='onetrust-banner-sdk']"));
        IWebElement AlertAllowBtn => driver.FindElement(By.XPath("//button[text()='ALLOW ALL']"));
        IWebElement RegionLandingpageHeader => driver.FindElement(By.XPath("//h1"));

        public bool IsLandingPageCorrect(string country)
        {
            var landingPageText = RegionLandingpageHeader.Text;
            return landingPageText.Contains(country);
        }

        public void RegionsCookieDialog()
        {
            WaitForElement.WaitForElementToBeVisible(driver, AlertDialog);
            AlertAllowBtn.Click();
        }

        public String GetRegionLeaderName()
        {
            if ((RegionalLeadername.Displayed) && (RegionalContact.Displayed))
            {
                String name = RegionalLeadername.Text;
                String title = RegionalContact.Text;
                return "Region leader details : Name -" + name + " Job title -" + title;
                //Console.WriteLine("name-------"+name+"---------"+ title);
            }
            else
            {
                return "RegionLeader info not displayed";
            }
        }


    }
}

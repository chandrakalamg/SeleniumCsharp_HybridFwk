using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridFwk_POM_SeleniumProject.BasePage
{
    public class SearchPage
    {
       private readonly IWebDriver driver;

            public SearchPage(IWebDriver driver)
            {
                this.driver = driver;
            }

        //locators

        IWebElement SearchResultLnkText => driver.FindElement(By.XPath("//*[@class='row event-row']//a"));
        IWebElement SearchResultdisplay => driver.FindElement(By.XPath("//div[contains(text(),'Displaying')]"));


        public String VerifySearchResult(String input)
        {
            String seacrhsstring = SearchResultdisplay.Text;
            //seacrhsstring.Contains("Displaying 0 of 0 results") 
            return seacrhsstring;
        }

        public String VerifysearchLinks()
        {
            String linktext = SearchResultLnkText.Text;
            return linktext;
        }

    }
    }



using AventStack.ExtentReports;
using HybridFwk_POM_SeleniumProject.BasePage;
using HybridFwk_POM_SeleniumProject.util;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace HybridFwk_POM_SeleniumProject.Tests
{
    class HomePageTests : BaseTest
    {
        [Test]
        public void VerifyHomePageTitle()
        {
            ExtentReport.CreateTest($"TestName : VerifyHomePageTitle");
            try
            {
                HomePage homePage = new HomePage(driver);
                homePage.AcceptCookies();
                String homePageTitle = homePage.GetPageTitle();
                Assert.AreEqual("Audit, Tax and Consulting Services | RSM UK", homePageTitle);
                ExtentReport.LogTestStep(Status.Pass, $"Home Page title " + homePageTitle + " Passed successfully");
            }
            catch (AssertionException ex)
            {
                ExtentReport.LogTestStep(Status.Fail, ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                ExtentReport.LogTestStep(Status.Error, ex.Message);
                throw;
            }
        }

        [Test]
        public void PerformSearch()
        {
            ExtentReport.CreateTest($"TestName : PerformSearch");
            try
            {
                HomePage homePage = new HomePage(driver);
                homePage.AcceptCookies();
                homePage.SearchText("Consulting");
                // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                ExtentReport.LogTestStep(Status.Pass,"Search on homepage is successfull");
            }
            catch (AssertionException ex)
            {
                ExtentReport.LogTestStep(Status.Fail, ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                ExtentReport.LogTestStep(Status.Error, ex.Message);
                throw;
            }
        }
    }
}


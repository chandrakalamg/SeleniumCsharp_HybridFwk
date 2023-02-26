using AventStack.ExtentReports;
using HybridFwk_POM_SeleniumProject.BasePage;
using HybridFwk_POM_SeleniumProject.util;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace HybridFwk_POM_SeleniumProject.Tests
{
    class RegionsPageTest : BaseTest
    {

        [Test, TestCaseSource("GetRegionTestData")]
        public void TestRegions(string region)
        {
            ExtentReport.CreateTest($"TestName : TestRegions_{region}");
            try {
                var homePage = new HomePage(driver);
                homePage.AcceptCookies();
                RegionsPage regionsPage = homePage.NavigateToRegionsPage(region);
                regionsPage.RegionsCookieDialog();
                regionsPage.IsLandingPageCorrect(region);
                Assert.That(homePage.GetPageTitle(), Is.EqualTo($"{region} | RSM Global"));
                String leaderdetails = regionsPage.GetRegionLeaderName();
                ExtentReport.LogTestStep(Status.Pass, $"TestRegions_{region} with details passed successfully.");
                ExtentReport.LogTestStep(Status.Pass, leaderdetails);
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
    
        private static IEnumerable<string[]> GetRegionTestData()
        {
            var regionsData = CSVReader.Read("RegionsData.csv").ToList();
            foreach (var regionData in regionsData)
            {
                yield return new[]{regionData["Region"] };
                
            }
            
        }
    }
}

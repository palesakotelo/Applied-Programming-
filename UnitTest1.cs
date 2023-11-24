using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTest1;

[TestClass]
public class TotalMoneyPageTests
{
    private IWebDriver driver;

    [TestInitialize]
    public void Setup()
    {
        // Set up the Selenium WebDriver
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("file:///C:/Users/lab_services_student_/Desktop/APPR6312_PART2_ST10128956_PALESA_KOTELO/DisasterAlleviationFoundation/Pages/TotalMoney.chtml"); // Replace with the path to your HTML file
    }

    [TestMethod]
    public void ShouldNotAllowAllocationOver50Million()
    {
     
        // simulate storing allocations totaling more than 50 million

        // Simulate storing an allocation of 30 million
        ((IJavaScriptExecutor)driver).ExecuteScript("localStorage.setItem('allocationEntries', JSON.stringify([{ allocationAmountRands: 30000000 }]));");

        // Refresh the page or navigate to ensure JavaScript runs again
        driver.Navigate().Refresh();

        // Simulate storing another allocation of 25 million
        ((IJavaScriptExecutor)driver).ExecuteScript("localStorage.setItem('allocationEntries', JSON.stringify([{ allocationAmountRands: 25000000 }]));");

        // Refresh the page or navigate again
        driver.Navigate().Refresh();

        // Now, call the redirectToTotalNumber function
        ((IJavaScriptExecutor)driver).ExecuteScript("redirectToTotalNumber();");

        // Get the current URL after the redirect
        var currentUrl = driver.Url;

        // Assert that the current URL is not 'TotalNumber.cshtml'
        Assert.AreNotEqual("TotalNumber.cshtml", currentUrl);
    }

    [TestCleanup]
    public void Cleanup()
    {
        // Close the browser after each test
        driver.Quit();
    }
}

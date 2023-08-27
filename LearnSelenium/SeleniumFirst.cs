using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace LearnSelenium
{
    public class SeleniumFirst
    {

        IWebDriver driver;

                [SetUp]
        public void StartBrowser()
        {
            //Methods -geturl , click-
            //Commands go through chromedriver.exe on chrome browser
            //Specific version of chrome browser
            //WebDriverManager = compatible chromedriver.exe
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();  //maximizes browser window
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
            driver.Close();  // 1 window closes
            //driver.Quit();  //use for 2 windows or more
        }
    }
}

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
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://rahulshettyacademy.com/#/index";
        }
    }
}

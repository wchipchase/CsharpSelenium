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
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
        }

        [Test]
        public void Test1()
        {
            //driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";
            //driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("rahulshetty");
            driver.FindElement(By.Name("password")).SendKeys("learning");
            //driver.FindElement(By.Name("signin")).Click();
            // css and xpath selectors
            // tagname[attribute = 'value']   (css selector)
            //driver.FindElement(By.CssSelector("input[value='Sign In']")).Click();
            //tagName[@attribute = 'value']
            driver.FindElement(By.XPath("//input[@value='Sign In']")).Click();
            Thread.Sleep(3000);
            String errorMessage = driver.FindElement(By.ClassName("alert")).Text;
            TestContext.Progress.WriteLine(errorMessage);
            IWebElement linkText = driver.FindElement(By.LinkText("Free Access to InterviewQues/ResumeAssistance/Material"));

            String hrefAttribute = linkText.GetAttribute("href");
            //validate url of the linktext
            TestContext.Progress.WriteLine(hrefAttribute);
        }
    }
}
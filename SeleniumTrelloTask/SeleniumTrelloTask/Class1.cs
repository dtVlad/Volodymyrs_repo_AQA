using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTrelloTask
{
    public class Class1
    {
        [Test]
        public static void Test1()
        {
            //Wikipedeia
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");
            driver.Manage().Window.Maximize();

            //Xpath var searchField = driver.FindElement(By.XPath("//input[@id='searchInput']"));
            var searchFieldCss = driver.FindElement(By.CssSelector("[id='searchInput']"));
            searchFieldCss.Click();
            searchFieldCss.SendKeys("USA");

            //Xpath var searchButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            var searchButtonCss = driver.FindElement(By.CssSelector("[type='submit']"));
            searchButtonCss.Click();
            string pageTitle = driver.Title;

            Assert.AreEqual("United States - Wikipedia", pageTitle);
            Assert.AreEqual("https://en.wikipedia.org/wiki/United_States", driver.Url);
            //Xpath IList<IWebElement> Contents = driver.FindElements(By.XPath(".//*[@id='toc']/ul/li/a/span[@class='toctext']"));
            IList<IWebElement> Contents = driver.FindElements(By.CssSelector("[id='toc'] > ul > li > a > span[class='toctext']"));
            Console.WriteLine("The main firt 10 content paragraphs are:\n");

            for (var i = 0; i<10; i++)
            {
                Console.WriteLine(i + 1 + ") " + Contents[i].Text);
            }

            //.Equals(URL, "United States of America");
            //Console.WriteLine(URL);
            //driver.FindElement

            //gmail failed attempt :(
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://mail.google.com/");
            //driver.Manage().Window.Maximize();
            //var Email = driver.FindElement(By.XPath("//input[@type='email']"));
            //Email.Click();
            //Email.SendKeys("autometorvolodymyrtest1@gmail.com");
            //IWebElement button = driver.FindElement(By.XPath("//button[@class = 'VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qIypjc TrZEUc lw1w4b']"));
            //button.Click();
            //Assert.True(driver.FindElement(By.XPath("//div[@class='AxOyFc snByac']")).Displayed);
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            ////IWebElement firstResult = wait.Until(e => e.FindElement(By.CssSelector("input[name='password']")));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElement(By.CssSelector("input[name='password']")).SendKeys("AutoVovaTest123");
            //IWebElement secondResult = wait.Until(e => e.FindElement(By.XPath("//button[@class = 'VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qIypjc TrZEUc lw1w4b']")));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            //driver.FindElement(By.XPath("//div[ @id = 'passwordNext']")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            //string emailsFrom = driver.FindElement(By.XPath("//span[@name]")).Text;
            //IWebElement emailsTittle = driver.FindElement(By.XPath("//span[@data-legacy-last-non-draft-message-id]"));
            //Console.WriteLine(emailsFrom);
            //for (var i = 0; i < 10; i++)

            //Console.WriteLine(emailsTittle);



            //driver.FindElement(By.CssSelector("input[type='password']")).SendKeys("AutoVovaTest123");
            /*WebDriverWait wait = new WebDriverWait(gmail, 10);
            WebElement element = wait.until(
                ExpectedConditions.visibilityOfElementLocated(By.id("Passwd")));
            gmail.findElement(By.id("Passwd")).sendKeys("xyz");
            driver.FindElement(By.CssSelector("input[type='password']")).SendKeys("AutoVovaTest123");
            driver.FindElement(By.XPath("//button[@class = 'VfPpkd-LgbsSe VfPpkd-LgbsSe-OWXEXe-k8QpJ VfPpkd-LgbsSe-OWXEXe-dgl2Hf nCP5yc AjY5Oe DuMIQc qIypjc TrZEUc lw1w4b']")).Click();

            //driver.Close();
            //driver.Quit();
            */
        }

    }
}

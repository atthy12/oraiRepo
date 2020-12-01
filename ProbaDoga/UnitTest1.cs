using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ProbaDoga
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver dw = new FirefoxDriver();

            dw.Navigate().GoToUrl("http://atthy4.atspace.cc/Probadoga.html");
            dw.Manage().Window.Maximize();
            //1. feladat
            dw.FindElement(By.LinkText("DevOps 2")).Click();

            dw.Navigate().Back();

            //2. feladat
            IWebElement the_checkbox = dw.FindElement(By.Id("checkbox_car"));
            if (!the_checkbox.Selected)
            {
                the_checkbox.Click();
            }

            Assert.IsTrue(the_checkbox.Selected);


            //3. feladat
            IWebElement elem = dw.FindElement(By.Name("test_framework"));
            SelectElement select = new SelectElement(elem);
            select.SelectByIndex(1);
            select.SelectByIndex(2);
            Assert.AreEqual(2, select.AllSelectedOptions.Count);

            //4. feladat
            elem = dw.FindElement(By.XPath("/html/body/button"));
            elem.Click();
            Assert.AreEqual("Minden Pontot megszerzek", dw.Title);


            //5. feladat
            dw.FindElement(By.XPath("/html/body/img")).Click();



        }
    }
}

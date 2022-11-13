using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumThirdTest
{
    public class Program
    {
      
            IWebDriver drive = new ChromeDriver();
            static void Main(string[] args)
            {



            }
            [SetUp]
            public void Inicijalizacija()
            {
                drive.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
                drive.Manage().Window.Maximize();
            }
            [Test]

            public void Test1()
            {
                IWebElement firstName = drive.FindElement(By.Id("firstName"));
                firstName.SendKeys("Ana");

                IWebElement lastName = drive.FindElement(By.Id("lastName"));
                lastName.SendKeys("Vuco");

                IWebElement email = drive.FindElement(By.Id("userEmail"));
                email.SendKeys("anavuco@gmail.com");


            }
        [TearDown]
        public void Close()
        {

            drive.Quit();
        }

    }
}

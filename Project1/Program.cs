using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            // launch turn up portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            // identify username text box and enter valid credentials
            IWebElement userName = driver.FindElement(By.Id("UserName"));
            userName.SendKeys("hari");
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");


            //driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();


            Console.WriteLine("Press enter to exit!");

            // identify password textbox and enter valid password
            // identify login botton and click
            // check if user logged in successfully

        }
    }
}

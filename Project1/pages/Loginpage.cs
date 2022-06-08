using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Loginpage
    {
        public void Loginsteps(IWebDriver driver)
        { 
         // maximise the window
        driver.Manage().Window.Maximize();
         // launch turn up portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            try
            {


                // identify username text box and enter valid credentials
                IWebElement userName = driver.FindElement(By.Id("UserName"));
                userName.SendKeys("hari");

                // identify password textbox and enter valid password
                IWebElement password = driver.FindElement(By.Id("Password"));
                password.SendKeys("123123");

                // identify login botton and click
                driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("Turnup Portal page did not launch.", ex.Message);
            }
        
            
        }

      
    }
}

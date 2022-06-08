using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Utilities
{
    class CommonDriver
    {
        public  IWebDriver driver;


        Loginpage loginpageobj = new Loginpage();
        
        [OneTimeSetUp]
        public void LoginActions()
        {
            // open chrome browser
            driver = new ChromeDriver();

            //Loginpage object intialization and defining

            loginpageobj.Loginsteps(driver);

            
        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }



    }
}

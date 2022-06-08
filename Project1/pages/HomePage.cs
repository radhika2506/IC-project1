using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Homepage
    {
        public void GoToTMpage(IWebDriver driver)
        {
            // click on administration tab
            IWebElement administrationtab = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            administrationtab.Click();

            // select time and material from the drop down
            IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();
        }
        public void GoToEmployeePage(IWebDriver driver)
        {
            //navigate to employee page
        }

    }
}

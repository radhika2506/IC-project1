using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project1
{
    class TMpage
    {
        public void CreateTM(IWebDriver driver)
        {
            //click on createnew button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span")).Click();
            Thread.Sleep(2000);
            //select material from the typecode dropdown
            driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']")).Click();
            // find the code textbox and input a code
            IWebElement codetextbox = driver.FindElement(By.Id("Code"));
            codetextbox.SendKeys("1234");

            //find the description textbox and input a code
            IWebElement descriptiontextbox = driver.FindElement(By.Id("Description"));
            descriptiontextbox.SendKeys("m1234");

            //find price per unit textbox and input a code
            IWebElement priceInputTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceInputTag.Click();


            IWebElement pricetagtextbox = driver.FindElement(By.Id("Price"));
            pricetagtextbox.SendKeys("100");
            // click on save button
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(1500);// click on go to last page of the record
            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpage.Click();
            Thread.Sleep(1000);
            //check if new maretial record has created
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "m1234")
            {
                Console.WriteLine("New material record created successfully.");
            }
            else
            {
                Console.WriteLine("Material record hasn't been created.");
            }

        }

        //find the editbutton  and click 
        public void EditTM(IWebDriver driver)
        {
            IWebElement editbutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[3]/td[5]/a[1]"));
            editbutton.Click();
            Thread.Sleep(1000);
            // edit the time and material page
            // find codetextbox and clear data and edit

            IWebElement codetextedit = driver.FindElement(By.Id("Code"));
            codetextedit.Clear();
            codetextedit.SendKeys("xyz123");
            Thread.Sleep(1000);

            //find description textbox and clear and edit data
            IWebElement descTextBox = driver.FindElement(By.Id("Description"));
            descTextBox.Clear();
            descTextBox.SendKeys("project");

            //find priceperunit text box clear and edit the price
            IWebElement pPerUnitTextBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            pPerUnitTextBox.Click();
            IWebElement pPerUnitEditBox = driver.FindElement(By.Id("Price"));
            pPerUnitEditBox.Clear();
            pPerUnitTextBox.SendKeys("250");

            //find save button and click 
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);


            // goto click last page
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();

            //checkif upadated data has created
            IWebElement editCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (editCode.Text == "project")
            {
                Console.WriteLine("New material record created successfully.");
            }
            else
            {
                Console.WriteLine("Material record hasn't been created.");
            }
            Thread.Sleep(3000);
        }





        public void DeleteTM(IWebDriver driver)
        {
            ////find the deletebutton and click
            IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[3]/td[5]/a[2]"));
            deletebutton.Click();
            Thread.Sleep(2000);
            Console.WriteLine("Delete button clicked");

            //click ok button
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);



        }




    }
}

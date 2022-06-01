using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

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

            // identify password textbox and enter valid password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            // identify login botton and click
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();

            // check if user logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Login failed, test failed.");
            }

            //click on administration tab
            IWebElement administrationtab = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            administrationtab.Click();
            // select time and material from the drop down
            IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();
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
            Thread.Sleep(1500);
            // click on go to last page of the record
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

            ////click on administration tab
            //IWebElement administrationtab = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / a"));
            //administrationtab.Click();
            //// select time and material from the drop down
            //IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            //tmoption.Click();
            ////click on createnew button
            //driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            //driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span")).Click();
            //Thread.Sleep(2000);

            //IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]"));
            //typeCodeDropdown.Click();
            //Thread.Sleep(1500);


            ////Find code Textbox element to enter new value
            //IWebElement codeBox = driver.FindElement(By.Id("Code"));
            //codeBox.SendKeys("code123");

            ////Find Description Textbox element to enter new value
            //IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            //descriptionTextbox.SendKeys("descrip123");


            ////Find Price per unit textbox to enter new value
            //IWebElement pPUTextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            //pPUTextbox.Click();

            //IWebElement pPUInputTextbox = driver.FindElement(By.Id("Price"));
            //pPUInputTextbox.SendKeys("12");

            ////Find Save element and click
            //IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            //saveButton.Click();
            //Thread.Sleep(1000);

            ////Select gotolastpage(>|) icon

            //IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            //goToLastPage.Click();
            //Thread.Sleep(2500);

            ////Confirm the creation of new row

            //IWebElement newRow = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            ////Thread.Sleep(3500);                               

            //if (newRow.Text == "code123")
            //{
            //    Console.WriteLine("Row created Successfully,Test Passed.");
            //}
            //else
            //{
            //    Console.WriteLine("Failed to create a New Row, Test Failed.");
            //}
            //Thread.Sleep(1500);

            //find the editbutton  and click //*[@id="tmsGrid"]/div[3]/table/tbody/tr[3]/td[5]/a[1]
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

            ////find the deletebutton and click
            IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[10]/td[5]/a[2]"));
            deletebutton.Click();
            IAlert OKButton = driver.SwitchTo().Alert();
            OKButton.Accept();
            Thread.Sleep(500);

        }
    }
}

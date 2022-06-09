using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace Project1
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        { 
           
            //click on createnew button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span")).Click();
            Thread.Sleep(2000);
            //select material from the typecode dropdown
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]")).Click();

            // find the code textbox and input a code
            IWebElement codetextbox = driver.FindElement(By.Id("Code"));
            codetextbox.SendKeys("1234");

            //find the description textbox and input a code
            IWebElement descriptiontextbox = driver.FindElement(By.Id("Description"));
            descriptiontextbox.SendKeys("selenium1");

            //find price per unit textbox and input a code
            IWebElement priceInputTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceInputTag.Click();


            IWebElement pricetagtextbox = driver.FindElement(By.Id("Price"));
            pricetagtextbox.SendKeys("10");
            // click on save button
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(1500);

            // click on go to last page of the record
            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpage.Click();
            Thread.Sleep(2000);

            //check if new maretial record has created
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement newTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            //Assertion
            Assert.That(newCode.Text == "1234", "Actualcode and Expected Code do not match");
            Assert.That(newTypeCode.Text == "M", "Actual Typecode and Expected Typecode do not match");
            Assert.That(newDescription.Text == "selenium1", "Actual description and Expected description do not match");
            Assert.That(newPrice.Text == "$10.00", "Actual price and Expected price do not match");
        }

        //Identify the editbutton and click 
        public void EditTM(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement goToLastPageBtn = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn.Click();
            Thread.Sleep(2000);

            IWebElement findNewRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

            if (findNewRecord.Text == "selenium1")
            {

                // Click on the Edit Button
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(1000);
            }
            else
            {
                Assert.Fail("edited Record not found.");
            }


            // Click on "TypeCode" from dropdown list and set the Type Code
            IWebElement typeCodeDropdown1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown1.Click();
            Thread.Sleep(1000);

            IWebElement selectMaterial = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            selectMaterial.Click();
            Thread.Sleep(1000);


            // Identify the codetextbox and clear data and edit

            IWebElement codetextedit = driver.FindElement(By.Id("Code"));
            codetextedit.Clear();
            codetextedit.SendKeys("xyz123");
            Thread.Sleep(1000);

            //Identify the description textbox and clear and edit data
            IWebElement descTextBox = driver.FindElement(By.Id("Description"));
            descTextBox.Clear();
            descTextBox.SendKeys("project");

            //Identify the priceperunit text box clear and edit the price
            IWebElement pPerUnitTextBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            pPerUnitTextBox.Click();
            IWebElement pPerUnitEditBox = driver.FindElement(By.Id("Price"));
            pPerUnitEditBox.Clear();
            pPerUnitTextBox.SendKeys("250");

            //Identify the save button and click 
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            // Assert that Time record has been edited.
            IWebElement goToLastPageBtn1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn1.Click();
            Thread.Sleep(2000);

            IWebElement newCodeCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            // Assertion
            Assert.That(newCodeCreated.Text != " xyz123", "Actual code and expected code do not match.");
        }  
        public void DeleteTM(IWebDriver driver)
        {
            Thread.Sleep(1500);
            IWebElement goToLastPageBtn = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn.Click();
            Thread.Sleep(2000);

            // Click on the Delete Button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(2000);

            driver.SwitchTo().Alert().Accept();

            // Assert that Time record has been deleted.
            IWebElement goToLastPageBtn1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageBtn1.Click();
            Thread.Sleep(2000);

            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            // Assertion
            Assert.That(editedCode.Text == "xyz123", "Time and material record hasn't been deleted succesfully.");


        }

    }
}

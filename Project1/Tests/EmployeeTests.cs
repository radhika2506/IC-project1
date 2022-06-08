using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Project1.pages;
using Project1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Tests
{
    [TestFixture]
    [Parallelizable]
    class EmployeeTests : CommonDriver
    {
        //page object Initialization
        
        Homepage homepageobj = new Homepage();
        EmployeePage employeePageobj = new EmployeePage();

        [Test]
        public void CreateEmployee()
        {
            homepageobj.GoToEmployeePage(driver);
            //Employee page Initialization
            employeePageobj.CreateEmployee(driver);

        }
        [Test]
        public void EditEmployee()
        {
            homepageobj.GoToEmployeePage(driver);


            employeePageobj.EditEmployee(driver);

        }
        [Test]
        public void DeleteEmloyee()
        {
            homepageobj.GoToEmployeePage(driver);

            employeePageobj.DeleteEmployee(driver);

        }


    }
}

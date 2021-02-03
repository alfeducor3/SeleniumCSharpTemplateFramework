using CrossPlatformEATest.Pages;
using EAAutoFramework.Base;
using OpenQA.Selenium;
using System;

namespace EAEmployeeTest.Pages
{
    internal class EmployeeListPage : BasePage
    {

        public EmployeeListPage(ParallelConfig parallelConfig) : base(parallelConfig)
        {

        }

        IWebElement txtSearch => _parallelConfig.Driver.FindElement(By.Name("searchTerm"));

        IWebElement lnkCreateNew => _parallelConfig.Driver.FindElement(By.LinkText("Create New"));

        IWebElement tblEmployeeList => _parallelConfig.Driver.FindElement(By.ClassName("table"));

        IWebElement lnkLogoff => _parallelConfig.Driver.FindElement(By.LinkText("Log off"));

        IWebElement lnkCreateNews => _parallelConfig.Driver.FindElement(By.LinkText("Create News"));


        public CreateEmployeePage ClickCreateNew()
        {
            lnkCreateNew.Click();
            return new CreateEmployeePage(_parallelConfig);
        }

        public IWebElement GetEmployeeList()
        {
            return tblEmployeeList;
        }

        internal void ClickLogoff()
        {
            lnkLogoff.Click();
        }

        internal BasePage ClickCreateNews()
        {
            lnkCreateNews.Click();
            return new CreateEmployeePage(_parallelConfig);
        }
    }
}

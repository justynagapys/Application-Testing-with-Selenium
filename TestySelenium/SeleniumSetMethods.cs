using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestySelenium
{
    class SeleniumSetMethods
    {
        //enter text
        public static void enterText(string name, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(name)).SendKeys(value);
            if (elementType == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(name)).SendKeys(value);
            if (elementType == PropertyType.ClassName)
                PropertiesCollection.driver.FindElement(By.ClassName(name)).SendKeys(value);
        }

        public static void click(string name, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(name)).Click();
            if (elementType == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(name)).Click();
            if (elementType == PropertyType.ClassName)
                PropertiesCollection.driver.FindElement(By.ClassName(name)).Click();
        }

        //dropdown
        public static void selectDropdown(string name, string value, PropertyType elementType)
        {
            if (elementType == PropertyType.Id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(name))).SelectByText(value);
            if (elementType == PropertyType.Name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(name))).SelectByText(value);
            if (elementType == PropertyType.ClassName)
                new SelectElement(PropertiesCollection.driver.FindElement(By.ClassName(name))).SelectByText(value);
        }
    }
}

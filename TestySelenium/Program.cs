using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestySelenium
{
    class Program
    {
        //referencja do przeglądarki
        //IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            //otworzymy stronę google
            PropertiesCollection.driver.Navigate().GoToUrl("https://nostalgic-bartik-b23e56.netlify.app/login.html");
            Console.WriteLine("Otwarto URL");
        }

        [Test]
        public void ExecuteTest()
        {
            ////przekazujemy tekst 'koronowirus' do inputa o nazwie q
            //IWebElement element = driver.FindElement(By.Name("q")); //próbuję uchwycić element, do którego za chwilę coś wrzucę
            //element.SendKeys("koronowirus"); //wrzucam wybrany przeze mnie tekst do wybranego elementu
            //Console.WriteLine("Wpisano koronowirus do Google");

            ////tytuł
            //SeleniumSetMethods.selectDropdown("TitleId", "Ms.", PropertyType.Id);
            //Console.WriteLine("Tytuł: " + SeleniumGetMethods.GetTextFromDropDownList("TitleId", PropertyType.Id));

            ////initial
            //SeleniumSetMethods.enterText("Initial", "Ala ma kota", PropertyType.Name);
            //Console.WriteLine("Inicjały to: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            ////kliknięcie na Save
            //SeleniumSetMethods.click("Save", PropertyType.Name);

            //zainicjuje stronę wywołując referencję
            //IndexPageObject page = new IndexPageObject();
            //page.txtInitial.SendKeys("Ala ma kota");
            //page.btnSave.Click();

            //logowanie
            LoginPageObject pageLogin = new LoginPageObject();
            IndexPageObject pageIndex = pageLogin.Login("test", "test");
            pageIndex.FillUserForm("OK", "Gapys", "Justyna");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close(); //zamyka przeglądarkę
            Console.WriteLine("Zamknięto Chrome");
        }
    }
}

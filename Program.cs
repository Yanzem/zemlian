using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Selenium
{

    class Test

    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]

        public void Initialize()

        {
            // driver.Navigate().GoToUrl("http://www.google.com");

        }

        [Test]
        public void Test_1()

        {
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("Вікіпедія");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            driver.FindElement(By.LinkText("Вікіпедія")).Click();
            Assert.AreEqual("Вікіпедія", driver.Title);

        }

        [Test]
        public void Test_2()
        {
            driver.Navigate().GoToUrl("https://uk.wikipedia.org/wiki");
            Assert.AreEqual("Вікіпедія", driver.Title);
            DateTime currentTime = DateTime.Now;
            string textToCheck = driver.FindElement(By.LinkText(currentTime.ToString("d MMMMM"))).Text;
            Assert.AreEqual(currentTime.ToString("d MMMMM"), textToCheck);
        }

        [Test]
        public void Test_3()
        {
            driver.Navigate().GoToUrl("https://uk.wikipedia.org/wiki");
            Assert.AreEqual("Вікіпедія", driver.Title);
            driver.FindElement(By.LinkText("Поточні події")).Click();
            Assert.AreEqual("Вікіпедія:Поточні події - Вікіпедія", driver.Title);
            IWebElement news = driver.FindElement(By.XPath("//a[@href='/wiki/%D0%92%D1%96%D0%BA%D1%96%D0%BF%D0%B5%D0%B4%D1%96%D1%8F:%D0%9F%D0%BE%D1%82%D0%BE%D1%87%D0%BD%D1%96_%D0%BF%D0%BE%D0%B4%D1%96%D1%97'][contains(text(),'Поточні події')]"));
            Assert.IsTrue(news.Text.Contains("Рада Безпеки ООН скликає екстренне засідання"));
        }

        [Test]
        public void TEST_4()
        {
            driver.Navigate().GoToUrl("https://uk.wikipedia.org/wiki");
            Assert.AreEqual("Вікіпедія", driver.Title);
            driver.FindElement(By.Name("search")).SendKeys("testing");
            driver.FindElement(By.Name("go")).Click();
            Assert.AreEqual("Результати пошуку для «Testing»- Вікіпедія", driver.Title);
            driver.FindElement(By.LinkText("Pairwise testing")).Click();
            Assert.AreEqual("Pairwise testing- Вікіпедія", driver.Title);
        }

        [TearDown]
        public void CleanUp()
        {
            //driver.Close();
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using test.Helpers;

namespace test.Fixtures
{
    public class TestFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        //Setup
        public TestFixture()
        {
            Driver = new ChromeDriver(TestHelper.PastaDoExecutavel);
        }

        //TearDown
        public void Dispose()
        {
            Driver.Quit();
        }
    }
}

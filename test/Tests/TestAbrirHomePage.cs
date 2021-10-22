using OpenQA.Selenium;
using test.Fixtures;
using test.PageObjects;
using Xunit;
using Xunit.Priority;

namespace test.Tests
{
    [TestCaseOrderer("FullNameOfOrderStrategyHere", "OrderStrategyAssemblyName")]
    [Collection("Chrome Driver")]
    public class TestAbrirHomePage
    {
        private IWebDriver driver;
        private HomePage navegar;

        //Setup
        public TestAbrirHomePage(TestFixture fixture)
        {
            driver = fixture.Driver;
            navegar = new HomePage(driver);
        }

        [Fact, Priority(0)]
        public void DadoChromeAbertoIrParaHomePage()
        {
            navegar.OpenPage();
        }
    }
}

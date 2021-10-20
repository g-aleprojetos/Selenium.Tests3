using OpenQA.Selenium;
using test.Fixtures;
using Xunit;
using Xunit.Priority;

namespace test.PageObjects
{
    public class HomePage
    {
        [Collection("Chrome Driver")]
        [TestCaseOrderer(PriorityOrderer.Name, PriorityOrderer.Assembly)]
        public class AoNavegarParaHome
        {
            private IWebDriver driver;

            //Setup
            public AoNavegarParaHome(TestFixture fixture)
            {
                driver = fixture.Driver;
            }

            [Fact, Priority(1)]
            public void DadoChromeAbertoDeveMostrarLeiloesNoTitulo()
            {
                //arrange

                //act
                driver.Navigate().GoToUrl("http://localhost:5000");

                //assert
                Assert.Contains("Leilões", driver.Title);
            }
        }
    }
}

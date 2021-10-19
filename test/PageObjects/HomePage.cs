using OpenQA.Selenium;
using test.Fixtures;
using Xunit;

namespace test.PageObjects
{
    public class HomePage
    {
        [Collection("Chrome Driver")]
        public class AoNavegarParaHome
        {
            private IWebDriver driver;

            //Setup
            public AoNavegarParaHome(TestFixture fixture)
            {
                driver = fixture.Driver;
            }

            [Fact]
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

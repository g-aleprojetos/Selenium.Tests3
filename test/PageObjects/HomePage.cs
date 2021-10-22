using OpenQA.Selenium;
using test.Dados;

namespace test.PageObjects
{
    public class HomePage
    {
        IWebDriver driver;
        private DadosGerais dados;

      public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            dados = new DadosGerais();
        }

        public HomePage OpenPage()
        {

            driver.Navigate().GoToUrl(dados.URL);
            return this;
        }

    }
}

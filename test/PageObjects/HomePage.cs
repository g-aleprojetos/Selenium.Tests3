using OpenQA.Selenium;
using test.Dados;

namespace test.PageObjects
{
    public class HomePage
    {
        IWebDriver driver;
        private DadosGerais dados;

      public HomePage()
        {
            dados = new DadosGerais();
        }

        public void OpenPage()
        {

            driver.Navigate().GoToUrl(dados.URL);

        }

    }
}

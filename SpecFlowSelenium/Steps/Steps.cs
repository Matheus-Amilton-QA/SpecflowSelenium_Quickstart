

using SpecFlowSelenium.Support;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowSelenium.Steps
{
    [Binding]
    public class Steps
    {
        public SeleniumHelper browser;
        public Steps(ScenarioContext scenarioContext)
        {
            browser = SeleniumHelper.Instance(scenarioContext);
        }


        //"Dado" do exemplo
        [Given(@"que o usuário faz login")]
        public void DadoQueOUsuarioFazLogin()
        {
            //Diz para o selenium abrir a pagina do SUT
            browser.NavegarParaUrl(ConfigurationHelper.SiteUrl);
            //Da 2 segundos de pausa para o sistema fazer qualquer tipo de processo e a thread nao se atrapalhar
            Thread.Sleep(2000);

            //Clica no botao de login
            browser.ClicarBotaoPorId("login2");
            //Espera o popup carregar
            browser.EsperarPorCSS("div[id='logInModal'] > div > div > div:nth-of-type(1)");
            //Preenche campos com usuario e loga
            browser.PreencherTextBoxPorId("loginusername", ConfigurationHelper.TestUserName);
            browser.PreencherTextBoxPorId("loginpassword", ConfigurationHelper.TestPassword);
            browser.ClicarBotaoPorCSS("div[id='logInModal'] > div > div > div:nth-of-type(3) > button:nth-of-type(2)");

            //Verifica se realmente esta logado
            browser.EsperarPorId("nameofuser");
            //Da mais dois segundos antes da proxima etapa
            Thread.Sleep(2000);
        }

        [When(@"navega à página de produto do Samsung Galaxy s(.*)")]
        public void DadoNavegaAPaginaDeProdutoDoSamsungGalaxyS(int p0)
        {
            //clica no link do nome do produto
            browser.ClicarLinkPorTexto("Samsung galaxy s6");

            //espera por info da pagina carregar
            browser.EsperarPorId("more-information");

            Thread.Sleep(2000);
        }

        [Then(@"clica no botão de Add to Cart")]
        public void QuandoClicaNoBotaoDeAddToCart()
        {
            browser.ClicarLinkPorTexto("Add to cart");
            Thread.Sleep(2000);

            //aqui eh tirado uma foto da tela e salvo na pasta /bin/screenshots
            browser.ObterScreenShot("NoCarrinho");
        }

    }
}

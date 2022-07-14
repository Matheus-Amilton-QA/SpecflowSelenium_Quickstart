# SpecflowSelenium_Quickstart
 Quickstart para começar a automatizar com Specflow e Selenium.
 
 Antes de copiar esse projeto é necesssário:
  - Fazer o curso de specflow no link: https://specflow.org/school/getting-started-with-specflow-in-visual-studio/
  - Ler sobre como selenium funciona no link: https://www.selenium.dev/documentation/
  - Instalar o Visual Studio 2019
  - Instalar a extensão do Specflow no VS2019
  
 Esse projeto contém algumas pastas, cada um com sua função, elas são:
  - Features: que deve conter vários arquivos tipo .feature, com os cenários de teste em BDD
  - Steps: Onde será escrito o código de execução dos teste
  - Hooks: Onde é configurado tudo que é pra executar antes e depois de todos os testes
  - Support: Onde todos os arquivos de suporte para escrita de testes estão, notávelmente o SeleniumHelper, onde estará elaborado as classes utilizadas para refinar as classes default do selenium para funcionarem de forma mais suave.
  
 Para melhor entendimento do projeto há um caso de exemplo e comentários em todos os arquivos para demonstrar como tudo funciona.
 
 O seu fluxo para criar seu priomeiro caso de testes automatizado deve ser:
  1. Configurar o arquivo de configuração para seu SUT;
  2. Criar um arquivo .feature na pasta features e escrever seu caso de teste de forma sucinta e que os passos possam ser reutilizados;
  3. Criar suas Steps descritas na feature no arquivo de Steps.
  4. Escrever os comandos dentro dos casos e ir executando a automação de forma incremental até que tudo esteja funcionando.
  
  
 Recomendações:
  - Usar Plugin Page Modeller para o chrome, irá ser mais fácil de conseguir os melhores endereços para os componentes a serem manipulados.
  - Baixar o plugin do VS2019 para salvar o código automaticamente a cada 5 minutos.
  - Versionar TUDO, assim nenhum trabalho é perdido.

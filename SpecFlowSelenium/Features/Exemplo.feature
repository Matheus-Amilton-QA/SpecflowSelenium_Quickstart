#language: pt-BR
Funcionalidade: Exemplo de Feature
	Essa é uma feature de exemplo para demonstrar essa estrutura de Specflow e Selenium funcionando

@AdicionarAoCarrinho @Loja
Cenário: Adicionar Celular ao Carrinho
	Dado que o usuário faz login
	Quando navega à página de produto do Samsung Galaxy s6
	Então clica no botão de Add to Cart
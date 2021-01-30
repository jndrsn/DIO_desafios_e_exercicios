programa
{
	
	funcao inicio()
	{

		real janeiro, fevereiro, marco, abril, media, total
		cadeia nome

		escreva("Qual o nome do vendedor :")
		leia(nome)
		
		escreva("Qual o total de vendas do mes de JANEIRO ?")
		leia(janeiro)
		
		escreva("Qual o total de vendas do mes de FEVEREIRO ?")
		leia(fevereiro)
		
		escreva("Qual o total de vendas do mes de MARCO ?")
		leia(marco)
		
		escreva("Qual o total de vendas do mes de ABRIL ?")
		leia(abril)

		media = (janeiro+fevereiro+marco+abril)/4
		total = (janeiro+fevereiro+marco+abril)

		escreva("O funcionário " +nome + ", vendeu nesses quatro meses o valor de R$" +total + ", uma média de R$" +media + " por mês!!")
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 581; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
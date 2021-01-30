programa
{
	
	funcao inicio()
	{
		inteiro contador, limite, resultado, numero

		contador = 0

		escreva("A TABUADA DE QUAL NUMERO VOCÊ DESEJA ? ")
		leia(numero)

		escreva("\n QUAL O LIMITE DE CALCULO DA SUA TABUADA DE " + numero + " ? ")
		leia(limite)

		faca{
					
			resultado = numero * contador
			escreva(numero + " X " + contador + " = " + resultado + "\n")
			contador++
						
		}enquanto(contador<=limite)
			
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 262; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
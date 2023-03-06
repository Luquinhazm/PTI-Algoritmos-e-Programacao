# PTI-Algoritmos-e-Programacao

Criação de um algoritmo que ajude o usuário na decisão que se abastece usando gasolina ou álcool usando a linguagem de programação C# 

## Algoritmo

``` c#![Captura de tela 2023-03-05 213141](https://user-images.githubusercontent.com/90008972/222998282-f5fea6a9-1b71-404b-9614-245c16e59bad.png)


using System;

class GasolinaOuAlcool
{
    public static void Main(string[] args)
    {
        string operacao = "sim"; // para que comece já entrando no loop while
        while (operacao.Equals("sim")) // entra no loop enquanto a variável operação for sim
        {  
            Console.Write("O preço da gasolina: "); // pede o preço da gasolina ao usuário
            double gasolina = double.Parse(Console.ReadLine()); // salva a entrada na variável gasolina do tipo double 
            Console.Write("O preço do Alcool: "); // pede o preço do álcool ao usuário
            double alcool = double.Parse(Console.ReadLine()); // salva a entrada na variável alcool do tipo double 
            double valor = Math.Round(alcool / gasolina, 2); // divide os valores, arredonda em 2 decimais e armazena na double valor
            Console.WriteLine("Valor = {0:N2}", valor); // mostra o valor para o usuário
            if (valor > 0.7) { // se maior de 0.7 mostra para abastece com gasolina
                Console.WriteLine("Abasteça com gasolina");
            } else if (valor < 0.7) { // se menor de 0.7 mostra para abastece com gasolina
                Console.WriteLine("Abasteça com Alcool");
            } else if (valor > 0.699 && valor < 0.701)  // se igual a 0.7 mostra para que tanto faz o tipo de combustivel
            {
                Console.WriteLine("Tanto faz, Alcool ou Gasolina");
            }
           
            Console.Write("Deseja realizar um novo cálculo (sim/não): "); // pergunta se o usuário quem fazer outra operação
            operacao = Console.ReadLine().ToLower(); // armazena na variável a decisão do usuário para definir se faz, ou não, outra operação
        }
        Console.WriteLine("Operação Encerrada!"); // se o usuário decidir que não, encerra o programa
    }
}


```

## Exemplos de Resultado

![Captura de tela 2023-03-05 213141](https://user-images.githubusercontent.com/90008972/222998339-c8898e75-c60a-4bbf-bd30-4a68c3e7e6da.png)

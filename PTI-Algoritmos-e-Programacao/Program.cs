using System;

class GasolinaOuAlcool
{
    public static void Main(string[] args)
    {
        string operacao = "sim"; // Para que comece já entrando no loop while
        while (operacao.Equals("sim")) // entra no loop enquanto a variavel operacao for sim
        {  
            Console.Write("O preço da gasolina: "); // Pede o preço da gasolina ao usuário
            double gasolina = double.Parse(Console.ReadLine()); // Salva a entrada na variável gasolina do tipo double 
            Console.Write("O preço do Alcool: "); // Pede o preço do alcool ao usuário
            double alcool = double.Parse(Console.ReadLine()); // Salva a entrada na variável alcool do tipo double 
            double valor = Math.Round(alcool / gasolina, 2); // Divide os valores, arredonda em 2 decimais e amazena na double valor
            Console.WriteLine("Valor = {0:N2}", valor); // mostra o valor para o usuário
            if (valor > 0.7) { // se maior de 0.7 mostra para abastece com gasolina
                Console.WriteLine("Abasteça com gasolina");
            } else if (valor < 0.7) { // se menor de 0.7 mostra para abastece com gasolina
                Console.WriteLine("Abasteça com Alcool");
            } else if (valor > 0.699 && valor < 0.701)  // se igual a 0.7 mostra para que tanto faz o tipo de combustivel
            {
                Console.WriteLine("Tanto faz, Alcool ou Gasolina");
            }
           
            Console.Write("Deseja realizar um novo cálculo (sim/não): "); // pergunta se o usuario quem fazer outra operação
            operacao = Console.ReadLine().ToLower(); // armazena na variavel a decisão do usuario para definir se faz, ou não, outra operação
        }
        Console.WriteLine("Operação Encerrada!"); // se o usuario decidir que não, encerra o programa
    }
}

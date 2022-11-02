using System;
namespace questao08;
    internal class Program
{
        
    static void Main(string[] args)
        
    {
        for(int i = 0; i<3; i++) 
        {
            Console.WriteLine();
            Console.WriteLine("Informe os dados para o Investimento");
            Console.WriteLine();
            Console.WriteLine("Digite o valor do Investimento: ");
            Double investimento = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da Taxa de juros (a.m): ");
            Double taxa = double.Parse(Console.ReadLine());
            Console.WriteLine();

            CalculaEPrintaRendimento(investimento, taxa);
        }       
   
    }
    private static void CalculaEPrintaRendimento(double valorPresente,double taxaDeJuros)
    {

        Banco_ banco = new Banco_(valorPresente, taxaDeJuros);
        banco.PrintaTabela();
        for (int i = 1; i <= 8; i++)
        {
            banco.RendeMes();
        }

        banco.RendePeriodo(10);
    }
}
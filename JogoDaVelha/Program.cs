using System;

class Program
{
    static void DesenharTabuleiro(char[,] tab)
    {
        Console.WriteLine(" 0  1  2 ");
        Console.WriteLine($"0 {tab[0,0]}|{tab[0,1]}|{tab[0,2]}");
        Console.WriteLine("---+---+---");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
    static void Main()
    {
        char[,] tabuleiro = new char[3, 3]
        {
            {' ', ' ', ' '},
            {' ', ' ', ' '},
            {' ', ' ', ' '}
        };

        char JogadorAtual = 'X';
        bool jogoAtivo = true; 
        int jogadasRealizadas = 0;


        
    }
    
}

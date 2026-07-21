using System;

class Program
{
    static void DesenharTabuleiro(char[,] tab)
    {
        Console.WriteLine(" 0  1  2 ");
        Console.WriteLine($"0 {tab[0,0]}|{tab[0,1]}|{tab[0,2]}");
        Console.WriteLine("---+---+---");
        Console.WriteLine($"1 {tab[1,0]}|{tab[1,1]}|{tab[1,2]}");
        Console.WriteLine("---+---+---");
        Console.WriteLine($"2 {tab[2,0]}|{tab[2,1]}|{tab[2,2]}");

        
    }
    static bool ChecarVitoria(char[,]  tab, char j, char i)
    {
        for (i = 0; i < 3; i++)
        {
            
        }
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

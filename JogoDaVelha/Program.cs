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
        for (int i = 0; i < 3; i++)
        {
             if (tab[i, 0] == j && tab[i, 1] == j && tab[i, 2] == j) return true;
        }

        for (int i = 0; i < 3; i++)
        {
            if (tab[0, i] == j && tab[1, i] == j && tab[2, i] == j) return true;
        }
        if (tab[0, 0] == j && tab[1, 1] == j && tab[2, 2] == j) return true;
        if (tab[0, 2] == j && tab[1, 1] == j && tab[2, 0] == j) return true;

        return false;
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

string[,] tabuleiro = new string[3, 3];
string jogadoro = "O";
string jogadorx = "X";
string jogadoratual = jogadorx;
int linha, coluna;
bool fimdejogo = false;
while (!fimdejogo)
{
    Console.WriteLine("Jogador atual:" + jogadoratual);
    Console.WriteLine("Digite a linha:");
    linha = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(" Digite a Coluna:");
    coluna = Convert.ToInt32(Console.ReadLine());

    if (tabuleiro[linha, coluna] == null)
    {
        tabuleiro[linha, coluna] = jogadoratual;
        if (
            (tabuleiro[0, 0] == tabuleiro[0, 1] &&
            tabuleiro[0, 1] == tabuleiro[0, 2] &&
            tabuleiro[0, 0] != null
            )
            ||
            (tabuleiro[0, 0] == tabuleiro[2, 0] &&
            tabuleiro[1, 1] == tabuleiro[1, 2] &&
            tabuleiro[1, 0] != null
            )
            ||
            (tabuleiro[2, 0] == tabuleiro[2, 1] &&
            tabuleiro[2, 1] == tabuleiro[2, 2] &&
            tabuleiro[2, 0] != null
            )

            ||
                (tabuleiro[0, 0] == tabuleiro[1, 0] &&
            tabuleiro[1, 0] == tabuleiro[2, 0] &&
            tabuleiro[2, 0] != null)
            ||
            (tabuleiro[0, 1] == tabuleiro[1, 1] &&
            tabuleiro[1, 1] == tabuleiro[2, 1] &&
            tabuleiro[2, 1] != null
            )

            ||

            (tabuleiro[0, 0] == tabuleiro[1, 1] &&
            tabuleiro[1, 1] == tabuleiro[2, 2] &&
            tabuleiro[0, 0] != null
           )
            ||
                (
                tabuleiro[2, 0] == tabuleiro[1, 1] &&
                tabuleiro[1, 1] == tabuleiro[0, 2] &&
                tabuleiro[2, 0] != null
           )

            )

        {


            Console.WriteLine("Vitoria do Jogador" + jogadoratual);
            break;

        }
        else
        if (
            tabuleiro[0, 0] != null &&
            tabuleiro[0, 1] != null &&
            tabuleiro[0, 2] != null &&
            tabuleiro[1, 0] != null &&
            tabuleiro[1, 1] != null &&
            tabuleiro[1, 2] != null &&
            tabuleiro[2, 0] != null &&
            tabuleiro[2, 1] != null &&
            tabuleiro[2, 2] != null
)




        {
            Console.WriteLine("Deu velha!");
            fimdejogo = true;
        }
        if (jogadoratual == jogadorx)


            jogadoratual = jogadoro;
        else
            jogadoratual = jogadorx;

    }
    else
    {
        Console.WriteLine("Posição está ocupada");

    }
    Console.Clear();
    ImprimirTabuleiro();
}


Console.ReadLine();

void ImprimirTabuleiro()
{
    for (int linhatabuleiro = 0; linhatabuleiro < 3; linhatabuleiro++)
    {
        for (int colunatabuleiro = 0; colunatabuleiro < 3; colunatabuleiro++)
        {
            if (tabuleiro[linhatabuleiro, colunatabuleiro] == null)
                Console.Write(" ");
            Console.Write(" " + tabuleiro[linhatabuleiro, colunatabuleiro] + " ");
            if (colunatabuleiro < 2) 
            Console.Write (" | ");
         
        }
        Console.WriteLine();
        if (linhatabuleiro < 2)
        Console.WriteLine("----------------");
        
    }
}
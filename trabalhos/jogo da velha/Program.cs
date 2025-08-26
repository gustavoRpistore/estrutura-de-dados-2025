using System;

class JogoDaVelha
{
    static char[,] tab = new char[3,3];
    static char jogador = 'X';

    static void Main()
    {
        for(int i=0;i<3;i++)
            for(int j=0;j<3;j++)
                tab[i,j]=' ';

        for(int rodada=0; rodada<9; rodada++)
        {
            Mostrar();
            int l=-1, c=-1;
            bool ok=false;
            while(!ok)
            {
                Console.WriteLine("Jogador "+jogador+" digite linha e coluna (0-2):");
                string[] entrada = Console.ReadLine().Split();
                if(entrada.Length==2 && int.TryParse(entrada[0],out l) && int.TryParse(entrada[1],out c))
                {
                    if(l>=0 && l<=2 && c>=0 && c<=2 && tab[l,c]==' ')
                    { tab[l,c]=jogador; ok=true; }
                    else Console.WriteLine("Jogada invalida!");
                }
                else Console.WriteLine("Entrada invalida!");
            }

            if(Vitoria()){Mostrar(); Console.WriteLine("Jogador "+jogador+" venceu!"); return;}
            jogador = (jogador=='X') ? 'O' : 'X';
        }

        Mostrar();
        Console.WriteLine("Empate!");
    }

    static void Mostrar()
    {
        Console.WriteLine("  0 1 2");
        for(int i=0;i<3;i++)
        {
            Console.Write(i+" ");
            for(int j=0;j<3;j++)
            {
                Console.Write(tab[i,j]);
                if(j<2) Console.Write("|");
            }
            Console.WriteLine();
            if(i<2) Console.WriteLine("  -+-+-");
        }
    }

    static bool Vitoria()
    {
        for(int i=0;i<3;i++)
            if((tab[i,0]==jogador && tab[i,1]==jogador && tab[i,2]==jogador) ||
               (tab[0,i]==jogador && tab[1,i]==jogador && tab[2,i]==jogador))
               return true;

        if((tab[0,0]==jogador && tab[1,1]==jogador && tab[2,2]==jogador) ||
           (tab[0,2]==jogador && tab[1,1]==jogador && tab[2,0]==jogador))
           return true;

        return false;
    }
}


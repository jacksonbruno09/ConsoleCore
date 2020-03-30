using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        string iJogador.Chutar()
        {
            return "Maradona estas chutando \n";
        }

        string iJogador.Correr()
        {
            return "Maradona estas correndo \n";
        }

        string iJogador.Passe()
        {
            return "Maradona estas passando \n";
        }
    }
}
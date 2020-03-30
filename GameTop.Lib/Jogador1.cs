using GameTop.Interface;

namespace  GameTop.Lib 
{
 public class Jogador1 : iJogador
    {
        public readonly string _Nome;
        //Chutar
        public Jogador1(string nome)
        {
            _Nome = nome;
        }
        public string Chutar ()
        {
            return $"{_Nome} esta chutando \n";   
        }
        //Correr
        public string Correr()
        {
            return $"{_Nome} esta correndo \n"; 
        }
        //Passe
        public string Passe()
        {
            return $"{_Nome} esta passando \n"; 
        }
    }  
}
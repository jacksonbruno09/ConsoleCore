using GameTop.Interface;
using GameTop.Lib;

namespace GameTop
{
    public class JogoFoda
    {
        private readonly iJogador _jogadorA;
        private readonly iJogador _jogadorB;
        public JogoFoda(iJogador jogadorA , iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
           // System.Console.Write($"{_jogador._Nome}  deu um passo");
     
           
         System.Console.Write(_jogadorA.Chutar());
         System.Console.Write(_jogadorA.Correr());
         System.Console.Write(_jogadorA.Passe());
         
         System.Console.Write("\n Proximo Jogador \n");

         System.Console.Write(_jogadorB.Chutar());
         System.Console.Write(_jogadorB.Correr());
         System.Console.Write(_jogadorB.Passe());
        }
    }    

   
}
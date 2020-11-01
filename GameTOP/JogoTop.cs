using GameTOP.Interface;

namespace GameTOP
{
    public class JogoTop
    {
        private readonly iJogador _jogador1;
        private readonly iJogador _jogador2;

        public JogoTop(iJogador jogador1, iJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }
        
        public void IniciarJogo()
        {
            System.Console.Write("-----------------JOGADOR 1----------------- \n");

            System.Console.WriteLine(_jogador1.Chutar());
            System.Console.WriteLine(_jogador1.Correr());
            System.Console.WriteLine(_jogador1.Passar());

            System.Console.Write("-----------------JOGADOR 2----------------- \n");

            System.Console.WriteLine(_jogador2.Chutar());
            System.Console.WriteLine(_jogador2.Correr());
            System.Console.WriteLine(_jogador2.Passar());
        }
    }
}
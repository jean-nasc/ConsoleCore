using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador2 : iJogador
    {
        public string Chutar()
        {
            return "Maradona estas pateando";
        }

        public string Correr()
        {
            return "Maradona estas corriendo";
        }

        public string Passar()
        {
            return "Maradona estas pasando";
        }
    }
}

using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Jean")
        {
            _Nome = nome;
        }

        //chutar
        public string Chutar()
        {
           return $"{_Nome} está chutando!";
        }

        //correr
        public string Correr()
        {
           return $"{_Nome} está correndo!";
        }

        //passar
        public string Passar()
        {
          return $"{_Nome} está passando!"; 
        }
    }
}
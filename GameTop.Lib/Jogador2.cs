using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
             return "Carla está Chutando \n";
        }

        public string Corre()
        {
            return "Carla está Correndo \n";
        }

        public string Passe()
        {
            return "Carla está Passando \n";
        }
    }
}
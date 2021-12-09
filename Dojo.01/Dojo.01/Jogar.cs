using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo._01
{
   public static class Jogar
    {

        public static string Start(string jogada1, string jogada2)
        {
            if (jogada1 == jogada2)
            {
                return "Foi um empate";
            }

            if (jogada1 == "pedra" && jogada2 == "tesoura")
            {
                return "Pedra venceu ! ";
            }

            if (jogada1 == "pedra" && jogada2 == "papel")
            {
                return "Pedra venceu ! ";
            }


            throw new NotImplementedException("Jogada nao implementada");
        }








    }
}

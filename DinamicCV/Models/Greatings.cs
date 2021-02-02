using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinamicCV.Models
{
    public class Greatings
    {
        public static String Saudacao()
        {

            int hora = DateTime.Now.Hour;
            string mensagem;
            if (hora >= 7 && hora < 12)
            {
                mensagem = "Bom dia ";
            }
            else if (hora >= 12 && hora < 20)
            {
                mensagem = "Boa tarde ";
            }
            else
            {
                mensagem = "Boa noite ";
            }

            return mensagem;
        }
    }




}

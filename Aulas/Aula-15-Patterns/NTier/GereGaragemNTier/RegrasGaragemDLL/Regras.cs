using System;
using System.Collections.Generic;
using MyCarro;
using GaragemDLL;

namespace RegrasGaragemDLL
{
    public class Regras
    {

        public static bool EstacioneCarroPorFavor(Carro c)
        {
            //REGRAS DE NEGÓCIO
            //O carro é GPL?
            //O condutor tem mais de 18 anos?
            // A garagem está aberta?
            //Verificar aqui se carro existe
            //
            return Garagem.EstacionaCarro(c);
        }


        public static List<Carro> DevolveCarroAno(int ano)
        {
            //Regras a testar
            return Garagem.DevolveCarros(ano);
        }
    }
}

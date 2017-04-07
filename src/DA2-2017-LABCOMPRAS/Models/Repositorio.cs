using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DA2_2017_LABCOMPRAS.Models
{
    public static class Repositorio
    {
        private static Despesa<Despesa> despesas = new Despesa<Despesa>();

        public static Despesa<Despesa> Despesas
        {
            get
            {
                return Despesas;
            }
        }
        public static void AddDespesa (Despesa newDespesa)
        {
            Despesas.Add(newDespesa);
        }


    }
}

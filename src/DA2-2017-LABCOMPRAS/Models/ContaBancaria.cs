using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DA2_2017_LABCOMPRAS.Models
{
    public class ContaBancaria
    {
        private string m_nometitular;
        private int m_saldo;
        private bool m_ativa;

        [Required(ErrorMessage = "Por favor	introduza o Valor")]
        public string NomeTitular
        {
            get { return m_nometitular; }
            set { m_nometitular = value; }
        }

        [Required(ErrorMessage = "Por favor	introduza o Valor")]
        public int Saldo
        {
            get { return m_saldo; }
            set { m_saldo = value; }
        }

        public bool Ativa
        {
            get { return m_ativa; }
            set { m_ativa = value; }
        }


        public ContaBancaria(string nome, int saldo, bool ativa)
        {
            m_nometitular = nome;
            m_saldo = saldo;
            m_ativa = ativa;
        }

        public ContaBancaria()
        {

        }

    }
}

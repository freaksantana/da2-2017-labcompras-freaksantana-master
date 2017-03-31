using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2017_LABCOMPRAS.Models
{
    public class Despesa
    {
        private string m_nomedespesa;
        private int m_quantidade;
        private double m_valor;
        private string m_categoria;
        private bool m_pago;

        public string NomeDespesa
        {
            get { return m_nomedespesa; }
            set { m_nomedespesa = value; }
        }

        public int Quantidade
        {
            get { return m_quantidade; }
            set { m_quantidade = value; }
        }

        public double Valor
        {
            get { return m_valor; }
            set { m_valor = value; }
        }


        public string Categoria
        {
            get { return m_categoria; }
            set { m_categoria = value; }
        }

        public bool Pago
        {
            get { return m_pago; }
            set { m_pago = value; }
        }


        public Despesa(string nome, int quantidade, double valor, string categoria, bool pago)
        {
            m_nomedespesa = nome;
            m_quantidade = quantidade;
            m_valor = valor;
            m_categoria = categoria;
            m_pago = pago;
        }

        public Despesa()
        {

        }

  


    }
}

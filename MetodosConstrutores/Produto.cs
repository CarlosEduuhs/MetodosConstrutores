using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosConstrutores
{
    public class Produto
    {
        //Atributos
        private string _nome;
        private double _preco;
        //AutoProperty - prop tab 2x
        public double Estoque { get; private set; }
        

        //Metodo construtor - Construtor Padrao
        public Produto()
        {
        }

        public Produto(string valNome, double valPreco, double valEstoque)
        {
            _nome = valNome;
            _preco = valPreco;
            Estoque = valEstoque;
        }

        public Produto(string valNome)
        {
            _nome = valNome;
        }

        //Encapsulamento - GET e SET
        public string GetNome()
        {
            return _nome;
        }

        public string SetNome(string nome)
        {
            if (nome.Length < 5)
            {
                return "Nome Não Alterado, valor com menos de 5 caracteres...";
            }
            else
            {
                _nome = nome;
                return "Nome Alterado com sucesso!";
            }
           
        }

        // Encapsulamento por propriedade
        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

        public void SomaEstoque(double estoque)
        {
            Estoque += estoque; 
        }

        //Metodos - Void ou Retorno || Com ou Sem parametro
        public double ValorEstoque()
        {
            return _preco * Estoque;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Pessoa
{
        private String nome;
        private String id;
        private int idade;
        private String CPF;

        public string Nome { get => nome; set => nome = value; }
        public string Id { get => id; set => id = value; }
        public int Idade { get => idade; set => idade = value; }
        public string CPF1 { get => CPF; set => CPF = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Cliente:Pessoa
    {
        public void comprar(int idProduto)
        {
            String[] v = { "Arroz", "Sal", "Batata" };
            MessageBox.Show("Comprando " + v[idProduto]);
        }
    }
}

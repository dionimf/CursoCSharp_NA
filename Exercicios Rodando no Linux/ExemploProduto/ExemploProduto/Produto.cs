using System;
using System.Globalization;


namespace ExemploProduto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        

        public double ValorTotalEstoque()
        {

            return Preco * Quantidade;
        }
        public void EntradaEstoque(int entrada)
        {
            Quantidade += entrada;
        }
        public void RemoverProdutoEstoque(int entrada)
        {
            Quantidade -= entrada;
        }
        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                +Quantidade
                + " unidades, Total: $ "
                +ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        
    }
}

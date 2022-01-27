using System;
using KitchenRouter.Exceção;


namespace KitchenRouter
{
    class SeletorArea : FilaPedido
    {
        public static void SeletionarArea(ItemPedido pedido) //static é para não precisar instanciar e usar o método direto
        {

            switch (pedido.TipoPedido)
            {
                case 1:
                    listaCarne.Add(pedido);
                    break;

                case 2:
                    listaFrango.Add(pedido);
                    break;

                case 3:
                    listaBebidas.Add(pedido);
                    break;

                case 4:
                    listaSobremesa.Add(pedido);
                    break;

                default:
                    throw new ErroSwitchCase("Tipo de pedido não é válido ou não existe.");
            }
        }
    }
}

using System.Collections.Generic;

namespace KitchenRouter
{

    class FilaPedido
    {
        public static List<ItemPedido> listaCarne = new List<ItemPedido>();
        public static List<ItemPedido> listaFrango = new List<ItemPedido>();
        public static List<ItemPedido> listaBebidas = new List<ItemPedido>();
        public static List<ItemPedido> listaSobremesa = new List<ItemPedido>();

        public static void AddPedido(ItemPedido pedido) //static é para não precisar instanciar e usar o método direto
        {
            SeletorArea.SeletionarArea(pedido);
        }

    }

}

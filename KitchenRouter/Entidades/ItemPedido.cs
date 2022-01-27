namespace KitchenRouter 
{
    class ItemPedido
    {
        public int IdPedido { get; set; }
        public int TipoPedido { get; set; }

        public ItemPedido()
        {
        }

        public ItemPedido(int idPedido)
        {
            IdPedido = idPedido;
        }

        public ItemPedido(int idPedido, int tipoPedido)
        {
            IdPedido = idPedido;
            TipoPedido = tipoPedido;
        }
    }
}

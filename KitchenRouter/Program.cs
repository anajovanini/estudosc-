using System;
using KitchenRouter.Exceção;

namespace KitchenRouter
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar;

            do
            {
                ItemPedido item = new ItemPedido();

                Console.WriteLine("Informe o seu tipo de pedido: \n 1- Carne \n 2- Frango \n 3- Bebida \n 4- Sobremesa \n");
                item.TipoPedido = int.Parse(Console.ReadLine());

                FilaPedido.AddPedido(item);
                
                Console.Write("Deseja fazer outro pedido? Digite 's' para sim e 'n' para não: ");
                continuar = Console.ReadLine();

                switch (continuar)
                {
                    case "s":
                        Console.WriteLine("Informe o novo item! \n");
                        break;

                    case "n":
                        Console.WriteLine("Pedido finalizado! \n");
                        break;

                    default:
                        throw new ErroSwitchCase("Opção informada é inválida \n");
                }
            }
            while (continuar == "S");

            Console.WriteLine($"Você tem {FilaPedido.listaCarne.Count} pedido na fila 'Carne'");
            Console.WriteLine($"Você tem {FilaPedido.listaFrango.Count} pedido na fila 'Frango'");
            Console.WriteLine($"Você tem {FilaPedido.listaBebidas.Count} pedido na fila 'Bebidas'");
            Console.WriteLine($"Você tem {FilaPedido.listaSobremesa.Count} pedido na fila 'Sobremesa'");
        }
    }
}

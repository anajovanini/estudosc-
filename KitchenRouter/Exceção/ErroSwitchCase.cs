using System;


namespace KitchenRouter.Exceção
{
    class ErroSwitchCase : ApplicationException
    {
        public ErroSwitchCase (string message) : base(message)
        {
        }
    }
}

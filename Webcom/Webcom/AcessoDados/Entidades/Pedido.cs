using System;
using System.Collections.Generic;

namespace Webcom.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public ICollection<ItemPedido> ItemPedidos { get; set; }
    }
}

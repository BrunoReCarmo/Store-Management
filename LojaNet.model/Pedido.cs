﻿using LojaNet.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaNet.model
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Cliente Cliente { get; set; }
        public List<Item> Items { get; set; }
        FormaPagamentoEnum FormaPagamento { get; set; }
        public class Item
        {
            public int Ordem { get; set; }
            public Produto Produto { get; set; }
            public int Quantidade { get; set; }
            public decimal Preco { get; set; }
        }
    }
}

﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade 
    {

        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public ICollection<ItemPedido> ItensPedidos { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }

        public FormaPagamento FormaPagamento  { get; set; }


       public override void Validate()
        {
            LimparMensagensValidacao();
            if (!ItensPedidos.Any())
                AdicionarCritica("Itens do pedido não localizados");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("CEP não preenchido");
        }
    }

}

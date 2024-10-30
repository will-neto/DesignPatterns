using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Facade.Exemplo1
{
    // Facade
    internal class ProcessoDeCompraFacade
    {
        private readonly NotificacaoEmailService _notificacaoEmailService;
        private readonly EstoqueService _estoqueService;
        private readonly PagamentoService _pagamentoService;

        public ProcessoDeCompraFacade()
        {
            _notificacaoEmailService = new NotificacaoEmailService();
            _estoqueService = new EstoqueService();
            _pagamentoService = new PagamentoService();
        }

        public bool ProcessarCompra(Compra compra)
        {
            if (!_estoqueService.VerificarEmEstoque(compra))
                return false;

            if (!_pagamentoService.FazerPagamento(compra))
                return false;

            _notificacaoEmailService.ConfirmarPagamento(compra);

            return true;
        }
    }
}

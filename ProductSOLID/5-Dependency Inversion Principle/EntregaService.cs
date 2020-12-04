using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSOLID._5_Dependency_Inversion_Principle
{
    public class EntregaService
    {
        IOperacao _operacao;

        public EntregaService(IOperacao operacao)
        {
            _operacao = operacao;
        }

        void entrega() {

            _operacao.Entregar();
        }
    }
}

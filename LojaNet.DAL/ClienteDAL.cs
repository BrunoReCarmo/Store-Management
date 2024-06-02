using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaNet.model;

//Model 
using LojaNet.models;

namespace LojaNet.DAL
{
    //Classe ":" implementa Interface Cliente Dados
    //Cliente: Acesso a Dados
    //Data Access Layer
    public class ClienteDAL : IClienteDados
    {
        public void Alterar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(string Id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorEmail(string Email)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(string Id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}

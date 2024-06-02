using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Project
using LojaNet.models;
using LojaNet.DAL;
using LojaNet.model;


namespace LojaNet.BLL
{
    //Business Logic Layer 
    public class ClienteBLL : IClienteDados
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
            if(string.IsNullOrEmpty(cliente.Nome))
            {
                throw new ApplicationException("O nome deve ser preenchido");
            }
            if (string.IsNullOrEmpty(cliente.Id))
            {
                //Guid cria o ID se não houver existente
                cliente.Id=Guid.NewGuid().ToString();
            }

            var dal = new ClienteDAL();
            dal.Incluir(cliente);
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

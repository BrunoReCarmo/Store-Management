using LojaNet.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Interface p/ métodos models - (Padrão I{Nome do Objeto})
namespace LojaNet.models
{
    public interface IClienteDados
    {
        void Incluir(Cliente cliente);
        void Alterar(Cliente cliente);
        void Excluir(string Id);
        List<Cliente> ObterTodos();
        Cliente ObterPorId(string  Id);
        Cliente ObterPorEmail(string Email);
    }
}

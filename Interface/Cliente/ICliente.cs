using Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Cliente
{
    public interface ICliente
    {
        ClienteModel GetCliente();
        List<ClienteModel> GetClientes();
        List<ClienteModel> GetClientesByFirstNameLetter(char FirstLetter);
        void SetCliente(ClienteModel clienteModel);
        void DeleteCliente(int id);
        void EditCliente(ClienteModel cliente);
    }
}

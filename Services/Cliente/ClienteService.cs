using Dapper;
using Interface.Cliente;
using Models.Cliente;
using Services.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Cliente
{
    public class ClienteService : ICliente
    {

        public void DeleteCliente(int id)
        {
            throw new NotImplementedException();
        }

        public void EditCliente(ClienteModel cliente)
        {
            throw new NotImplementedException();
        }

        public ClienteModel GetCliente()
        {
            throw new NotImplementedException();
        }

        public List<ClienteModel> GetClientes()
        {
            var ConnectionManager = new ConnectionManager();
            var conn = ConnectionManager.GetConnection();
            return conn.QueryFirstAsync<ClienteModel>("select * from Cliente");
        }

        public List<ClienteModel> GetClientesByFirstNameLetter(char FirstLetter)
        {
            throw new NotImplementedException();
        }

        public void SetCliente(ClienteModel clienteModel)
        {
            throw new NotImplementedException();
        }
    }
}

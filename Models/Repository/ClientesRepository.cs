using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CadastroClientes.Models.Repository
{
    public class ClientesRepository
    {
        public void Salvar(Clientes clientes)
        {
            string clientesTexto = JsonConvert.SerializeObject(clientes) + "," + Environment.NewLine;
            File.AppendAllText("C:\\Users\\famon\\Downloads\\Projettos\\CadastroClientes\\BancoDados\\bancodados.txt", clientesTexto);
        }

        public List<Clientes> Listar()
        {
            var clientes = File.ReadAllText("C:\\Users\\famon\\Downloads\\Projettos\\CadastroClientes\\BancoDados\\bancodados.txt");

            List<Clientes> clientesLista = JsonConvert.DeserializeObject<List<Clientes>>("[" + clientes + "]");

            return clientesLista.OrderByDescending(t => t.Nome).ToList();
        }

        public bool Deletar(string Documento)
        {
            var listaClientes = Listar();
            var item = listaClientes.Where(t => t.Documento == Documento);
        }
    }
}
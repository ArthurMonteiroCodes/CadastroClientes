using CadastroClientes.Models;
using CadastroClientes.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpPost("Salvar")]
        public object Salvar([FromBody] Clientes cadastro)
        {   
            try
            {
                ClientesRepository clientes = new ClientesRepository();
                clientes.Salvar(cadastro);
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        [HttpPost("Alterar")]
        public object Alterar([FromBody] Clientes cadastro)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }

            return null;
        }

        [HttpGet("Listar")]
        public object Listar()
        {
            List<Clientes> listaCli = null;
            try
            {
                ClientesRepository clientesRepo = new ClientesRepository();
                listaCli = clientesRepo.Listar();
            }
            catch (Exception ex)
            {

            }

            return listaCli;
        }

        [HttpDelete("Deletar")]
        public object Deletar(int IdCliente)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }

            return null;
        }
    }
}
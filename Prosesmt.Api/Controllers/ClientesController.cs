using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Prosesmt.Api.Models;
using Prosesmt.Api.Models.ViewModels;
using Prosesmt.Api.Repository;

namespace Prosesmt.Api.Controllers
{
    [Route("api/[controller]")]
    public class ClientesController : Controller
    {
        protected IClienteRepository clienteRepository = null;
        protected IChamadoRepository chamadoRepository = null;

        public ClientesController(IClienteRepository clienteRepository, IChamadoRepository chamadoRepository)
        {
            this.clienteRepository = clienteRepository;
            this.chamadoRepository = chamadoRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public ClienteViewModel Get()
        {
            try
            {
                var clientes = this.clienteRepository.List();
                return new ClienteViewModel
                {
                    Clientes = clientes,
                    TotalItens = this.clienteRepository.Count(),
                    Status = Status.OK
                };
            }
            catch (Exception ex)
            {
                return new ClienteViewModel
                {
                    Status = Status.Erro,
                    Mensagem = "Ocorreu um erro durante o processamento"
                };
            }
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public ClienteViewModel Get(long id)
        {
            try
            {
                return new ClienteViewModel
                {
                    Cliente = this.clienteRepository.Get(id),
                    Status = Status.OK
                };
            }
            catch (Exception ex)
            {
                return new ClienteViewModel
                {
                    Status = Status.Erro,
                    Mensagem = "Ocorreu um erro durante o processamento"
                };
            }
        }

        // POST api/<controller>
        [HttpPost]
        [Authorize]
        public ClienteViewModel Post([FromBody]Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (this.clienteRepository.Get(x => x.CnpjCpf.Trim() == cliente.CnpjCpf.Trim()) != null)
                    {
                        return new ClienteViewModel
                        {
                            Status = Status.Invalido,
                            Mensagem = "CNPJ/CPF já cadastrado!"
                        };
                    }

                    this.clienteRepository.Create(cliente);
                    return new ClienteViewModel
                    {
                        Status = Status.OK,
                        Mensagem = "Cadastro realizado com sucesso"
                    };
                }
                else
                {
                    return new ClienteViewModel
                    {
                        Status = Status.Invalido,
                        Mensagem = "Dados inválidos. Verifique novamente."
                    };
                }
            }
            catch (Exception ex)
            {
                return new ClienteViewModel
                {
                    Status = Status.Erro,
                    Mensagem = "Ocorreu um erro durante o processamento."
                };
            }
        }

        [HttpPut("{id}")]
        [Authorize]
        public ClienteViewModel Put(int id, [FromBody]Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this.clienteRepository.Edit(cliente);
                    return new ClienteViewModel
                    {
                        Status = Status.OK,
                        Mensagem = "Cliente editado com sucesso!"
                    };
                }
                else
                {
                    return new ClienteViewModel
                    {
                        Status = Status.Invalido,
                        Mensagem = "Dados inválidos. Verifique novamente."
                    };
                }
            }
            catch (Exception ex)
            {
                return new ClienteViewModel
                {
                    Status = Status.Erro,
                    Mensagem = "Ocorreu um erro durante o processamento"
                };
            }
        }

        [HttpDelete("{id}")]
        [Authorize]
        public ClienteViewModel Delete(long id)
        {
            try
            {
                this.clienteRepository.Delete(id);
                return new ClienteViewModel
                {
                    Status = Status.OK,
                    Mensagem = "Cliente excluído com sucesso!"
                };
            }
            catch (Exception ex)
            {
                return new ClienteViewModel
                {
                    Status = Status.Erro,
                    Mensagem = "Ocorreu um erro durante o processamento"
                };
            }
        }
    }
}

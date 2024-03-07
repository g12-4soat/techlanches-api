using TechLanches.Application.Constantes;
using TechLanches.Application.DTOs;
using TechLanches.Application.Gateways.Interfaces;
using TechLanches.Core;
using TechLanches.Domain.Entities;
using TechLanches.Domain.ValueObjects;

namespace TechLanches.Application.UseCases.Clientes
{
    public class ClienteUseCases
    {
        public static async Task<Cliente> Cadastrar(
            string nome, string email, string cpf,
            IClienteGateway clienteGateway)
        {
            var clienteExistente = await clienteGateway.BuscarPorCpf(RetornarCpf(cpf));

            if (clienteExistente is not null)
                throw new DomainException($"Cliente já existente para CPF: {cpf}");

            var cliente = new Cliente(nome, email, cpf);

            var novoCliente = await clienteGateway.Cadastrar(cliente);

            return novoCliente;
        }

        public static async Task<Cliente> IdentificarCliente(
            UserTokenDTO user,
            IClienteGateway clienteGateway)
        {

            if (user.Username == Constants.USERDEFAULTCONSTANT) return null;

            var cliente = await clienteGateway.BuscarPorCpf(RetornarCpf(user.Username));

            if (cliente is null)
            {
                cliente = await Cadastrar(user.Nome, user.Email, user.Username, clienteGateway);
                await clienteGateway.CommitAsync();
            }

            return cliente;
        }

        public static async Task<Cliente> ObterClientePorCPF(
          string cpf,
          IClienteGateway clienteGateway)
        {

            var cliente = await clienteGateway.BuscarPorCpf(RetornarCpf(cpf));

            if (cliente is null)
            {
                throw new DomainException("Cliente não cadastrado!");
            }

            return cliente;
        }

        private static Cpf RetornarCpf(string cpf)
        {
            return new Cpf(cpf);
        }
    }
}
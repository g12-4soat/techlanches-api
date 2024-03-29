﻿using TechLanches.Application.DTOs;

namespace TechLanches.Application.Controllers.Interfaces
{
    public interface IClienteController
    {
        Task<ClienteResponseDTO> BuscarPorCpf(string cpf);
        Task<ClienteResponseDTO> Cadastrar(string nome, string email, string cpf);
        Task<ClienteResponseDTO> BuscarPorId(int idCliente);
    }
}

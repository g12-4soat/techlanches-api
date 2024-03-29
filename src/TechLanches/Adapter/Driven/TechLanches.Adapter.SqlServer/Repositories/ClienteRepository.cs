﻿using Microsoft.EntityFrameworkCore;
using TechLanches.Application.Ports.Repositories;
using TechLanches.Core;
using TechLanches.Domain.Entities;
using TechLanches.Domain.ValueObjects;

namespace TechLanches.Adapter.SqlServer.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly TechLanchesDbContext _context;

    public IUnitOfWork UnitOfWork => _context;

    public ClienteRepository(TechLanchesDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<Cliente> BuscarPorCpf(Cpf cpf)
        => await _context.Clientes.SingleOrDefaultAsync(x => x.CPF.Numero == cpf.Numero);

    public async Task<Cliente> Cadastrar(Cliente cliente)
        => (await _context.AddAsync(cliente)).Entity;

    public async Task<Cliente> BuscarPorId(int idCliente)
        => await _context.Clientes.SingleOrDefaultAsync(x => x.Id == idCliente);
}
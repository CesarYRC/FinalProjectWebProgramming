using FinalProjectBikes.Modelo;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectBikes.Repositorio
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly CatalogoDBContext _context;

        public RepositorioCliente(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<Cliente> Add(Cliente cliente)
        {
            await _context.Cliente.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task Delete(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente != null)
            {
                _context.Cliente.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Cliente?> Get(int id)
        {
            return await _context.Cliente.FindAsync(id);
        }

        public async Task<List<Cliente>> GetAll()
        {
            return await _context.Cliente.ToListAsync();
        }

        public async Task Update(int id, Cliente cliente)
        {
            var clienteactual = await _context.Cliente.FindAsync(id);
            if (clienteactual != null)
            {
                clienteactual.Name = cliente.Name;
                clienteactual.Email = cliente.Email;
                clienteactual.PhoneNumber = cliente.PhoneNumber;
                clienteactual.ModelBike = cliente.ModelBike;
                await _context.SaveChangesAsync();
            }
        }


    }
}

using FinalProjectBikes.Modelo;
    
namespace FinalProjectBikes.Repositorio
{
    public interface IRepositorioCliente
    {
        Task<List<Cliente>> GetAll();
        Task<Cliente?> Get(int id);
        Task<Cliente> Add(Cliente cliente);
        Task Update(int id, Cliente cliente);   
        Task Delete(int id);
    }
}

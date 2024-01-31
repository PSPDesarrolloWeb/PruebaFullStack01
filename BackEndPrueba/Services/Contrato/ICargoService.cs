using BackEndPrueba.Models;

namespace BackEndPrueba.Services.Contrato
{
    public interface ICargoService
    {
        Task<List<Cargo>> GetList();

    }
}

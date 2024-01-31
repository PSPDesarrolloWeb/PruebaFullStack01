using BackEndPrueba.Models;

namespace BackEndPrueba.Services.Contrato
{
    public interface IDepartamentoService
    {
        Task<List<Departamento>> GetList();
    }
}

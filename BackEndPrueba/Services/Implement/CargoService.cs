using Microsoft.EntityFrameworkCore;
using BackEndPrueba.Models;
using BackEndPrueba.Services.Contrato;

namespace BackEndPrueba.Services.Implement
{
    public class CargoService : ICargoService
    {
        private PruebaContext _pruebaContext;

        public CargoService(PruebaContext pruebacontext)
        {
            _pruebaContext = pruebacontext;
        }

        public async Task<List<Cargo>> GetList()
        {
            try
            {
                List<Cargo> lista = new List<Cargo>();
                lista = await _pruebaContext.Cargos.ToListAsync();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

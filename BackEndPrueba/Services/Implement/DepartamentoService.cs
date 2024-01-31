using Microsoft.EntityFrameworkCore;
using BackEndPrueba.Models;
using BackEndPrueba.Services.Contrato;

namespace BackEndPrueba.Services.Implement
{
    public class DepartamentoService : IDepartamentoService
    {
        private PruebaContext _pruebaContext;

        public DepartamentoService(PruebaContext pruebacontext)
        {
            _pruebaContext = pruebacontext;
        }

        public async Task<List<Departamento>> GetList()
        {
            try
            {
                List<Departamento> lista = new List<Departamento>();
                lista = await _pruebaContext.Departamentos.ToListAsync();
                return lista; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}

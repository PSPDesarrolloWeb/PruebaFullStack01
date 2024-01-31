using Microsoft.EntityFrameworkCore;
using BackEndPrueba.Models;
using BackEndPrueba.Services.Contrato;
using System.Runtime.Intrinsics.Arm;

namespace BackEndPrueba.Services.Implement
{
    public class UserService : IUserService
    {
        private PruebaContext _pruebaContext;

        public UserService(PruebaContext pruebacontext)
        {
            _pruebaContext = pruebacontext;
        }

        public async Task<List<User>> GetList()
        {
            try
            {
                List<User> lista = new List<User>();
                lista = await _pruebaContext.Users.Include(dp => dp.IdDepartamentoUsNavigation).ToListAsync();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User>Get(string Username)
        {
            try
            {
                User?encontrado = new User();

                encontrado = await _pruebaContext.Users.Include(dp => dp.IdDepartamentoUsNavigation)
                    .Where(e => e.UsuarioUs == Username).FirstOrDefaultAsync();

                return encontrado;
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User>Add(User modelo)
        {
            try
            {
                _pruebaContext.Users.Add(modelo);
                await _pruebaContext.SaveChangesAsync();
                return modelo;
            }catch(Exception ex) 
            { 
                throw ex;
            }
        }

        public async Task<bool> Update(User modelo)
        {
            try
            {
                _pruebaContext.Users.Update(modelo);
                await _pruebaContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Delete(User modelo)
        {
            try
            {
                _pruebaContext.Users.Remove(modelo);
                await _pruebaContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<User> Get(int idUser)
        {
            throw new NotImplementedException();
        }
    }
}

using BackEndPrueba.Models;

namespace BackEndPrueba.Services.Contrato
{
    public interface IUserService
    {
        Task<List<User>> GetList();
        Task<User>Get(string idUser);
        Task<User>Add(User modelo);
        Task<bool>Update(User modelo);
        Task<bool>Delete(User modelo);


    }
}

using System.Threading.Tasks;
using BlazorMongoDB.Data;

namespace BlazorMongoDB.IService
{
    public interface IUserService
    {
        Task<User> GetUserByUsername(string username); // Buscar usuario por nombre
        Task AddUser(User user); // Registrar nuevo usuario
    }
}

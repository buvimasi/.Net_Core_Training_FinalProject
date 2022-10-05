using FinalProjectAPI.Entities;
using FinalProjectAPI.ViewModels;

namespace FinalProjectAPI.IServices
{
    public interface IUserService
    {
        User GetById(int id);
        AuthenticateResponse Authenticate(AuthenticateRequest model);
    }
}

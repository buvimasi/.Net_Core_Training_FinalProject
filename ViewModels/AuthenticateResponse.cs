using FinalProjectAPI.Entities;

namespace FinalProjectAPI.ViewModels
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Roles { get; set; }
        public string Token { get; set; }


        public AuthenticateResponse(User user, string token)
        {
            Id = user.Id;
            Name = user.Name;
            Username = user.UserName;
            Roles = user.Role;
            Token = token;
        }
    }
}

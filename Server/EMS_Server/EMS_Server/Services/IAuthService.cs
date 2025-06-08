using EMS_Server.Dtos;
using System.Threading.Tasks;

namespace EMS_Server.Services
{
    public interface IAuthService
    {
        Task<string> Register(RegisterDto registerDto);
        Task<string> Login(LoginDto loginDto);
    }
}
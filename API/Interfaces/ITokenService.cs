using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(ColUser colUser);
    }
}
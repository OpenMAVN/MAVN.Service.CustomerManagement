using System.Threading.Tasks;
using MAVN.Service.CustomerManagement.Domain.Models;


namespace MAVN.Service.CustomerManagement.Domain.Services
{
    public interface IPasswordResetService
    {
        Task<PasswordResetError> RequestPasswordResetAsync(string email);

        Task<PasswordResetError> PasswordResetAsync(string customerEmail, string identifier, string newPassword);

        Task<ValidateResetIdentifierModel> ValidateResetIdentifierAsync(string resetIdentifier);
    }
}

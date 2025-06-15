using bsm.Domain.Entities;
using bsm.Domain.Interfaces;

namespace bsm.Infrastructure.Repositories.UserRepositories
{
    public interface IUserRepositories : IRepositories<bsm.Domain.Entities.User>
    {
        // Additional user-specific methods can be defined here if needed
        // For example, methods for user authentication, password reset, etc.
        public User Authenticate( string username, string password );
        public int ResetPassword( Guid userId, string newPassword );
    }
}

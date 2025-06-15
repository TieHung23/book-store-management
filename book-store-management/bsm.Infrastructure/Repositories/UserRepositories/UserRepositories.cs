using bsm.Domain.Entities;
using bsm.Infrastructure.Data;

namespace bsm.Infrastructure.Repositories.UserRepositories
{
    public class UserRepositories : IUserRepositories
    {
        private readonly DataContext _context;

        public UserRepositories( DataContext context )
        {
            _context = context ?? throw new ArgumentNullException( nameof( context ) );
        }

        public int add( User entity )
        {
            _context.Users.Add( entity );
            try
            {
                return _context.SaveChanges();
            }
            catch( Exception ex )
            {
                throw new Exception( "An error occurred while adding the user.", ex );
            }
        }

        public User Authenticate( string username, string password )
        {
            throw new NotImplementedException();
        }

        public int delete( Guid id )
        {
            _context.Users.Remove( _context.Users.Find( id ) ?? throw new KeyNotFoundException( "User not found." ) );

            return _context.SaveChanges();
        }

        public IEnumerable<User> getAll()
        {
            return _context.Users.ToList();
        }

        public User getById( Guid id )
        {
            return _context.Users.FirstOrDefault( u => u.UserId == id ) ?? throw new KeyNotFoundException( "User not found." );
        }

        public int ResetPassword( Guid userId, string newPassword )
        {
            throw new NotImplementedException();
        }

        public int update( User entity )
        {
            _context.Users.Update( entity );
            try
            {
                return _context.SaveChanges();
            }
            catch( Exception ex )
            {
                throw new Exception( "An error occurred while updating the user.", ex );
            }
        }
    }
}

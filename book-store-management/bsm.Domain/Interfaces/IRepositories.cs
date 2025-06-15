namespace bsm.Domain.Interfaces
{
    public interface IRepositories<T>
    {
        T getById( Guid id );

        IEnumerable<T> getAll();

        int add( T entity );

        int update( T entity );

        int delete( Guid id );
    }
}

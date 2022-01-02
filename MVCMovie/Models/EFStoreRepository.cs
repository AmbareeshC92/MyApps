using MVCMovie.Data;

namespace MVCMovie.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private readonly MVCMovieContext context;

        public EFStoreRepository(MVCMovieContext context)
        {
            this.context = context;
        }
        public IQueryable<Product> Products => context.Product;
    }
}

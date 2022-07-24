using Domain.Models;

namespace Infrastructure.Repositories
{
    public class ArtistRepository : GenericRepository<Artist>
    {
        public ArtistRepository(ChinookContext context) : base(context)
        {

        }
    }
}

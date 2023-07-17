using Microsoft.EntityFrameworkCore;
using NewProjApi.Data;
using NewProjApi.Models.Domain;

namespace NewProjApi.Repositories
{
    public class RegionRepository: IRegionRepository
    {
        private readonly NZWalksDbContext nZWalksDbContext;

        public RegionRepository(NZWalksDbContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }

        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await nZWalksDbContext.Regions.ToListAsync();
        }
    }
}

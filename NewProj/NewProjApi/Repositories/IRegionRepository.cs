using NewProjApi.Models.Domain;

namespace NewProjApi.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
    }
}

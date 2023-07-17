using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NewProjApi.Models.DTO;
using NewProjApi.Repositories;

namespace NewProjApi.Controllers
{

    [ApiController]
    [Route("Region")]
    public class RegionController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionController(IRegionRepository regionRepository,IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        [HttpGet]

        public async Task<IActionResult> GetAllRegions() 
        {
            var regions = await regionRepository.GetAllAsync();

            var regionsDto = mapper.Map<List<Models.DTO.Region>>(regions);

            return Ok(regionsDto);
        }
    }
}

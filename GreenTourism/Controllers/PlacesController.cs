using GreenTourism.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using GreenTourism.Extensions;
using System.Linq;
using System.Threading.Tasks;

namespace GreenTourism.Controllers
{
    public class PlacesController : Controller
    {
        private readonly IPlaceRepository _placeRepository;

        public PlacesController(IPlaceRepository placeRepository)
        {
            _placeRepository = placeRepository;
        }

        public ActionResult Index()
        {
            var places =  _placeRepository.GetPlacesList()
                .Result
                .Select(x=>x.ToPlaceViewModel())
                .ToList();
            return View(places);
        }

        public async Task<ActionResult> Details(long id)
        {
            var details = await _placeRepository.GetDetailsPage(id);
            return View(details);
        }
    }
}
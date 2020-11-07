using GreenTourism.DAL.Models;
using GreenTourism.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GreenTourism.Controllers
{
    public class PlacesController : Controller
    {
        private readonly IPlaceRepository _placeRepository;
        private readonly IRegionRepository _regionRepository;
        private readonly ISeasonRepository _seasonRepository;
        private readonly IPhotoRepository _photoRepository;

        public PlacesController(IPlaceRepository placeRepository, IRegionRepository regionRepository, ISeasonRepository seasonRepository, IPhotoRepository photoRepository)
        {
            _placeRepository = placeRepository;
            _regionRepository = regionRepository;
            _seasonRepository = seasonRepository;
            _photoRepository = photoRepository;
            
        }

        public async Task<ActionResult> Index()
        {
            var places = _placeRepository.GetPlacesWithImages();
            return View(places);
        }
    }
}
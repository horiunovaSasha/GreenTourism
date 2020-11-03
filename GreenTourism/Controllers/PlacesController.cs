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

        public PlacesController(IPlaceRepository placeRepository, IRegionRepository regionRepository, ISeasonRepository seasonRepository)
        {
            _placeRepository = placeRepository;
            _regionRepository = regionRepository;
            _seasonRepository = seasonRepository;
        }

        public async Task<ActionResult> Index()
        {
            //try
            //{
            //    var place = new Place()
            //    {
            //        Name = "Асканія Нова",
            //        Description = "Оазиз серед степу",
            //        LocationCoords = "000000000",
            //        Rating = 9.05M,
            //        Region = _regionRepository.FindById(1).Result,
            //        Season = _seasonRepository.FindById(1).Result
            //    };
            //    await _placeRepository.CreateAsync(place);
            //    await _placeRepository.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    var test = ex;
            //}

            var places = _placeRepository.FindAll().Result;
            return View();
        }
    }
}
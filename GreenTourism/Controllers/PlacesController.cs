using GreenTourism.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using GreenTourism.Extensions;
using System.Linq;
using System.Threading.Tasks;
using GreenTourism.DAL.Models;
using Microsoft.AspNetCore.Identity;
using System;

namespace GreenTourism.Controllers
{
    public class PlacesController : Controller
    {
        private readonly IPlaceRepository _placeRepository;
        private readonly ICommentRepository _commentRepository;

        public PlacesController(IPlaceRepository placeRepository, ICommentRepository commentRepository)
        {
            _placeRepository = placeRepository;
            _commentRepository = commentRepository;
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
            var details = (await _placeRepository.GetDetailsPage(id))?.ToPlaceViewModel();
            return View(details);
        }
    }
}
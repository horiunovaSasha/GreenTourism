using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenTourism.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GreenTourism.Controllers
{
    public class EventsController : Controller
    {
        //private readonly IEventRepository _eventRepository;
        public IActionResult Index()
        {
            return View();
        }
    }
}
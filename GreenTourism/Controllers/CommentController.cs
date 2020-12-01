using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenTourism.DAL.Models;
using GreenTourism.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GreenTourism.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IPlaceCommentRepository _placeCommentRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly IPlaceRepository _placeRepository;

        public CommentController(
            //UserManager<ApplicationUser> userManager,
            IPlaceCommentRepository placeCommentRepository,
            ICommentRepository commentRepository,
            IPlaceRepository placeRepository
            )
        {
            //_userManager = userManager;
            _commentRepository = commentRepository;
            _placeCommentRepository = placeCommentRepository;
            _placeRepository = placeRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment, [FromQuery] int placeId) 
        {
            var place = await _placeRepository.FindById(placeId);
            comment.CreatedDate = DateTime.Now;
            comment.UserId = "3b8844c7-0c47-46eb-8948-2c43a65613e0";//(await _userManager.GetUserAsync(User))?.Id;

            await _commentRepository.CreateAsync(comment);
            await _commentRepository.SaveChanges();

            await _placeCommentRepository.CreateAsync(new PlaceComment()
            {
                Comment = comment,
                Place = place
            });

            await _placeCommentRepository.SaveChanges();

            return Ok(new { 
                comment.Text,
                CreatedDate = comment.CreatedDate.ToString()
            });
        }
    }
}
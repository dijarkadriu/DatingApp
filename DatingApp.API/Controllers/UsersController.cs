using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Data;
using DatingApp.API.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IDatingRepository repo;
        private readonly IMapper mapper;

        public UsersController(IDatingRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await repo.GetUsers();
            var userToReturn = mapper.Map<IEnumerable<UserForListDTO>>(users);
            return Ok(userToReturn);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await repo.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            var userToReturn = mapper.Map<UserForDetailedDTO>(user);
            return Ok(userToReturn);
        }
    }
}
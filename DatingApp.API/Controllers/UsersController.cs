using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Authorize, Route("api/[controller]"), ApiController]
    public class UsersController : ControllerBase
    {
        private IDatingRepository _datingRepository;
        private readonly IMapper _mapper;
        public UsersController(IDatingRepository datingRepository, IMapper mapper)
        {
            _datingRepository = datingRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers() =>  
            Ok(_mapper.Map<IEnumerable<UserForListDto>>(await _datingRepository.GetUsers()));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id) => 
            Ok(_mapper.Map<UserForDetailDto>(await _datingRepository.GetUser(id)));
    }
}
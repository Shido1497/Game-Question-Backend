using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestionGame.Dto;
using QuestionGame.Infraestructure;
using QuestionGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuestionGame.Models.Extensions;

namespace QuestionGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelController : ControllerBase
    {
        private readonly IRepository<Level> _respository;

        public LevelController(IRepository<Level> respository)
        {
            _respository = respository;
        }

        [HttpPost]
        public async Task<int> PostAsync(CreateLevelDto input)
        {

            var level = await _respository.InsertAsync(new Level() { Difficulty = input.Difficulty, Points = input.Points });
            return level.Id;
        }

        [HttpGet]
        public async Task<IEnumerable<LevelDto>> GetAllAsync()
        {
            var levels = await _respository.GetAllAsync();
            var levelDtos = new List<LevelDto>();
            foreach (var level in levels)
            {
                levelDtos.Add(new LevelDto { Difficulty = level.Difficulty, Id = level.Id, Points = level.Points });
            }
            return levelDtos;
        }
    }
}

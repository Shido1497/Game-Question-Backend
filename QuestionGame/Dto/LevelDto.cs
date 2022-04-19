using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionGame.Dto
{
    public class LevelBaselDto
    {
        public int Difficulty { get; set; }

        public double Points { get; set; }
    }

    public class CreateLevelDto: LevelBaselDto
    {
    }

    public class LevelDto : LevelBaselDto
    {
        public int Id { get; set; }
    }
}

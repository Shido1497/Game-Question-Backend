using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionGame.Models
{
    public class Level : EntityBase
    {
        public int Difficulty { get; set; }

        public double Points { get; set; }
        public List<Category> Categories { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionGame.Dto
{
    public class PlayerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CreatePlayerDto
    {
        public string Name { get; set; }
    }

}

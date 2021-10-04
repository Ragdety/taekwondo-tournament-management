﻿using System;
using TaekwonTourney.Core.Enums;

namespace TaekwonTourney.Core.Models
{
    public class Participant : BaseModel<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public BeltLevel BeltLevel { get; set; }
        
        //Will do checks here to see if is blackbelt
        public BlackBeltLevel? BlackBeltLevel { get; set; }
        public bool IsBlackBelt { get; set; }
    }
}
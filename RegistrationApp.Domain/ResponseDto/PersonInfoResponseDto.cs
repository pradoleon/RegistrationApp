﻿using RegistrationApp.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApp.Domain.ResponseDto
{
    public class PersonInfoResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public Status Status { get; set; }
        public string personalities { get; set; }
        public List<int> personalitiesIds { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dentist.Models
{
    public class Bio
    {
        public int Id { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        public TimeSpan WeekDaysOpenHour { get; set; }
        public TimeSpan WeekdayCloseHour { get; set; }
        public TimeSpan SundayOpenHour { get; set; }
        public TimeSpan SundayCloseHour { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }


    }
}
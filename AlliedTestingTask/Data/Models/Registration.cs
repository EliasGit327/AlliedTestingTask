﻿using System;

namespace AlliedTestingTask.Data.Models
{
    public class Registration
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime RegistrationDate { get; set; }
        public string Locale { get; set; }
        public Person Person { get; set; }
        public Organisation Organisation { get; set; }
    }
}
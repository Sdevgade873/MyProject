﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EHIPRoject.Models
{
    public class MemberInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public int? PostalCode { get; set; }
        public Guid Id { get; set; }
    }
}
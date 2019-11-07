using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EHIProject.Models
{
    public class MemberInfo
    {
        [Required(ErrorMessage = "FirstName Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "PhoneNumber Required")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Status Required")]
        public string Status { get; set; }
        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "PostalCode Required")]
        public int? PostalCode { get; set; }
        public Guid Id { get; set; }
    }
}
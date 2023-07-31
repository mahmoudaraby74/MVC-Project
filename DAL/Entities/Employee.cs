﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(5)]

        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        //[DataType(DataType.Date)]
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public String PhoneNumber { get; set; }

        public DateTime HireDate { get; set; }
        public DateTime DAteOfCreation { get; set; } = DateTime.Now;
        public string ImageUrl { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }










    }
}

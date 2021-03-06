﻿using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSqliteCodeFirst.Data.Tables
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Unique]
        [Required]
        public string Name { get; set; }

        public int? Age { get; set; }

        [ForeignKey("PersonRole")]
        public long? RoleId { get; set; }

        public Role PersonRole { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}

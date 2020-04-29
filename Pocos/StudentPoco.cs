﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pocos
{
    [Table("Student")]
  public class StudentPoco
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string course { get; set; }
        public DateTime DoB { get; set; }
    }
}

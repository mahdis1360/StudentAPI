using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
   public  class StudentDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string course { get; set; }
        public DateTime DoB { get; set; }
    }
}
